using aadea.Logicaq;
using aadea.userControls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Input.Manipulations;
using static System.Windows.Forms.Design.AxImporter;

namespace aadea.Vistas
{
    public partial class FormMateriales : Form
    {
        private string rutaSeleccionada;
        private string rutaModify;

        public FormMateriales()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(AddMaterial);
            tabControl1.TabPages.Remove(EditMaterial);
            opcionBox.Items.Add("KG");
            opcionBox.Items.Add("L");
            opcionBox.Items.Add("Unidad");
            boxMedidaActual.Items.Add("KG");
            boxMedidaActual.Items.Add("L");
            boxMedidaActual.Items.Add("Unidad");
        }

        private void FormMaterials_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            L_Materials l_materials = new L_Materials();
            DataTable dataTable = l_materials.listMaterials();
            foreach (DataRow row in dataTable.Rows)
            {
                UserMaterial userControl = new UserMaterial();

                int id = Convert.ToInt32(row["ID"]);
                string name = row["nombre"].ToString();
                MessageBox.Show("el nombre es: " + name);
                string stock = row["stock"].ToString();
                string unidad = row["unidad"].ToString();
                byte[] imagen = l_materials.ObtenerImagenMaterial(id);
                userControl.nombretit = name;
                userControl.Cantidad = stock;
                userControl.Unidad = unidad;
                userControl.ID = Convert.ToInt32(row["ID"]);

                // Suscribirte al evento DeleteButtonClicked y pasar el UserControl
                userControl.buttonDeleteClick += (s, args) =>
                {
                    UserControl_DeleteButtonClicked(userControl);
                };
                userControl.buttonModifyClick += (s, args) =>
                {
                    UserControl_ButtonModify(userControl);
                };


                if (imagen != null && imagen.Length > 0)
                {
                    
                    using (MemoryStream ms = new MemoryStream(imagen))
                    {
                        Image img = Image.FromStream(ms);
                        userControl.PicMaterial1 = img;
                    }
                }
                else
                {
                    userControl.PicMaterial1 = Properties.Resource.defaultImage;
                }
                flowLayoutPanel1.Controls.Add(userControl);
            }

        }
        private void UserControl_ButtonModify(UserMaterial user)
        {

            string nombre = user.nombretit;
            string cantidad = user.Cantidad;
            string unidad = user.Unidad;
            Image imagen = user.PicMaterial1;
            tabControl1.SelectedTab = EditMaterial;
            tabControl1.TabPages.Add(EditMaterial);
            tabControl1.TabPages.Remove(ListaMateriales);
            tabControl1.TabPages.Remove(AddMaterial);
            // Rellenar los elementos en la pestaña de modificación
            txtNameActual.Text = nombre;
            txtStockActual.Text = cantidad;
            boxMedidaActual.SelectedItem = unidad;
            picImagenModify.Image = imagen;
        }

        private void UserControl_DeleteButtonClicked(UserMaterial user)
        {
            int id = Convert.ToInt32(user.ID);
            L_Materials l_materials = new L_Materials();
            flowLayoutPanel1.Controls.Remove(user);
            l_materials.DeleteMaterial(id);
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            resetCampos();
            tabControl1.SelectedTab = AddMaterial;
            tabControl1.TabPages.Add(AddMaterial);
            tabControl1.TabPages.Remove(ListaMateriales);
            tabControl1.TabPages.Remove(EditMaterial);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            resetCampos();
            tabControl1.SelectedTab = ListaMateriales;
            tabControl1.TabPages.Add(ListaMateriales);
            tabControl1.TabPages.Remove(AddMaterial);
            tabControl1.TabPages.Remove(EditMaterial);
        }

        private void btExaminar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog selectorImagen = new System.Windows.Forms.OpenFileDialog();
            selectorImagen.Title = "Seleccionar imagen";

            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                iconPictureBox1.Image = System.Drawing.Image.FromStream(selectorImagen.OpenFile());
                rutaSeleccionada = selectorImagen.FileName;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string nombre = txtNameInsert.Text;
            string stocktext = txtStock.Text;
            int numero = 0;
            bool opcion = false;
            try
            {
                if (int.TryParse(stocktext, out numero))
                {
                    labelResultado.Text = "El número ingresado es: " + numero.ToString();
                    opcion = true;
                }
                else
                {
                    MessageBox.Show("El valor ingresado no es un número válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message);

            }

            string unidad = opcionBox.Text;
            L_Materials insert = new L_Materials();
            if (opcion)
            {
                if (!string.IsNullOrEmpty(rutaSeleccionada) && opcion)
                {

                    byte[] bytesImagen = File.ReadAllBytes(rutaSeleccionada);
                    insert.InsertMaterialWI(nombre, numero, bytesImagen, unidad);
                    MessageBox.Show("Producto ingresado con exito");
                    tabControl1.SelectedTab = ListaMateriales;
                    tabControl1.TabPages.Add(ListaMateriales);
                    tabControl1.TabPages.Remove(AddMaterial);
                    tabControl1.TabPages.Remove(EditMaterial);
                    FormMaterials_Load(sender, e);
                }
                else
                {
                    insert.InsertMaterial(nombre, numero, unidad);
                    MessageBox.Show("Producto ingresado con exito");
                    tabControl1.SelectedTab = ListaMateriales;
                    tabControl1.TabPages.Add(ListaMateriales);
                    tabControl1.TabPages.Remove(AddMaterial);
                    tabControl1.TabPages.Remove(EditMaterial);
                    FormMaterials_Load(sender, e);
                }
            }
        }
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btSaveMod_Click(object sender, EventArgs e)
        {
            /*
            string nombre = txtNameActual.Text;
            string stocktext = txtStockActual.Text;
            int numero = 0;
            bool opcion = false;
            byte[] image;
            if (picImagenModify.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    picImagenModify.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    image = ms.ToArray();
                }
            }
            try
            {
                if (int.TryParse(stocktext, out numero))
                {
                    labelResultado.Text = "El número ingresado es: " + numero.ToString();
                    opcion = true;
                }
                else
                {
                    MessageBox.Show("El valor ingresado no es un número válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message);

            }

            string unidad = boxMedidaActual.Text;
            L_Materials insert = new L_Materials();
            */

        }

        private void btCancelMod_Click(object sender, EventArgs e)
        {
            resetCampos();

            tabControl1.SelectedTab = ListaMateriales;
            tabControl1.TabPages.Add(ListaMateriales);
            tabControl1.TabPages.Remove(AddMaterial);
            tabControl1.TabPages.Remove(EditMaterial);
        }

        private void resetCampos()
        {
            txtNameActual.Text = string.Empty;
            txtNameInsert.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtStockActual.Text = string.Empty;
            boxMedidaActual.Text = string.Empty;
            opcionBox.Text = string.Empty;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

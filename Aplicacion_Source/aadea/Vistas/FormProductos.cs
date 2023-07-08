using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Controls;
using System.Drawing;
using System.Windows.Forms;
using aadea.Logicaq;
using aadea.userControls;
using Image = System.Drawing.Image;
using FontAwesome.Sharp;

namespace aadea.Vistas
{

    public partial class FormProductos : Form
    {
        private string rutaSeleccionada;
        private System.Windows.Forms.UserControl selectedUserControl;
        private int idlocal;
        public FormProductos()
        {
            InitializeComponent();
            tabControl.TabPages.Remove(AddP);
            tabControl.TabPages.Remove(EditP);
        }

        private void resetCampos(object sender, EventArgs e)
        {
            idlocal = -1;
            txtProduct.Text = string.Empty;
            txtDesc.Text = string.Empty;
            examinarPic.Image = null;
            cambiarBox.Image = null;
            textBox1.Text = string.Empty;
            textBox1.Text = string.Empty;
            rutaSeleccionada = null;
            FormProductos_Load(sender, e);
        }

        private void AddProduct_Click_1(object sender, EventArgs e)
        {
            tabControl.SelectedTab = AddP;
            tabControl.TabPages.Remove(productList);
            tabControl.TabPages.Remove(EditP);
            tabControl.TabPages.Add(AddP);
            resetCampos(sender, e);
        }
        private void FormProductos_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            L_Products l_products = new L_Products();
            DataTable dataTable = l_products.listProducts();
            foreach (DataRow row in dataTable.Rows)
            {
                UserProduct userControl = new UserProduct();
                int id = Convert.ToInt32(row["ID"]);
                string nombre = row["nombre"].ToString();
                string desc = row["descripcion"].ToString();
                byte[] imagen = l_products.ObtenerImagenProducto(id);
                userControl.Tittle = nombre;
                userControl.Desc = desc;
                userControl.ID = Convert.ToInt32(row["ID"]);

                userControl.btDeleteProducto += (s, args) =>
                {
                    UserControl_DeleteButtonClicked(userControl);
                    idlocal=userControl.ID;
                };
                userControl.btModifyProducto += (s, args) =>
                {
                    UserControl_ButtonModify(userControl);
                    idlocal = userControl.ID;
                };

                if (imagen != null && imagen.Length > 0)
                {

                    using (MemoryStream ms = new MemoryStream(imagen))
                    {
                        System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                        userControl.PictureBox1 = img;
                    }
                }
                else
                {
                    userControl.PictureBox1 = Properties.Resource.defaultImage;
                }
                flowLayoutPanel1.Controls.Add(userControl);
            }
        }
        

        private void UserControl_ButtonModify(UserProduct user)
        {

            string nombre = user.Tittle;
            string desc = user.Desc;
            int id = user.ID;
            idlocal = user.ID;
            Image imagen = user.PictureBox1;

            tabControl.SelectedTab = EditP;
            tabControl.TabPages.Add(EditP);
            tabControl.TabPages.Remove(AddP);
            tabControl.TabPages.Remove(productList);

            // Rellenar los elementos en la pestaña de modificación
            textBox1.Text = nombre;
            textBox2.Text = desc;
            cambiarBox.Image = imagen;
        }


        private void UserControl_DeleteButtonClicked(UserProduct user)
        {
            int id = Convert.ToInt32(user.ID);
            L_Products l_Products = new L_Products();
            flowLayoutPanel1.Controls.Remove(user);
            l_Products.DeleteProduct(id);
        }


        private void btExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Seleccionar imagen";

            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                examinarPic.Image = System.Drawing.Image.FromStream(selectorImagen.OpenFile());
                rutaSeleccionada = selectorImagen.FileName;

            }
        }

        //Boton guardar
        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;
            string desc;
            L_Products ins = new L_Products();
            nombre = txtProduct.Text;
            desc = txtDesc.Text;
            if (!string.IsNullOrEmpty(rutaSeleccionada))
            {
                byte[] bytesImagen = File.ReadAllBytes(rutaSeleccionada);
                ins.InsertProductWI(nombre, desc, bytesImagen);
            }
            else
            {
                ins.InsertProduct(nombre, desc);
            }
            tabControl.SelectedTab = productList;
            tabControl.TabPages.Remove(AddP);
            tabControl.TabPages.Remove(EditP);
            tabControl.TabPages.Add(productList);
            resetCampos(sender,e);
            

        }

        private void btCancelAdd_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = productList;
            tabControl.TabPages.Remove(AddP);
            tabControl.TabPages.Remove(EditP);
            tabControl.TabPages.Add(productList);
            resetCampos(sender, e);
        }

        private void btCancelEdit_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = productList;
            tabControl.TabPages.Remove(AddP);
            tabControl.TabPages.Remove(EditP);
            tabControl.TabPages.Add(productList);
            resetCampos(sender, e);
        }

        private void btDelete_Click_1(object sender, EventArgs e)
        {
            if (selectedUserControl != null)
            {
                L_Products l_Products = new L_Products();
                int id = ((UserProduct)selectedUserControl).ID;
                l_Products.DeleteProduct(id);
                resetCampos(sender, e);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }
        }

        private void btSaveEdit_Click(object sender, EventArgs e)
        {
            
            string nombre;
            string desc;
            
            L_Products ins = new L_Products();

            if (!string.IsNullOrEmpty(rutaSeleccionada))
            {

                byte[] bytesImagen = File.ReadAllBytes(rutaSeleccionada);
                nombre = textBox1.Text;
                desc = textBox2.Text;
                
                ins.updateWI(idlocal,nombre, desc, bytesImagen);
            }
            else
            {
                // No se ha seleccionado ninguna ruta, realiza acciones adicionales o muestra un mensaje de error
                nombre = textBox1.Text;
                desc = textBox2.Text;

                ins.update(idlocal, nombre, desc);
            }
            tabControl.SelectedTab = productList;
            tabControl.TabPages.Remove(AddP);
            tabControl.TabPages.Remove(EditP);
            tabControl.TabPages.Add(productList);
            resetCampos(sender, e);
        }

        private void btexam_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog selectorImagen = new System.Windows.Forms.OpenFileDialog();
            selectorImagen.Title = "Seleccionar imagen";

            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                cambiarBox.Image = System.Drawing.Image.FromStream(selectorImagen.OpenFile());
                rutaSeleccionada = selectorImagen.FileName;
            }
        }
        public byte[] ConvertirImagenABytes(Image imagen)
        {
            if (imagen != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imagen.Save(ms, imagen.RawFormat);
                    return ms.ToArray();
                }
            }
            else
            {
                return null;
            }
        }
    }
}

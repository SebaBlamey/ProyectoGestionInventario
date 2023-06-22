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

namespace aadea.Vistas
{

    public partial class FormProductos : Form
    {
        private string rutaSeleccionada;
        private System.Windows.Forms.UserControl selectedUserControl;
        public FormProductos()
        {
            InitializeComponent();
            tabControl.TabPages.Remove(AddP);
            tabControl.TabPages.Remove(EditP);
        }


        private void resetCampos(object sender, EventArgs e)
        {
            txtProduct.Text = string.Empty;
            txtDesc.Text = string.Empty;
            examinarPic.Image = null;
            FormProductos_Load(sender, e);
        }


        private void AddProduct_Click_1(object sender, EventArgs e)
        {
            tabControl.SelectedTab = AddP;
            tabControl.TabPages.Remove(productList);
            tabControl.TabPages.Remove(EditP);
            tabControl.TabPages.Add(AddP);

        }
        private void EdtiProduct_Click_1(object sender, EventArgs e)
        {
            if (selectedUserControl != null)
            {
                //movemos a la pestaña editar
                tabControl.SelectedTab = EditP;
                tabControl.TabPages.Remove(AddP);
                tabControl.TabPages.Remove(productList);
                tabControl.TabPages.Add(EditP);
                //obtenemos datos del producto elegido
                string nombre = ((UserProduct)selectedUserControl).Tittle;
                string desc = ((UserProduct)selectedUserControl).Desc;
                System.Drawing.Image image = ((UserProduct)selectedUserControl).PictureBox1;
                //rellenamos la pagina de editar con los datos que obtuvimos
                System.Windows.Forms.TextBox textBoxTitulo = EditP.Controls.Find("textBox1", true).FirstOrDefault() as System.Windows.Forms.TextBox;
                System.Windows.Forms.TextBox textBoxDescripcion = EditP.Controls.Find("textBox2", true).FirstOrDefault() as System.Windows.Forms.TextBox;
                PictureBox pictureBoxImagen = EditP.Controls.Find("cambiarBox", true).FirstOrDefault() as PictureBox;

                if (textBoxTitulo != null)
                    textBoxTitulo.Text = nombre;

                if (textBoxDescripcion != null)
                    textBoxDescripcion.Text = desc;

                if (pictureBoxImagen != null)
                    pictureBoxImagen.Image = image;
            }
            else
            {
                MessageBox.Show("Por favor seleccione una producto para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormProductos_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            L_Products l_products = new L_Products();
            DataTable dataTable = l_products.listProducts();
            foreach (DataRow row in dataTable.Rows)
            {
                UserProduct userControl = new UserProduct();
                userControl.Click += UserControl_Click;
                int id = Convert.ToInt32(row["ID"]);
                string nombre = row["nombre"].ToString();
                string desc = row["descripcion"].ToString();
                byte[] imagen = l_products.ObtenerImagenProducto(id);
                userControl.Tittle = nombre;
                userControl.Desc = desc;
                userControl.ID = id;
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
        private void UserControl_Click(object? sender, EventArgs e)
        {
            if (selectedUserControl != null)
            {
                selectedUserControl.BackColor = SystemColors.Control; // Cambia el fondo a su estado original
            }

            // Marca el User Control actualmente seleccionado
            selectedUserControl = (System.Windows.Forms.UserControl)sender;

            // Cambia el fondo del User Control seleccionado
            selectedUserControl.BackColor = Color.LightBlue;
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
            byte[] img = null;
            L_Products ins = new L_Products();

            if (!string.IsNullOrEmpty(rutaSeleccionada))
            {

                byte[] bytesImagen = File.ReadAllBytes(rutaSeleccionada);
                nombre = txtProduct.Text;
                desc = txtDesc.Text;

                ins.InsertProductWI(nombre, desc, bytesImagen);
            }
            else
            {
                // No se ha seleccionado ninguna ruta, realiza acciones adicionales o muestra un mensaje de error
                nombre = txtProduct.Text;
                desc = txtDesc.Text;

                ins.InsertProduct(nombre, desc);
            }
            tabControl.SelectedTab = productList;
            tabControl.TabPages.Remove(AddP);
            tabControl.TabPages.Remove(EditP);
            tabControl.TabPages.Add(productList);
            txtProduct.Text = string.Empty;
            txtDesc.Text = string.Empty;
            examinarPic.Image = null;
            FormProductos_Load(sender, e);

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
            L_Products l_list= new L_Products();
            System.Windows.Forms.TextBox textBoxTitulo = EditP.Controls.Find("textBox1", true).FirstOrDefault() as System.Windows.Forms.TextBox;
            System.Windows.Forms.TextBox textBoxDescripcion = EditP.Controls.Find("textBox2", true).FirstOrDefault() as System.Windows.Forms.TextBox;
            PictureBox pictureBoxImagen = EditP.Controls.Find("cambiarBox", true).FirstOrDefault() as PictureBox;
            Image nuevaimagen = pictureBoxImagen.Image;
            string nuevoName=textBoxTitulo.Text;
            string nuevoDescripcion=textBoxDescripcion.Text;
            int id = ((UserProduct)selectedUserControl).ID;
            if (textBoxTitulo != null)
            {
                // Obtener los valores de los controles
                nuevoName = textBoxTitulo.Text;
                nuevoDescripcion = textBoxDescripcion.Text;
                nuevaimagen = pictureBoxImagen.Image;

            }
            else
            {
                MessageBox.Show("El producto a ingresar debe tener al menos el nombre.");
            }
            if (nuevaimagen == null)
            {
                l_list.update(id,nuevoName, nuevoDescripcion);
            }
            else
            {
                byte[] ima = ConvertirImagenABytes(nuevaimagen);
                l_list.updateWI(id,nuevoName,nuevoDescripcion,ima);
            }

            tabControl.SelectedTab = productList;
            tabControl.TabPages.Remove(AddP);
            tabControl.TabPages.Remove(EditP);
            tabControl.TabPages.Add(productList);
            resetCampos(sender, e);
        }

        private void btexam_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
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

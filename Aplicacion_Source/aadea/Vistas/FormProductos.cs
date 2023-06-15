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

namespace aadea.Vistas
{

    public partial class FormProductos : Form
    {
        private string rutaSeleccionada;
        public FormProductos()
        {
            InitializeComponent();
            tabControl.TabPages.Remove(AddP);
            tabControl.TabPages.Remove(EditP);
        }


        private void ListadoP()
        {
            L_Products datos = new L_Products();
            GVProduct.DataSource = datos.listProducts();

        }

        private void Formato_P()
        {
            GVProduct.Columns[0].Width = 170;
            GVProduct.Columns[1].Width = 170;

        }



        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void lbImagen_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void productList_Click(object sender, EventArgs e)
        {

        }

        private void DetailsP_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = AddP;
            tabControl.TabPages.Remove(productList);
            tabControl.TabPages.Remove(EditP);
            tabControl.TabPages.Add(AddP);


        }
        /*
        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtSearch.Text.Trim().ToLower();

            // Verificar si la columna "nombre" existe en el DataGridView
            if (GVProduct.Columns.Contains("nombre"))
            {
                // Iterar por cada fila del DataGridView
                foreach (DataGridViewRow row in GVProduct.Rows)
                {
                        // Obtener el valor de la celda en la columna "nombre" de cada fila
                        string nombreProducto = row.Cells["nombre"].Value?.ToString()?.ToLower() ?? "";


                        // Ocultar la fila si el nombre del producto no contiene el texto de búsqueda
                        row.Visible = nombreProducto.Contains(textoBusqueda);
                }
            }
        }*/
        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void EdtiProduct_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = EditP;
            tabControl.TabPages.Remove(AddP);
            tabControl.TabPages.Remove(productList);
            tabControl.TabPages.Add(EditP);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            this.ListadoP();
            this.Formato_P();
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

        private void GVProduct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ForeColor = Color.Black;
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
            txtProduct.Text = string.Empty;
            txtDesc.Text = string.Empty;
            examinarPic.Image = null;
            FormProductos_Load(sender, e);
        }

        private void btCancelEdit_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = productList;
            tabControl.TabPages.Remove(AddP);
            tabControl.TabPages.Remove(EditP);
            tabControl.TabPages.Add(productList);
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            cambiarBox.Image = null;
            FormProductos_Load(sender, e);



        }

        private void cambiarBox_Click(object sender, EventArgs e)
        {

        }

        private void GVProduct_SelectionChanged(object sender, EventArgs e)
        {
            L_Products productos = new L_Products();
            if (GVProduct.SelectedRows.Count > 0)
            {
                // Obtén el ID del producto de la fila seleccionada en el DataGridView
                int productoID = Convert.ToInt32(GVProduct.SelectedRows[0].Cells["ID"].Value);

                // Obtén los datos de imagen del producto desde la base de datos
                byte[] imagenBytes = productos.ObtenerImagenProducto(productoID);

                if (imagenBytes != null)
                {
                    // Convierte los bytes de imagen a un objeto Image del espacio de nombres System.Drawing
                    using (MemoryStream ms = new MemoryStream(imagenBytes))
                    {
                        System.Drawing.Image imagen = System.Drawing.Image.FromStream(ms);

                        // Asigna la imagen al PictureBox
                        pictureBox1.Image = imagen;
                    }
                }
                else
                {
                    // No se encontró ninguna imagen para el producto seleccionado
                    pictureBox1.Image = null;
                }
            }

        }

        private void GVProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            L_Products productos = new L_Products();
            if (GVProduct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione una fila para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = Convert.ToInt32(GVProduct.SelectedRows[0].Cells["ID"].Value);
            productos.DeleteProduct(id);
            GVProduct.DataSource = null;
            GVProduct.Rows.Clear();
            FormProductos_Load(sender, e);
        }
    }
}

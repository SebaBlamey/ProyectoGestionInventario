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
using System.Windows.Forms;
using aadea.Logicaq;

namespace aadea.Vistas
{
    public partial class FormProductos : Form
    {
        private byte[] image;
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
                MemoryStream memoria = new MemoryStream();
                examinarPic.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);
                image = memoria.ToArray();
            }
        }

        private void GVProduct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;
            string desc;
            byte[] img = null;
            L_Products ins = new L_Products();

            if (examinarPic.Image != null)
            {
                nombre = txtProduct.Text;
                desc = txtDesc.Text;

                System.Drawing.Image imagen = pictureBox1.Image;
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    imagen.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    img = memoryStream.ToArray();
                }

                ins.InsertProductWI(nombre, desc, img);
            }
            else
            {
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

        private void btexam_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Seleccionar imagen";

            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                cambiarBox.Image = System.Drawing.Image.FromStream(selectorImagen.OpenFile());
                MemoryStream memoria = new MemoryStream();
                cambiarBox.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);
                image = memoria.ToArray();
            }
        }
    }
}

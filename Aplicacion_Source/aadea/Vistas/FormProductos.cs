using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            GVProduct.Columns[2].Width = 170;

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
                examinarPic.Image = Image.FromStream(selectorImagen.OpenFile());
                MemoryStream memoria = new MemoryStream();
                examinarPic.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);
                image = memoria.ToArray();
            }
        }
    }
}

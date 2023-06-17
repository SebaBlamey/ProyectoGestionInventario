using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aadea.userControls
{
    public partial class productBodega : UserControl
    {
        public productBodega()
        {
            InitializeComponent();
        }

        #region Properties
        public string Tittle
        {
            get { return nameProduct.Text; }
            set { nameProduct.Text = value; }
        }

        public Image PictureBox1
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public DataGridView DataGridView1
        {
            get { return dataGridViewInv; }
        }
        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
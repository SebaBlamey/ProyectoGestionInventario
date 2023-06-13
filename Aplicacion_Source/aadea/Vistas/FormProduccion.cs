using aadea.Logicaq;
using aadea.Model;
using aadea.userControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aadea.Vistas
{
    public partial class FormProduccion : Form
    {
        public FormProduccion()
        {
            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ListadoProduc()
        {
            L_Produccion datos = new L_Produccion();
            //DGV_materiales.DataSource = datos.listProduccion();
        }

        private void Formato_P()
        {
            //DGV_materiales.Columns[0].Width = 170;
            //DGV_materiales.Columns[1].Width = 170;

        }

        private void FormProducion_Load(object sender, EventArgs e)
        {
            this.ListadoProduc();
            this.Formato_P();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

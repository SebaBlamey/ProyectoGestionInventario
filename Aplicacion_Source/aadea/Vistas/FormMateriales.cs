using aadea.Logicaq;
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
    public partial class FormMateriales : Form
    {
        public FormMateriales()
        {
            InitializeComponent();
        }

        private void ListaM()
        {
            L_Materials info = new L_Materials();
            DGV_materiales.AutoGenerateColumns = true;
            DGV_materiales.DataSource = info.listMaterials();
        }

        private void FormMaterials_Load(object sender, EventArgs e)
        {
            this.ListaM();
            this.Formato_M();

        }

        private void Formato_M()
        {
            DGV_materiales.Columns[0].Width = 200;
        }
    }
}

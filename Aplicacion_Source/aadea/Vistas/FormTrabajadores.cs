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
    public partial class FormTrabajadores : Form
    {
        public FormTrabajadores()
        {
            InitializeComponent();
        }

        private void ListadoT()
        {
            L_Trabajadores datos = new L_Trabajadores();
            DGV_T.DataSource = datos.Listado_Trabajadores();

        }

        private void FormTrabajadores_Load(object sender, EventArgs e)
        {
            this.ListadoT();
        }
    }
}

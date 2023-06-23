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
    public partial class produccionActual : UserControl
    {
        public produccionActual()
        {
            InitializeComponent();
        }

        public string Tittle
        {
            get { return lblProduccion.Text; }
            set { lblProduccion.Text = value; }
        }

        public string fechaTermino
        {
            get { return dateProduccion.Text; }
            set { dateProduccion.Text = value; }
        }

        public DataGridView DataGridViewMateriales
        {
            get { return DGVmateriales; }
        }

    }
}

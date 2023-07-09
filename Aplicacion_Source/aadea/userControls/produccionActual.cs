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
        private int _id;
        public event EventHandler ProduccionActualEnd;
        public event EventHandler ProduccionActualDelete;
        private string ft;
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

        public string fechaInicio
        {
            get { return fecha_inicio.Text; }
            set { fecha_inicio.Text = value; }
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string fechaterm
        {
            get { return dateProduccion.Text; }
            set { dateProduccion.Text = value; }
        }

        public void btDelete_Click(object sender, EventArgs e)
        {
            ProduccionActualDelete?.Invoke(this, EventArgs.Empty);
        }

        public void btEnd_Click(object sender, EventArgs e)
        {
            ProduccionActualEnd?.Invoke(this, EventArgs.Empty);
        }

    }
}

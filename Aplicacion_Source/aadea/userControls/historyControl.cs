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
    public partial class historyControl : UserControl
    {
        public historyControl()
        {
            InitializeComponent();
        }

        #region Properties

        public string Tittle
        {
            get { return lblProduct.Text; }
            set { lblProduct.Text = value; }
        }

        public string fechaInicio
        {
            get { return lblInsertInicio.Text; }
            set { lblInsertInicio.Text = value; }
        }

        public string fechaTermino
        {
            get { return lblInsertTermino.Text; }
            set { lblInsertTermino.Text = value; }
        }

        public DataGridView DataGridViewMateriales
        {
            get { return DGV_materiales; }
        }

        public DataGridView DataGridViewProductos
        {
            get { return DGV_Producto; }
        }

        #endregion
    }
}

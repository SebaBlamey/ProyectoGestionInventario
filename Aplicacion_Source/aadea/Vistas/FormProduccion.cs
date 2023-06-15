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
using System.Windows.Controls;
using System.Windows.Forms;

namespace aadea.Vistas
{
    public partial class FormProduccion : Form
    {
        public FormProduccion()
        {
            InitializeComponent();
            tabControlProduccion.TabPages.Remove(tabHistory);
            tabControlProduccion.TabPages.Remove(tabIngresarProduccion);
            tabControlProduccion.TabPages.Remove(tabProduccionActual);


        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            tabControlProduccion.SelectedTab = tabHistory;
            tabControlProduccion.TabPages.Remove(viewButtons);
            tabControlProduccion.TabPages.Remove(tabIngresarProduccion);
            tabControlProduccion.TabPages.Remove(tabProduccionActual);
            tabControlProduccion.TabPages.Add(tabHistory);


            L_Produccion l_produccion = new L_Produccion();
            DataTable dataTable = l_produccion.ListHistorial();
            foreach (DataRow row in dataTable.Rows)
            {
                historyControl userControl = new historyControl();

                int id = Convert.ToInt32(row["ID"]);
                string fecha_inicio = row["fecha_inicio"].ToString();
                string fecha_termino = row["fecha_termino"].ToString();

                userControl.fechaInicio = fecha_inicio;
                userControl.fechaTermino = fecha_termino;
                userControl.Tittle += " " + id;
                LayoutHistorial.Controls.Add(userControl);
                DataTable tableMaterial= l_produccion.listMaterialForHistory(id);
                DataTable tableProduct = l_produccion.GetProductHistory(id);
                userControl.DataGridViewMateriales.DataSource = tableMaterial;
                userControl.DataGridViewProductos.DataSource = tableProduct;
            }
        }

        private void btViewProduccion_Click(object sender, EventArgs e)
        {
            tabControlProduccion.SelectedTab = tabProduccionActual;
            tabControlProduccion.TabPages.Remove(viewButtons);
            tabControlProduccion.TabPages.Remove(tabIngresarProduccion);
            tabControlProduccion.TabPages.Remove(tabHistory);
            tabControlProduccion.TabPages.Add(tabProduccionActual);
        }

        private void btIngresarProduccion_Click(object sender, EventArgs e)
        {
            tabControlProduccion.SelectedTab = tabIngresarProduccion;
            tabControlProduccion.TabPages.Remove(tabHistory);
            tabControlProduccion.TabPages.Remove(viewButtons);
            tabControlProduccion.TabPages.Remove(tabProduccionActual);
            tabControlProduccion.TabPages.Add(tabIngresarProduccion);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttExitHistory_Click(object sender, EventArgs e)
        {
            tabControlProduccion.SelectedTab = viewButtons;
            tabControlProduccion.TabPages.Remove(tabHistory);
            tabControlProduccion.TabPages.Remove(tabIngresarProduccion);
            tabControlProduccion.TabPages.Remove(tabProduccionActual);
            tabControlProduccion.TabPages.Add(viewButtons);
        }
    }
}

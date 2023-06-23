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
using System.Windows.Media.Media3D;

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
            DGVAddProduccion.Columns.Add("Material", "Material");
            DGVAddProduccion.Columns.Add("Cantidad", "Cantidad");
        }

        //HISTORIAL
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
                DataTable tableMaterial = l_produccion.listMaterialForHistory(id);
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
            FormLoadProduccionActual(sender, e);
        }



        private void btIngresarProduccion_Click(object sender, EventArgs e)
        {
            tabControlProduccion.SelectedTab = tabIngresarProduccion;
            tabControlProduccion.TabPages.Remove(tabHistory);
            tabControlProduccion.TabPages.Remove(viewButtons);
            tabControlProduccion.TabPages.Remove(tabProduccionActual);
            tabControlProduccion.TabPages.Add(tabIngresarProduccion);
        }

        private void bttExitHistory_Click(object sender, EventArgs e)
        {
            tabControlProduccion.SelectedTab = viewButtons;
            tabControlProduccion.TabPages.Remove(tabHistory);
            tabControlProduccion.TabPages.Remove(tabIngresarProduccion);
            tabControlProduccion.TabPages.Remove(tabProduccionActual);
            tabControlProduccion.TabPages.Add(viewButtons);
        }


        //PRODUCCION ACTUAL
        private void FormLoadProduccionActual(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                produccionActual user = new produccionActual();
                int producc = i;
                user.Tittle = "Producción numero: " + i + 1;
                flowLayoutPanel1.Controls.Add(user);

            }

        }

        private void btExitProduccionActual_Click(object sender, EventArgs e)
        {
            tabControlProduccion.SelectedTab = viewButtons;
            tabControlProduccion.TabPages.Remove(tabHistory);
            tabControlProduccion.TabPages.Remove(tabIngresarProduccion);
            tabControlProduccion.TabPages.Remove(tabProduccionActual);
            tabControlProduccion.TabPages.Add(viewButtons);
        }

        //INGRESAR PRODUCCION

        /*
        private void addProduccion(object sender, EventArgs e)
        {
            L_Produccion l_list = new L_Produccion();
            // Obtener los materiales disponibles desde la base de datos
            DataTable materialesTable = l_list.ObtenerMateriales();

            // Llenar el DataGridView con los datos de los materiales
            DGVAddProduccion.Rows.Clear(); // Limpiar las filas existentes

            foreach (DataRow row in materialesTable.Rows)
            {
                int materialID = Convert.ToInt32(row["ID"]);
                string nombre = row["Nombre"].ToString();

                // Agregar una nueva fila al DataGridView
                int rowIndex = DGVAddProduccion.Rows.Add();

                // Establecer los valores de las celdas en la nueva fila
                DGVAddProduccion.Rows[rowIndex].Cells["Material"].Value = materialID;
                DGVAddProduccion.Rows[rowIndex].Cells["Cantidad"].Value = 0; // Valor inicial de la cantidad, puedes cambiarlo según tus necesidades
            }

        }*/
        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            /*
            DGVAddProduccion.Rows.Clear();
            int cantidad = 0;
            if (int.TryParse(textBoxCantidad.Text, out cantidad))
            {
                for (int i = 1; i <= cantidad; i++)
                {
                    DataGridViewComboBoxCell comboCell = new DataGridViewComboBoxCell();
                    comboCell.Items.Add("Material 1");
                    comboCell.Items.Add("Material 2");
                    // Agrega más elementos según los materiales disponibles
                    DGVAddProduccion.Rows.Add(comboCell, "");
                }
            }*/

            DGVAddProduccion.Rows.Clear();
            DGVAddProduccion.Columns.Clear();
            DGVAddProduccion.Columns.Add("Material", "Material");
            DGVAddProduccion.Columns.Add("Cantidad", "Cantidad");
            L_Produccion l_list= new L_Produccion();
            DataTable dt = l_list.ObtenerMateriales();
            // Agregar las filas al DataGridView
            foreach (DataRow row in dt.Rows)
            {
                string nombreMaterial = row["Nombre"].ToString();

                DataGridViewComboBoxCell comboCell = new DataGridViewComboBoxCell();
                comboCell.Items.Add(nombreMaterial);

                DGVAddProduccion.Rows.Add(comboCell, "");
            }
        }
    }
}

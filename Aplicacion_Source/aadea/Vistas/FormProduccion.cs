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
using System.Windows.Media.Media3D;

namespace aadea.Vistas
{
    public partial class FormProduccion : Form
    {
        private List<List<string>> opcionesMateriales;
        private List<string> materiales;
        private List<ComboBox> comboBoxesMateriales;
        private List<TextBox> textBoxesCantidad;
        private int idLocal;

        public FormProduccion()
        {
            InitializeComponent();
            tabControlProduccion.TabPages.Remove(tabHistory);
            tabControlProduccion.TabPages.Remove(tabIngresarProduccion);
            tabControlProduccion.TabPages.Remove(tabProduccionActual);

            comboBoxesMateriales = new List<ComboBox>();
            textBoxesCantidad = new List<TextBox>();

            L_Produccion l_list_mats = new L_Produccion();
            materiales = l_list_mats.ObtenerMateriales();
            opcionesMateriales = new List<List<string>>();

            for (int i = 0; i < 10; i++)
            {
                List<string> opciones = new List<string>(materiales); // Clona la lista original
                opcionesMateriales.Add(opciones);
            }

        }
        private void resertcampos(object sender, EventArgs e)
        {
            textBoxCantidad.Text = string.Empty;
        }




        //---------------------------------
        // HISTORIAL DE PRODUCCION
        //---------------------------------
        //Boton ver historial de producción.
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
        //salir de histotial de produccion.
        private void bttExitHistory_Click(object sender, EventArgs e)
        {
            tabControlProduccion.SelectedTab = viewButtons;
            tabControlProduccion.TabPages.Remove(tabHistory);
            tabControlProduccion.TabPages.Remove(tabIngresarProduccion);
            tabControlProduccion.TabPages.Remove(tabProduccionActual);
            tabControlProduccion.TabPages.Add(viewButtons);
        }





        //------------------------------------------------------
        //PRODUCCION ACTUAL
        //------------------------------------------------------
        //boton ver produccion actual
        private void btViewProduccion_Click(object sender, EventArgs e)
        {
            tabControlProduccion.SelectedTab = tabProduccionActual;
            tabControlProduccion.TabPages.Remove(viewButtons);
            tabControlProduccion.TabPages.Remove(tabIngresarProduccion);
            tabControlProduccion.TabPages.Remove(tabHistory);
            tabControlProduccion.TabPages.Add(tabProduccionActual);
            FormLoadProduccionActual(sender, e);
        }
        //CARGAR PRODUCCION ACTUAL
        private void FormLoadProduccionActual(object sender, EventArgs e)
        {
            layoutPanelActualProduccion.Controls.Clear();
            L_Produccion l_produccion = new L_Produccion();
            DataTable dataTable = l_produccion.listarProduccionActual();

            foreach (DataRow row in dataTable.Rows)
            {
                produccionActual user = new produccionActual();

                int id = Convert.ToInt32(row["ID"]);
                string name = row["nombre"].ToString();
                string fecha_inicio = row["fecha_inicio"].ToString();

                user.Tittle = name;
                user.fechaInicio = fecha_inicio;
                user.ID = id;
                user.ProduccionActualDelete += User_DeleteButtonClicked;
                user.ProduccionActualEnd += User_ButtonEnd;
                layoutPanelActualProduccion.Controls.Add(user);

                DataTable dataTable2 = l_produccion.getMaterialProduccion(id);
                user.DataGridViewMateriales.Rows.Clear();
                user.DataGridViewMateriales.Columns.Add("Nombre", "Nombre");
                user.DataGridViewMateriales.Columns.Add("Cantidad", "Cantidad");
                foreach (DataRow rows in dataTable2.Rows)
                {
                    int idMaterial = Convert.ToInt32(rows["id_material"]);
                    int cantidad = Convert.ToInt32(rows["cantidad"]);
                    string nombreMaterial = l_produccion.getNameMaterial(idMaterial);

                    user.DataGridViewMateriales.Rows.Add(nombreMaterial, cantidad);
                }
            }
        }


        private void User_ButtonEnd(object sender, EventArgs e)
        {
            produccionActual user = (produccionActual)sender;
            int idProduccion = user.ID;
            L_Produccion l = new L_Produccion();
            string termino = user.fechaterm;
            string inicio = user.fechaInicio;
            l.TerminarProduccion(idProduccion,termino,inicio);

            // Eliminar el user control del panel
            layoutPanelActualProduccion.Controls.Remove(user);
        }

        private void User_DeleteButtonClicked(object sender, EventArgs e)
        {
            produccionActual user = (produccionActual)sender;
            int id = user.ID;
            L_Produccion l = new L_Produccion();
            l.EliminarProduccion(id);

            // Eliminar el user control del panel
            layoutPanelActualProduccion.Controls.Remove(user);
        }

        private void btExitProduccionActual_Click(object sender, EventArgs e)
        {
            tabControlProduccion.SelectedTab = viewButtons;
            tabControlProduccion.TabPages.Remove(tabHistory);
            tabControlProduccion.TabPages.Remove(tabIngresarProduccion);
            tabControlProduccion.TabPages.Remove(tabProduccionActual);
            tabControlProduccion.TabPages.Add(viewButtons);
        }





        //------------------------------------------------------
        //INGRESAR PRODUCCION
        //------------------------------------------------------
        //boton ingresar produccion
        private void btIngresarProduccion_Click(object sender, EventArgs e)
        {
            tabControlProduccion.SelectedTab = tabIngresarProduccion;
            tabControlProduccion.TabPages.Remove(tabHistory);
            tabControlProduccion.TabPages.Remove(viewButtons);
            tabControlProduccion.TabPages.Remove(tabProduccionActual);
            tabControlProduccion.TabPages.Add(tabIngresarProduccion);
            this.Load += FormIngresarProduccion_Load;
            resertcampos(sender, e);
        }

        //cancelar producción
        private void btCancelAddproduccion_Click(object sender, EventArgs e)
        {
            tabControlProduccion.SelectedTab = viewButtons;
            tabControlProduccion.TabPages.Remove(tabHistory);
            tabControlProduccion.TabPages.Remove(tabIngresarProduccion);
            tabControlProduccion.TabPages.Remove(tabProduccionActual);
            tabControlProduccion.TabPages.Add(viewButtons);
            resertcampos(sender, e);
        }
        //rellenar ingresar produccion
        private void FormIngresarProduccion_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < materiales.Count; i++)
            {
                Label labelProducto = new Label();
                labelProducto.Text = "Producto:";
                labelProducto.AutoSize = true;

                ComboBox comboBoxMaterial = new ComboBox();
                comboBoxMaterial.DisplayMember = "nombre";
                comboBoxMaterial.DataSource = opcionesMateriales[i];
                comboBoxMaterial.DropDownStyle = ComboBoxStyle.DropDownList;

                Label labelCantidad = new Label();
                labelCantidad.Text = "Ingrese la cantidad:";
                labelCantidad.AutoSize = true;

                TextBox textBoxCantidad = new TextBox();

                comboBoxesMateriales.Add(comboBoxMaterial);
                textBoxesCantidad.Add(textBoxCantidad);

                flowLayoutPanelBox.Controls.Add(labelProducto);
                flowLayoutPanelBox.Controls.Add(comboBoxMaterial);
                flowLayoutPanelBox.Controls.Add(labelCantidad);
                flowLayoutPanelBox.Controls.Add(textBoxCantidad);
            }
        }
        //campo de cantidad de materiales
        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            int cantidadMateriales = 0;

            if (int.TryParse(textBoxCantidad.Text, out cantidadMateriales))
            {
                flowLayoutPanelBox.Controls.Clear();

                for (int i = 0; i < cantidadMateriales; i++)
                {
                    Label labelProducto = new Label();
                    labelProducto.Text = "Producto:";
                    labelProducto.AutoSize = true;
                    labelProducto.ForeColor = Color.Black;

                    ComboBox comboBoxMaterial = new ComboBox();
                    comboBoxMaterial.DisplayMember = "nombre";
                    comboBoxMaterial.DataSource = opcionesMateriales[i];
                    comboBoxMaterial.DropDownStyle = ComboBoxStyle.DropDownList;

                    Label labelCantidad = new Label();
                    labelCantidad.Text = "Ingrese la cantidad:";
                    labelCantidad.AutoSize = true;
                    labelCantidad.ForeColor = Color.Black;

                    TextBox textBoxCantidad = new TextBox();
                    comboBoxesMateriales.Add(comboBoxMaterial);
                    textBoxesCantidad.Add(textBoxCantidad);

                    flowLayoutPanelBox.Controls.Add(labelProducto);
                    flowLayoutPanelBox.Controls.Add(comboBoxMaterial);
                    flowLayoutPanelBox.Controls.Add(labelCantidad);
                    flowLayoutPanelBox.Controls.Add(textBoxCantidad);
                }
            }
            else
            {
                flowLayoutPanelBox.Controls.Clear();
            }
        }
        //boton aceptar de ingresar produccion
        private void btAceptar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int idProduccion = random.Next();

            string nombreProduccion = txtName.Text;
            string fechaInicio = dateAddProduccion.Value.ToString("dd-MM-yyyy");

            L_Produccion l_list = new L_Produccion();
            l_list.InsertarProduccion(idProduccion, nombreProduccion, fechaInicio);

            for (int i = 0; i < comboBoxesMateriales.Count; i++)
            {
                ComboBox comboBoxMaterial = comboBoxesMateriales[i];
                TextBox textBoxCantidad = textBoxesCantidad[i];

                string nombreMaterial = comboBoxMaterial.SelectedItem.ToString();
                int idMaterial = l_list.obtenerIdMaterial(nombreMaterial);

                int cantidad;
                string cantidadTexto = textBoxCantidad.Text;
                if (Int32.TryParse(cantidadTexto, out cantidad))
                {
                }
                else
                {
                    MessageBox.Show("Error");
                }

                l_list.InsertarMaterialProduccion(idProduccion, idMaterial, cantidad);
            }

            tabControlProduccion.SelectedTab = viewButtons;
            tabControlProduccion.TabPages.Remove(tabHistory);
            tabControlProduccion.TabPages.Remove(tabIngresarProduccion);
            tabControlProduccion.TabPages.Remove(tabProduccionActual);
            tabControlProduccion.TabPages.Add(viewButtons);
            resertcampos(sender, e);
        }
    }
}

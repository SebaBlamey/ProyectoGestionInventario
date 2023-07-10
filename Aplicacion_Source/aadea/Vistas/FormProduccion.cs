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
        private List<List<string>> opcionesProductos;
        private List<string> productos;
        private List<ComboBox> comboBoxesProductos;
        private List<TextBox> textBoxesCantidadProductos;
        private List<List<string>> opcionesFrascos;
        private List<string> Frascos;
        private List<ComboBox> comboBoxesFrascos;
        private List<TextBox> textBoxesCantidadFrascos;
        private int idLocal;
        private List<string> unidades;

        public FormProduccion()
        {
            InitializeComponent();
            tabControlProduccion.TabPages.Remove(tabHistory);
            tabControlProduccion.TabPages.Remove(tabIngresarProduccion);
            tabControlProduccion.TabPages.Remove(tabProduccionActual);
            tabControlProduccion.TabPages.Remove(tabBodega);

            comboBoxesMateriales = new List<ComboBox>();
            textBoxesCantidad = new List<TextBox>();
            comboBoxesProductos = new List<ComboBox>();
            textBoxesCantidadProductos = new List<TextBox>();
            comboBoxesFrascos = new List<ComboBox>();
            textBoxesCantidadFrascos = new List<TextBox>();

            L_Produccion l_list_mats = new L_Produccion();
            materiales = l_list_mats.ObtenerMateriales();
            opcionesMateriales = new List<List<string>>();

            productos = l_list_mats.ObtenerProductos();
            opcionesProductos = new List<List<string>>();

            Frascos = l_list_mats.ObtenerFrascos();
            opcionesFrascos = new List<List<string>>();

            for (int i = 0; i < 20; i++)
            {
                List<string> opciones = new List<string>(materiales); // Clona la lista original
                opcionesMateriales.Add(opciones);
            }

            for (int i = 0; i < 20; i++)
            {
                List<string> opcionesPr = new List<string>(productos); // Clona la lista original
                opcionesProductos.Add(opcionesPr);
            }

            for (int i = 0; i < 20; i++)
            {
                List<string> opcionesFrasc = new List<string>(Frascos);
                opcionesFrascos.Add(opcionesFrasc);
            }

            unidades = l_list_mats.unidadesMateriales();

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
            tabControlProduccion.TabPages.Remove(tabBodega);
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
            tabControlProduccion.TabPages.Remove(tabBodega);
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
            tabControlProduccion.TabPages.Remove(tabBodega);
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
            l.TerminarProduccion(idProduccion, termino, inicio);

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
            tabControlProduccion.TabPages.Remove(tabBodega);
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
            tabControlProduccion.TabPages.Remove(tabBodega);
            tabControlProduccion.TabPages.Add(tabIngresarProduccion);
            resertcampos(sender, e);
        }

        //cancelar producción
        private void btCancelAddproduccion_Click(object sender, EventArgs e)
        {
            tabControlProduccion.SelectedTab = viewButtons;
            tabControlProduccion.TabPages.Remove(tabHistory);
            tabControlProduccion.TabPages.Remove(tabIngresarProduccion);
            tabControlProduccion.TabPages.Remove(tabProduccionActual);
            tabControlProduccion.TabPages.Remove(tabBodega);
            tabControlProduccion.TabPages.Add(viewButtons);
            resertcampos(sender, e);
        }
        //rellenar ingresar produccion
        private void FormIngresarProduccion_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < materiales.Count; i++)
            {
                Label labelProducto = new Label();
                labelProducto.Text = "Material:";
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
                Label labelUnidad = new Label();
                labelUnidad.AutoSize = true;
                labelUnidad.ForeColor = Color.Black;

                comboBoxMaterial.SelectedIndexChanged += (s, args) =>
                {
                    if (comboBoxMaterial.SelectedIndex >= 0)
                    {
                        string unidad = unidades[comboBoxMaterial.SelectedIndex];
                        labelUnidad.Text = unidad;
                    }
                    else
                    {
                        labelUnidad.Text = string.Empty;
                    }
                };

                flowLayoutPanelBox.Controls.Add(labelProducto);
                flowLayoutPanelBox.Controls.Add(comboBoxMaterial);
                flowLayoutPanelBox.Controls.Add(labelCantidad);
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
                    labelProducto.Text = "Material:";
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

                    Label labelUnidad = new Label();
                    labelUnidad.AutoSize = true;
                    labelUnidad.ForeColor = Color.Black;

                    comboBoxMaterial.SelectedIndexChanged += (s, args) =>
                    {
                        if (comboBoxMaterial.SelectedIndex >= 0)
                        {
                            string opcion = unidades[comboBoxMaterial.SelectedIndex];
                            string unidad;
                            if (opcion == string.Empty)
                            {
                                unidad = "El material no tiene una unidad definida";
                            }
                            else
                            {
                                unidad = "La unidad del material es: " + opcion;
                            }
                            labelUnidad.Text = unidad;
                        }
                        else
                        {
                            labelUnidad.Text = string.Empty;
                        }
                    };
                    flowLayoutPanelBox.Controls.Add(labelProducto);
                    flowLayoutPanelBox.Controls.Add(comboBoxMaterial);
                    flowLayoutPanelBox.Controls.Add(labelUnidad);
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
            tabControlProduccion.TabPages.Remove(tabBodega);
            tabControlProduccion.TabPages.Add(viewButtons);
            resertcampos(sender, e);
        }

        private void boxProductsCreate_TextChanged(object sender, EventArgs e)
        {
            int cantidadProductos = 0;

            if (int.TryParse(boxProductsCreate.Text, out cantidadProductos))
            {
                layoutPanelProducts.Controls.Clear();

                for (int i = 0; i < cantidadProductos; i++)
                {
                    Label labelProducto = new Label();
                    labelProducto.Text = "Producto:";
                    labelProducto.AutoSize = true;
                    labelProducto.ForeColor = Color.Black;

                    ComboBox comboBoxProductos = new ComboBox();
                    comboBoxProductos.DisplayMember = "nombre";
                    comboBoxProductos.DataSource = opcionesProductos[i];
                    comboBoxProductos.DropDownStyle = ComboBoxStyle.DropDownList;

                    ComboBox comboBoxFrascos = new ComboBox();
                    comboBoxFrascos.DisplayMember = "nombre";
                    comboBoxFrascos.DataSource = opcionesFrascos[i];
                    comboBoxFrascos.DropDownStyle = ComboBoxStyle.DropDownList;

                    Label labelCantidad = new Label();
                    labelCantidad.Text = "Ingrese la cantidad:";
                    labelCantidad.AutoSize = true;
                    labelCantidad.ForeColor = Color.Black;

                    TextBox textBoxCantidad = new TextBox();
                    TextBox textBoxCantidadFr = new TextBox();
                    comboBoxesProductos.Add(comboBoxProductos);
                    textBoxesCantidadProductos.Add(textBoxCantidad);
                    textBoxesCantidadFrascos.Add(textBoxCantidadFr);

                    Label labelFrasco = new Label();
                    labelFrasco.Text = "Tamaño del frasco:";
                    labelFrasco.AutoSize = true;
                    labelFrasco.ForeColor = Color.Black;

                    layoutPanelProducts.Controls.Add(labelProducto);
                    layoutPanelProducts.Controls.Add(comboBoxProductos);
                    layoutPanelProducts.Controls.Add(labelFrasco);
                    layoutPanelProducts.Controls.Add(comboBoxFrascos);
                    layoutPanelProducts.Controls.Add(labelCantidad);
                    layoutPanelProducts.Controls.Add(textBoxCantidad);
                }
            }
            else
            {
                layoutPanelProducts.Controls.Clear();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tabControlProduccion.SelectedTab = tabBodega;
            tabControlProduccion.TabPages.Remove(tabHistory);
            tabControlProduccion.TabPages.Remove(tabIngresarProduccion);
            tabControlProduccion.TabPages.Remove(tabProduccionActual);
            tabControlProduccion.TabPages.Remove(viewButtons);
            tabControlProduccion.TabPages.Add(tabBodega);
            resertcampos(sender, e);
        }
    }
}

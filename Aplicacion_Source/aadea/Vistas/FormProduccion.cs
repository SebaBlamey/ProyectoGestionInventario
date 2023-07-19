using aadea.Extras;
using aadea.Logicaq;
using aadea.Model;
using aadea.userControls;
using Microsoft.VisualBasic.ApplicationServices;
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
        private List<string> frascos;
        private List<ComboBox> comboBoxesFrascos;
        private List<TextBox> textBoxesCantidadFrascos;
        private int idLocal;
        private List<string> unidades;
        private produccionActual userLocal;
        private int cantProductLocal;

        private int cantMaterialesTot;


        public FormProduccion()
        {
            InitializeComponent();
            tabControlProduccion.ItemSize = new Size(0, 1);
            tabControlProduccion.SizeMode = TabSizeMode.Fixed;
            tabControlProduccion.Multiline = true;
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

            frascos = l_list_mats.ObtenerFrascos();
            opcionesFrascos = new List<List<string>>();

            cantMaterialesTot = l_list_mats.cantMaterial();

            for (int i = 0; i < cantMaterialesTot; i++)
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
                List<string> opcionesFrasc = new List<string>(frascos);
                opcionesFrascos.Add(opcionesFrasc);
            }

            unidades = l_list_mats.unidadesMateriales();

        }
        private void resertcampos(object sender, EventArgs e)
        {
            //Principal.menuTitleLaberl.Text = "PRODUCCION";
            textBoxCantidad.Text = string.Empty;
        }




        //---------------------------------
        // HISTORIAL DE PRODUCCION
        //---------------------------------
        //Boton ver historial de producción.
        private void bt1_Click(object sender, EventArgs e)
        {
            Principal.menuTitleLaberl.Text = "HISTORIAL PRODUCCION";
            tabControlProduccion.SelectedTab = tabHistory;
            tabControlProduccion.TabPages.Remove(viewButtons);
            tabControlProduccion.TabPages.Remove(tabIngresarProduccion);
            tabControlProduccion.TabPages.Remove(tabProduccionActual);
            tabControlProduccion.TabPages.Remove(tabBodega);
            tabControlProduccion.TabPages.Add(tabHistory);
            FormLoadHistory(sender, e);
        }

        private void FormLoadHistory(object sender, EventArgs e)
        {
            LayoutHistorial.Controls.Clear();
            L_Produccion l_produccion = new L_Produccion();
            DataTable dataTable = l_produccion.ListHistorial();
            foreach (DataRow row in dataTable.Rows)
            {
                historyControl userControl = new historyControl();

                int id = Convert.ToInt32(row["ID"]);
                string fecha_inicio = row["fecha_inicio"].ToString();
                string fecha_termino = row["fecha_termino"].ToString();
                string nombre = row["nombre"].ToString();
                userControl.fechaInicio = fecha_inicio;
                userControl.fechaTermino = fecha_termino;
                userControl.Tittle += " " + nombre;
                LayoutHistorial.Controls.Add(userControl);
                DataTable tableMaterial = l_produccion.listMaterialForHistory(id);
                DataTable tableProduct = l_produccion.GetProductHistory(id);


                userControl.DataGridViewMateriales.Rows.Clear();
                userControl.DataGridViewMateriales.Columns.Add("Nombre", "Nombre");
                userControl.DataGridViewMateriales.Columns.Add("Cantidad", "Cantidad");
                foreach (DataRow rows in tableMaterial.Rows)
                {
                    int idMaterial = Convert.ToInt32(rows["id_material"]);
                    int cantidad = Convert.ToInt32(rows["cantidad"]);
                    string nombreMaterial = l_produccion.getNameMaterial(idMaterial);
                    if (nombreMaterial == null) { nombreMaterial = "El material ha sido eliminado"; }
                    userControl.DataGridViewMateriales.Rows.Add(nombreMaterial, cantidad);
                }

                userControl.DataGridViewProductos.Rows.Clear();
                userControl.DataGridViewProductos.Columns.Add("Nombre", "Nombre");
                userControl.DataGridViewProductos.Columns.Add("Cantidad", "Cantidad");
                userControl.DataGridViewProductos.Columns.Add("Frasco", "Frasco");
                foreach (DataRow rows in tableProduct.Rows)
                {
                    int idProducto = Convert.ToInt32(rows["id_producto"]);
                    int cantidad = Convert.ToInt32(rows["cantidad"]);
                    int idfrasco = Convert.ToInt32(rows["id_frasco"]);
                    string nombreProducto = l_produccion.getNameProducto(idProducto);
                    string frasco = l_produccion.ObtenerFrascoN(idfrasco);
                    if (nombreProducto == null) { nombreProducto = "El material ha sido eliminado"; }
                    userControl.DataGridViewProductos.Rows.Add(nombreProducto, cantidad, frasco);
                }
            }
        }

        //salir de histotial de produccion.
        private void bttExitHistory_Click(object sender, EventArgs e)
        {
        }



        //------------------------------------------------------
        //PRODUCCION ACTUAL
        //------------------------------------------------------
        //boton ver produccion actual
        private void btViewProduccion_Click(object sender, EventArgs e)
        {
            Principal.menuTitleLaberl.Text = "PRODUCCION ACTUAL";
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
                    if (nombreMaterial == null) { nombreMaterial = "El material ha sido eliminado"; }
                    user.DataGridViewMateriales.Rows.Add(nombreMaterial, cantidad);
                }
            }
        }

        //boton terminar produccion
        private void User_ButtonEnd(object sender, EventArgs e)
        {
            userLocal = (produccionActual)sender;
            tabControlProduccion.SelectedTab = tabBodega;
            tabControlProduccion.TabPages.Remove(tabHistory);
            tabControlProduccion.TabPages.Remove(tabIngresarProduccion);
            tabControlProduccion.TabPages.Remove(tabProduccionActual);
            tabControlProduccion.TabPages.Remove(viewButtons);
            tabControlProduccion.TabPages.Add(tabBodega);
            resertcampos(sender, e);
            this.ParentForm.MostrarNotificacion("Produccion terminada", Color.Green, 1);

        }
        private void aceptInsertProduct_Click(object sender, EventArgs e)
        {

        }




        private void User_DeleteButtonClicked(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta producción?",
               "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                produccionActual user = (produccionActual)sender;
                int id = user.ID;
                L_Produccion l = new L_Produccion();
                l.EliminarProduccion(id);
                layoutPanelActualProduccion.Controls.Remove(user);
                this.ParentForm.MostrarNotificacion("Produccion eliminada", Color.Red, 3);
            }
            resertcampos(sender, e);

        }

        private void btExitProduccionActual_Click(object sender, EventArgs e)
        {
        }

        //boton calcelar ingresar productos
        private void CancelInsertProduct_Click(object sender, EventArgs e)
        {
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
            Principal.menuTitleLaberl.Text = "INGRESAR PRODUCCION";
        }

        //cancelar producción
        private void btCancelAddproduccion_Click(object sender, EventArgs e)
        {
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
                if (cantidadMateriales > cantMaterialesTot)
                {
                    MessageBox.Show("No puedes ingresar un número mayor a los materiales que tienes\nla cantidad de materiales que tienes son: ." + cantMaterialesTot, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxCantidad.Clear(); ; // Restaurar el valor máximo permitido
                    return;
                }

                flowLayoutPanelBox.Controls.Clear();

                for (int i = 0; i < cantidadMateriales; i++)
                {
                    Label labelProducto = new Label();
                    //labelProducto.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
                    labelProducto.Text = "Material:";
                    labelProducto.AutoSize = true;
                    labelProducto.ForeColor = Color.Black;

                    ComboBox comboBoxMaterial = new ComboBox();
                    comboBoxMaterial.DisplayMember = "nombre";
                    comboBoxMaterial.DataSource = opcionesMateriales[i];
                    comboBoxMaterial.DropDownStyle = ComboBoxStyle.DropDownList;

                    Label labelCantidad = new Label();
                    //labelCantidad.Font = Font = new Font("Century Gothic", 8f, FontStyle.Regular, GraphicsUnit.Point);
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
                    textBoxCantidad.KeyPress += (s, args) =>
                    {
                        if (!char.IsDigit(args.KeyChar) && args.KeyChar != ',' && args.KeyChar != '\b')
                        {
                            args.Handled = true;
                        }

                        if (args.KeyChar == ',')
                        {
                            if (textBoxCantidad.Text.Contains(','))
                            {
                                args.Handled = true;
                            }
                            else
                            {
                                // Reemplazar la coma por el punto en el TextBox
                                textBoxCantidad.Text += ".";
                                textBoxCantidad.SelectionStart = textBoxCantidad.Text.Length;
                                args.Handled = true;
                            }
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

                    Label labelFrasco = new Label();
                    labelFrasco.Text = "Tamaño del frasco:";
                    labelFrasco.AutoSize = true;
                    labelFrasco.ForeColor = Color.Black;

                    ComboBox comboBoxFrascos = new ComboBox();
                    comboBoxFrascos.DisplayMember = "nombre";
                    comboBoxFrascos.DataSource = opcionesFrascos[i];
                    comboBoxFrascos.DropDownStyle = ComboBoxStyle.DropDownList;


                    Label labelCantidad = new Label();
                    labelCantidad.Text = "Ingrese la cantidad:";
                    labelCantidad.AutoSize = true;
                    labelCantidad.ForeColor = Color.Black;

                    TextBox textBoxCantidad = new TextBox();

                    comboBoxesProductos.Add(comboBoxProductos);
                    comboBoxesFrascos.Add(comboBoxFrascos);
                    textBoxesCantidadProductos.Add(textBoxCantidad);

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
            cantProductLocal = cantidadProductos;
        }

        private void LayoutHistorial_Paint(object sender, PaintEventArgs e)
        {

        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            Principal.menuTitleLaberl.Text = "PRODUCCION";
            tabControlProduccion.SelectedTab = viewButtons;
            tabControlProduccion.TabPages.Remove(tabHistory);
            tabControlProduccion.TabPages.Remove(tabIngresarProduccion);
            tabControlProduccion.TabPages.Remove(tabProduccionActual);
            tabControlProduccion.TabPages.Remove(tabBodega);
            tabControlProduccion.TabPages.Add(viewButtons);
        }

        private void volerProdActual_Click(object sender, EventArgs e)
        {
            Principal.menuTitleLaberl.Text = "PRODUCCION";
            tabControlProduccion.SelectedTab = viewButtons;
            tabControlProduccion.TabPages.Remove(tabHistory);
            tabControlProduccion.TabPages.Remove(tabIngresarProduccion);
            tabControlProduccion.TabPages.Remove(tabProduccionActual);
            tabControlProduccion.TabPages.Remove(tabBodega);
            tabControlProduccion.TabPages.Add(viewButtons);
        }

        private void aceptarIngresar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int idProduccion = random.Next();

            string nombreProduccion = txtName.Text;
            string fechaInicio = dateAddProduccion.Value.ToString("dd-MM-yyyy");

            L_Produccion l_list = new L_Produccion();
            l_list.InsertarProduccion(idProduccion, nombreProduccion, fechaInicio);

            bool suficienteMaterial = true; // Variable para verificar si hay suficiente material disponible

            Dictionary<int, float> materialesCantidad = new Dictionary<int, float>(); // Diccionario para almacenar el ID del material y la cantidad utilizada

            for (int i = 0; i < comboBoxesMateriales.Count; i++)
            {
                ComboBox comboBoxMaterial = comboBoxesMateriales[i];
                TextBox textBoxCantidad = textBoxesCantidad[i];

                string nombreMaterial = comboBoxMaterial.SelectedItem.ToString();
                int idMaterial = l_list.obtenerIdMaterial(nombreMaterial);

                float cantidad;
                string cantidadTexto = textBoxCantidad.Text;
                if (float.TryParse(cantidadTexto, out cantidad))
                {
                    // Comprobar si hay suficiente material disponible
                    float stockDisponible = l_list.obtenerStockMaterial(idMaterial);
                    if (cantidad > stockDisponible)
                    {
                        suficienteMaterial = false;
                        break; // Salir del bucle si no hay suficiente material
                    }

                    materialesCantidad[idMaterial] = cantidad;
                }
                else
                {
                    MessageBox.Show("Error");
                    suficienteMaterial = false;
                    break; // Salir del bucle si hay un error en la cantidad
                }
            }

            if (suficienteMaterial)
            {
                // Realizar la inserción de la producción y los materiales
                foreach (var kvp in materialesCantidad)
                {
                    int idMaterial = kvp.Key;
                    float cantidad = kvp.Value;

                    l_list.InsertarMaterialProduccion(idProduccion, idMaterial, cantidad);

                    // Descontar la cantidad utilizada del material en la base de datos
                    l_list.DescontarStockMaterial(idMaterial, cantidad);
                }

                tabControlProduccion.SelectedTab = viewButtons;
                tabControlProduccion.TabPages.Remove(tabHistory);
                tabControlProduccion.TabPages.Remove(tabIngresarProduccion);
                tabControlProduccion.TabPages.Remove(tabProduccionActual);
                tabControlProduccion.TabPages.Remove(tabBodega);
                tabControlProduccion.TabPages.Add(viewButtons);
                resertcampos(sender, e);
            }
            else
            {
                // Eliminar la producción incompleta
                l_list.EliminarProduccion(idProduccion);

                MessageBox.Show("No hay suficiente material disponible para realizar la producción.", "Material insuficiente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.ParentForm.MostrarNotificacion("Produccion ingresada", Color.Green, 1);
        }

        private void cancelarIngresar_Click(object sender, EventArgs e)
        {
            Principal.menuTitleLaberl.Text = "PRODUCCION";
            tabControlProduccion.SelectedTab = viewButtons;
            tabControlProduccion.TabPages.Remove(tabHistory);
            tabControlProduccion.TabPages.Remove(tabIngresarProduccion);
            tabControlProduccion.TabPages.Remove(tabProduccionActual);
            tabControlProduccion.TabPages.Remove(tabBodega);
            tabControlProduccion.TabPages.Add(viewButtons);
            resertcampos(sender, e);
            this.ParentForm.MostrarNotificacion("Produccion no ingresada", Color.Red, 3);
        }

        private void aceptarIngresarBodega_Click(object sender, EventArgs e)
        {
            int idProduccion = userLocal.ID;
            L_Produccion l = new L_Produccion();
            string termino = userLocal.fechaterm;
            string inicio = userLocal.fechaInicio;
            string nombre = userLocal.Tittle;

            for (int i = 0; i < comboBoxesProductos.Count; i++)
            {
                ComboBox comboBoxProducto = comboBoxesProductos[i];
                ComboBox comboBoxFrasco = comboBoxesFrascos[i];
                TextBox textBoxCantidadProducto = textBoxesCantidadProductos[i];

                string nombreProducto = comboBoxProducto.SelectedItem.ToString();
                int idProducto = l.obtenerIdProducto(nombreProducto);

                string nombreFrasco = comboBoxFrasco.SelectedItem.ToString();
                int idFrasco = l.obtenerIdFrasco(nombreFrasco);

                int cantidad;
                string cantidadTexto = textBoxCantidadProducto.Text;

                if (Int32.TryParse(cantidadTexto, out cantidad))
                {

                }
                else
                {
                    MessageBox.Show("Error");
                }

                l.insertProductoHistorial(idProduccion, idProducto, idFrasco, cantidad);
                l.insertStock(idProducto, idFrasco, cantidad);
            }


            l.TerminarProduccion(idProduccion, termino, inicio, nombre);

            layoutPanelActualProduccion.Controls.Remove(userLocal);

            tabControlProduccion.SelectedTab = viewButtons;
            tabControlProduccion.TabPages.Remove(tabHistory);
            tabControlProduccion.TabPages.Remove(tabIngresarProduccion);
            tabControlProduccion.TabPages.Remove(tabProduccionActual);
            tabControlProduccion.TabPages.Remove(tabBodega);
            tabControlProduccion.TabPages.Add(viewButtons);
            resertcampos(sender, e);
            this.ParentForm.MostrarNotificacion("Productos ingresados a bodega", Color.Green, 1);
        }

        private void cancelarIngresarBodega_Click(object sender, EventArgs e)
        {
            Principal.menuTitleLaberl.Text = "PRODUCCION";
            tabControlProduccion.SelectedTab = viewButtons;
            tabControlProduccion.TabPages.Remove(tabHistory);
            tabControlProduccion.TabPages.Remove(tabIngresarProduccion);
            tabControlProduccion.TabPages.Remove(tabProduccionActual);
            tabControlProduccion.TabPages.Remove(tabBodega);
            tabControlProduccion.TabPages.Add(viewButtons);
            this.ParentForm.MostrarNotificacion("Productos no ingresados a la bodega", Color.Red, 3);
        }
    }
}

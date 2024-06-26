﻿using aadea.Extras;
using aadea.Logicaq;
using aadea.Model;
using aadea.userControls;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            txtName.Text = string.Empty;
            boxProductsCreate.Text = string.Empty;
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
                userControl.DataGridViewMateriales.Columns.Add("Material", "Material");
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
                userControl.DataGridViewProductos.Columns.Add("Producto", "Producto");
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
                this.ParentForm.MostrarNotificacion("Produccion eliminada", 3);
            }
            resertcampos(sender, e);

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
        //campo de cantidad de materiales
        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            int cantidadMateriales = 0;
            L_Produccion l = new L_Produccion();
            if (int.TryParse(textBoxCantidad.Text, out cantidadMateriales))
            {
                if (cantidadMateriales > cantMaterialesTot)
                {
                    MessageBox.Show("No puedes ingresar un número mayor a los materiales que tienes\nla cantidad de materiales que tienes son: " + cantMaterialesTot, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            string name = comboBoxMaterial.Text;
                            string opcion2 = l.obtenerUnidad(name);

                            if (opcion == string.Empty)
                            {
                                unidad = "El material no tiene una unidad definida";
                            }
                            else
                            {
                                unidad = "La unidad del material es: " + opcion2;
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



            bool suficienteMaterial = true;

            Dictionary<int, float> materialesCantidad = new Dictionary<int, float>(); // Diccionario para almacenar el ID del material y la cantidad utilizada
            if (textBoxCantidad.Text != string.Empty && txtName.Text != string.Empty)
            {
                L_Produccion l_list = new L_Produccion();
                l_list.InsertarProduccion(idProduccion, nombreProduccion, fechaInicio);
                for (int i = 0; i < comboBoxesMateriales.Count; i++)
                {
                    ComboBox comboBoxMaterial = comboBoxesMateriales[i];
                    TextBox textBoxCantidad = textBoxesCantidad[i];

                    string nombreMaterial = comboBoxMaterial.SelectedItem.ToString();
                    int idMaterial = l_list.obtenerIdMaterial(nombreMaterial);

                    float cantidad;
                    string cantidadTexto = textBoxCantidad.Text;

                    if (float.TryParse(cantidadTexto, NumberStyles.Float, CultureInfo.InvariantCulture, out cantidad))
                    {
                        float stockDisponible = l_list.obtenerStockMaterial(idMaterial);
                        if (cantidad > stockDisponible)
                        {
                            suficienteMaterial = false;
                            break;
                        }

                        materialesCantidad[idMaterial] = cantidad;
                    }
                    else
                    {
                        MessageBox.Show("Error");
                        suficienteMaterial = false;
                        break;
                    }
                }

                if (suficienteMaterial)
                {
                    foreach (var kvp in materialesCantidad)
                    {
                        int idMaterial = kvp.Key;
                        float cantidad = kvp.Value;

                        l_list.InsertarMaterialProduccion(idProduccion, idMaterial, cantidad);

                        l_list.DescontarStockMaterial(idMaterial, cantidad);
                    }
                    this.ParentForm.MostrarNotificacion("Produccion ingresada", 1);
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
                    l_list.EliminarProduccion(idProduccion);

                    //MessageBox.Show("No hay suficiente material disponible para realizar la producción.", "Material insuficiente",
                    //MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.ParentForm.MostrarNotificacion("No hay suficiente material disponible para realizar la produccion", 3);
                    return;
                }
            }
            else
            {
                this.ParentForm.MostrarNotificacion("Debe rellenar todos los campos", 3);
                return;
            }


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
            //this.ParentForm.MostrarNotificacion("Produccion no ingresada", 3);
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
            this.ParentForm.MostrarNotificacion("Productos ingresados a bodega", 1);
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
            this.ParentForm.MostrarNotificacion("Productos no ingresados a la bodega", 3);
        }

        private void HelpBTHistory_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            string ayudaTexto = @"Ayuda: Pestaña de Producción

            En esta pestaña, encontrarás tres botones relacionados con la producción. A continuación se explica cómo utilizarlos:

            1. Botón 'Ingresar Producción': Al hacer clic en este botón, se abrirá el apartado de ingreso de una nueva producción. Aquí podrás utilizar los materiales existentes para crear nuevos productos. Sigue las instrucciones proporcionadas en esa sección para ingresar los detalles de la producción.

            2. Botón 'Ver Producción Actual': Al hacer clic en este botón, podrás ver las producciones que están en desarrollo y aún no se han terminado. Esta sección te proporcionará información sobre el estado actual de las producciones en curso.

            3. Botón 'Ver Todas las Producciones': Al hacer clic en este botón, podrás ver todas las producciones que se han realizado. Esta sección te mostrará un historial completo de las producciones anteriores.

            Utiliza estos botones según tus necesidades para acceder a las diferentes funcionalidades relacionadas con la producción. Asegúrate de seguir las instrucciones correspondientes en cada sección para realizar las acciones deseadas correctamente.
            ";




            help.TextoAyuda = ayudaTexto;
            help.StartPosition = FormStartPosition.CenterScreen;
            help.ShowDialog();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            string ayudaTexto = @"Ayuda: Pestaña de Ingresar Producción

            En esta pestaña, puedes ingresar una nueva producción y utilizar los materiales existentes para crear nuevos productos. A continuación se explica cómo utilizarla:

            1. Cantidad de Materiales: En este apartado, ingresa el número de materiales que se utilizarán en la producción. Por ejemplo, si seleccionas el número 2, aparecerán 2 apartados adicionales a continuación para que puedas seleccionar los materiales específicos y su stock.

            2. Selección de Materiales: En el apartado inferior, encontrarás una lista de materiales disponibles junto con su stock. Si ingresaste 2 en la cantidad de materiales, aparecerán 2 apartados, cada uno con una lista desplegable para que puedas seleccionar los materiales que deseas utilizar en la producción y ver su stock actual.

            3. Nombre de la Producción: En la parte superior derecha, puedes ingresar un nombre para identificar la producción. Este nombre es solo un identificador y no afectará la funcionalidad de la producción. Podrás ver el producto resultante en el catálogo con el nombre que ingreses aquí.

            4. Calendario: Utiliza el calendario para asignar una fecha específica para el inicio de la producción. Si no seleccionas una fecha, se tomará el día actual como la fecha de inicio.

            5. Botones 'Aceptar' y 'Cancelar': Al final de la pestaña, encontrarás dos botones. Utiliza el botón 'Aceptar' para guardar los detalles de la producción y registrarla. Si deseas cancelar y no ingresar la producción, utiliza el botón 'Cancelar'.

            Recuerda ingresar los datos correctamente y seleccionar los materiales adecuados para la producción. Una vez que hayas ingresado la producción, esta se transformará en un producto en el catálogo con el nombre que hayas proporcionado.
            ";




            help.TextoAyuda = ayudaTexto;
            help.StartPosition = FormStartPosition.CenterScreen;
            help.ShowDialog();

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            string ayudaTexto = @"Ayuda: Sección de Producción Actual

            En esta sección, puedes observar todas las producciones en curso. Cada producción se muestra en forma de tabla con la información del material utilizado, cantidad, fecha de inicio y fecha de término.

            - Nombre del Material: Nombre del material utilizado en la producción.
            - Cantidad: Cantidad del material utilizada en la producción.
            - Fecha de Inicio: Fecha de inicio de la producción.
            - Fecha de Término: Fecha prevista para finalizar la producción. Puedes modificarla si es necesario.
            - Botón 'Eliminar': Utiliza este botón para eliminar la producción completa.

            Utiliza la tabla para tener una vista general de todas las producciones en curso. Si necesitas eliminar una producción, haz clic en el botón 'Eliminar'.

            Asegúrate de verificar las fechas de inicio y término para una gestión eficiente de la producción.
            ";




            help.TextoAyuda = ayudaTexto;
            help.StartPosition = FormStartPosition.CenterScreen;
            help.ShowDialog();
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            string ayudaTexto = @"Ayuda: Pestaña de Contabilizar Producción

            En esta pestaña, podrás contabilizar la cantidad de productos creados por la producción y agregarlos al stock de la bodega. A continuación se explica cómo utilizarla:

            1. Espacio para Escribir la Cantidad de Productos Creados: En esta sección, encontrarás espacios para ingresar la cantidad de productos creados por la producción. Puedes ingresar la cantidad correspondiente para cada variedad de producto producido.

            2. Tamaño del Frasco: Junto a cada espacio de cantidad, podrás indicar el tamaño del frasco para el producto correspondiente.

            3. Cantidad: Además del tamaño del frasco, también podrás ingresar la cantidad de productos creados para cada variedad.

            4. Botón 'Aceptar': Una vez que hayas ingresado la cantidad de productos creados y su respectivo tamaño de frasco, presiona este botón para agregar la cantidad producida al stock de la bodega.

            Verifica cuidadosamente la información ingresada antes de presionar 'Aceptar', ya que esta acción actualizará el stock de la bodega con los nuevos productos producidos. Puedes utilizar esta pestaña para contabilizar los productos generados por la producción y mantener un registro actualizado del stock de la bodega.

            Recuerda ingresar la información correctamente para una gestión eficiente del stock de productos en la bodega.
            ";





            help.TextoAyuda = ayudaTexto;
            help.StartPosition = FormStartPosition.CenterScreen;
            help.ShowDialog();
        }
    }
}

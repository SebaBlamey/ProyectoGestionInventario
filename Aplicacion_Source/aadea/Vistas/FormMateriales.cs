using aadea.Logicaq;
using aadea.userControls;
using System.Data;
using aadea.Properties;
using Image = System.Drawing.Image;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;
using System.Globalization;
using System.Windows.Forms;
using aadea.Extras;
using System.Data.SQLite;

namespace aadea.Vistas
{
    public partial class FormMateriales : Form
    {
        private string rutaSeleccionadaAdd;
        private string rutaSeleccionadaMod;
        private int idLocal;

        public FormMateriales()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(AddMaterial);
            tabControl1.TabPages.Remove(EditMaterial);

            opcionBox.Items.Add("KG");
            opcionBox.Items.Add("L");
            opcionBox.Items.Add("Unidad");
            boxMedidaActual.Items.Add("KG");
            boxMedidaActual.Items.Add("L");
            boxMedidaActual.Items.Add("Unidad");

        }

        private void resetCampos(object sender, EventArgs e)
        {
            Principal.menuTitleLaberl.Text = "MATERIALES";
            idLocal = -1;
            ogMaterialName = "";
            txtNameInsert.Text = string.Empty;
            txtStock.Text = string.Empty;
            opcionBox.Text = string.Empty;
            rutaSeleccionadaAdd = null;
            FormMaterials_Load(this, EventArgs.Empty);
        }

        private void FormMaterials_Load(object sender, EventArgs e)
        {
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.Multiline = true;
            flowLayoutPanel1.Controls.Clear();
            L_Materials l_materials = new L_Materials();
            DataTable dataTable = l_materials.listMaterials();
            foreach (DataRow row in dataTable.Rows)
            {
                UserMaterial userControl = new UserMaterial();

                int id = Convert.ToInt32(row["ID"]);
                string name = row["nombre"].ToString();
                float stock = Convert.ToSingle(row["stock"]);
                stock = (float)Math.Round(stock, 2, MidpointRounding.AwayFromZero);
                string unidad = row["unidad"].ToString();

                byte[] imagen = l_materials.ObtenerImagenMaterial(id);
                userControl.nombretit = name;
                userControl.Cantidad = $"{stock.ToString("0.0")}";
                userControl.Unidad = unidad;
                userControl.ID = Convert.ToInt32(row["ID"]);

                // Suscribirte al evento DeleteButtonClicked y pasar el UserControl
                userControl.buttonDeleteClick += (s, args) =>
                {
                    UserControl_DeleteButtonClicked(sender, e, userControl);
                    idLocal = userControl.ID;
                };

                userControl.buttonModifyClick += (s, args) =>
                {
                    UserControl_ButtonModify(userControl);
                    idLocal = userControl.ID;
                };

                if (imagen != null && imagen.Length > 0)
                {
                    using var ms = new MemoryStream(imagen);
                    var img = Image.FromStream(ms);
                    userControl.MaterialImage = img;
                }
                else
                {
                    userControl.MaterialImage = Resource.defaultImage;
                }

                flowLayoutPanel1.Controls.Add(userControl);
                if (!string.IsNullOrEmpty(unidad) && !boxMedidaActual.Items.Contains(unidad))
                {
                    boxMedidaActual.Items.Add(unidad);
                }
            }
        }

        private string ogMaterialName = "";

        private void UserControl_ButtonModify(UserMaterial user)
        {
            try
            {
                Principal.menuTitleLaberl.Text = "MODIFICAR MATERIAL";
                string nombre = user.nombretit;
                ogMaterialName = user.nombretit;
                string cantidad = user.Cantidad;
                string unidad = user.Unidad;
                int id = user.ID;
                idLocal = user.ID;
                Image imagen = user.MaterialImage;

                tabControl1.SelectedTab = EditMaterial;
                tabControl1.TabPages.Add(EditMaterial);
                tabControl1.TabPages.Remove(AddMaterial);
                tabControl1.TabPages.Remove(ListaMateriales);

                txtNameActual.Text = nombre;
                txtStockActual.Text = cantidad;

                boxMedidaActual.SelectedItem = unidad;

                picImagenModify.Image = imagen;
                idLocal = id;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserControl_DeleteButtonClicked(object sender, EventArgs e, UserMaterial user)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este material?",
                "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(user.ID);
                L_Materials l_materials = new L_Materials();
                flowLayoutPanel1.Controls.Remove(user);
                l_materials.DeleteMaterial(id);
                this.ParentForm.MostrarNotificacion("Material eliminado", 1);
            }

            resetCampos(sender, e);

        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',')
            {
                if (((TextBox)sender).Text.Contains(','))
                {
                    e.Handled = true;
                }
                else
                {
                    // Reemplazar la coma por el punto en el TextBox
                    ((TextBox)sender).Text += ".";
                    ((TextBox)sender).SelectionStart = ((TextBox)sender).Text.Length;
                    e.Handled = true;
                }
            }
        }

        private void add_iconButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = AddMaterial;
            tabControl1.TabPages.Add(AddMaterial);
            tabControl1.TabPages.Remove(ListaMateriales);
            tabControl1.TabPages.Remove(EditMaterial);
            resetCampos(sender, e);
            Principal.menuTitleLaberl.Text = "AGREGAR MATERIAL";
        }

        private void txtStockActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',')
            {
                if (((TextBox)sender).Text.Contains(','))
                {
                    e.Handled = true;
                }
                else
                {
                    // Reemplazar la coma por el punto en el TextBox
                    ((TextBox)sender).Text += ".";
                    ((TextBox)sender).SelectionStart = ((TextBox)sender).Text.Length;
                    e.Handled = true;
                }
            }
        }

        private void iconBtnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Seleccionar imagen";
            selectorImagen.Filter = "Archivos de imagen|*.png;*.jpeg;*.jpg";

            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                rutaSeleccionadaAdd = selectorImagen.FileName;
                Image imagen = Image.FromFile(rutaSeleccionadaAdd);
                picAdd.Image = imagen;
            }
        }

        private void cancelAdd_btn_Click(object sender, EventArgs e)
        {
            resetCampos(sender, e);
            tabControl1.SelectedTab = ListaMateriales;
            tabControl1.TabPages.Add(ListaMateriales);
            tabControl1.TabPages.Remove(AddMaterial);
            tabControl1.TabPages.Remove(EditMaterial);
        }

        private bool MaterialExiste(string nombre)
        {
            try
            {
                using (SQLiteConnection connection = Conexion.GetConexion().CrearConexion())
                {
                    string query = "SELECT Nombre FROM Material WHERE Nombre = @nombre";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@nombre", nombre);
                        connection.Open();
                        using (SQLiteDataReader resultado = command.ExecuteReader())
                        {
                            // Si el resultado tiene filas, significa que se encontró un producto con el mismo nombre
                            return resultado.HasRows;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                // Manejo de excepciones: muestra un mensaje y registra el error para depuración
                Console.WriteLine("Error al conectar a la base de datos: " + e.Message);
                return false;
            }
        }


        private void save_iconBtn_Click(object sender, EventArgs e)
        {
            string nombre = txtNameInsert.Text;
            string stocktext = txtStock.Text;
            string unidad = opcionBox.Text;
            float valor;
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(stocktext) || string.IsNullOrEmpty(unidad))
            {
                this.ParentForm.MostrarNotificacion("Por favor, complete todos los campos", 3);
                return;
            }

            if (MaterialExiste(nombre))
            {
                this.ParentForm.MostrarNotificacion($"Ya existe el material '{nombre}'", 3);
                return;
            }

            L_Materials mat = new L_Materials();
            stocktext = stocktext.Replace(',', '.');
            if (float.TryParse(stocktext, NumberStyles.Float, CultureInfo.InvariantCulture, out valor))
            {
                string mensaje = valor.ToString("F2", CultureInfo.InvariantCulture);
            }
            else
            {
                this.ParentForm.MostrarNotificacion("Utilice '.' cuando quiera usar decimal", 3);
                return;
            }

            if (!string.IsNullOrEmpty(rutaSeleccionadaAdd))
            {
                byte[] bytesImage = File.ReadAllBytes(rutaSeleccionadaAdd);

                mat.InsertMaterialWI(nombre, valor, bytesImage, unidad);
            }
            else
            {
                mat.InsertMaterial(nombre, valor, unidad);
            }

            tabControl1.SelectedTab = ListaMateriales;
            tabControl1.TabPages.Remove(AddMaterial);
            tabControl1.TabPages.Remove(EditMaterial);
            tabControl1.TabPages.Add(ListaMateriales);
            resetCampos(sender, e);
            this.ParentForm.MostrarNotificacion("Material agregado", 1);
        }

        private void searchBtnMod_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Seleccionar imagen";
            selectorImagen.Filter = "Archivos de imagen|*.png;*.jpeg;*.jpg";

            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(selectorImagen.FileName).ToLower();
                if (extension == ".png" || extension == ".jpeg" || extension == ".jpg")
                {
                    picImagenModify.Image = Image.FromFile(selectorImagen.FileName);
                    rutaSeleccionadaMod = selectorImagen.FileName;
                }
                else
                {
                    this.ParentForm.MostrarNotificacion("Por favor, selecciona una imagen en formato PNG o JPEG", 3);
                }
            }
        }

        private void deleteBtnEdit_Click(object sender, EventArgs e)
        {
            resetCampos(sender, e);

            tabControl1.SelectedTab = ListaMateriales;
            tabControl1.TabPages.Add(ListaMateriales);
            tabControl1.TabPages.Remove(AddMaterial);
            tabControl1.TabPages.Remove(EditMaterial);
        }

        private void saveBtnEdit_Click(object sender, EventArgs e)
        {
            string nombre = txtNameActual.Text;
            string stocktext = txtStockActual.Text;
            string unidad = boxMedidaActual.Text;
            float valor;
            if (string.IsNullOrEmpty(nombre) || (stocktext == null) || string.IsNullOrEmpty(unidad))
            {
                this.ParentForm.MostrarNotificacion("Por favor, complete todos los campos", 3);
                return;
            }

            if (ogMaterialName != nombre)
            {
                if (MaterialExiste(nombre))
                {
                    this.ParentForm.MostrarNotificacion($"Ya existe el material '{nombre}'", 3);
                    return;
                }
            }

            stocktext = stocktext.Replace(',', '.');
            if (float.TryParse(stocktext, NumberStyles.Float, CultureInfo.InvariantCulture, out valor))
            {

            }
            else
            {
                this.ParentForm.MostrarNotificacion("Utilice '.' cuando quiera usar decimal", 3);
                return;
            }

            L_Materials ins = new L_Materials();

            if (!string.IsNullOrEmpty(rutaSeleccionadaMod))
            {
                byte[] bytesImage = File.ReadAllBytes(rutaSeleccionadaMod);
                ins.updateMaterialWI(idLocal, nombre, valor, unidad, bytesImage);
            }
            else
            {
                ins.updateMaterial(idLocal, nombre, valor, unidad);
            }

            tabControl1.SelectedTab = ListaMateriales;
            tabControl1.TabPages.Remove(AddMaterial);
            tabControl1.TabPages.Remove(EditMaterial);
            tabControl1.TabPages.Add(ListaMateriales);
            Principal.menuTitleLaberl.Text = "MATERIALES";
            resetCampos(sender, e);
            this.ParentForm.MostrarNotificacion("Material modificado", 1);
        }
    }
}
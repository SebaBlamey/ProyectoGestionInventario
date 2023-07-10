using aadea.Logicaq;
using aadea.userControls;
using System.Data;
using aadea.Properties;
using Image = System.Drawing.Image;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;
using System.Globalization;
using System.Windows.Forms;

namespace aadea.Vistas
{
    public partial class FormMateriales : Form
    {
        private string rutaSeleccionada;
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
            idLocal = -1;
            txtNameActual.Text = string.Empty;
            txtNameInsert.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtStockActual.Text = string.Empty;
            boxMedidaActual.Text = string.Empty;
            opcionBox.Text = string.Empty;
            rutaSeleccionada = null;
            //picImagenModify = null;
            pictureBox1 = null;

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
                userControl.Cantidad = stock.ToString("0.00");
                userControl.Unidad = unidad;
                userControl.ID = Convert.ToInt32(row["ID"]);

                // Suscribirte al evento DeleteButtonClicked y pasar el UserControl
                userControl.buttonDeleteClick += (s, args) =>
                {
                    UserControl_DeleteButtonClicked(userControl);
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
                if (row == dataTable.Rows[^1]) continue;
                var separatorPanel = new Panel();
                separatorPanel.AutoSize = false;
                separatorPanel.Height = 2;
                separatorPanel.BackColor = Color.Black;
                separatorPanel.Width = 618;
                separatorPanel.Dock = DockStyle.Bottom;
                separatorPanel.BringToFront();
                flowLayoutPanel1.Controls.Add(separatorPanel);
            }
        }

        private void UserControl_ButtonModify(UserMaterial user)
        {
            try
            {
                Principal.menuTitleLaberl.Text = "MODIFICAR MATERIAL";
                string nombre = user.nombretit;
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

        private void UserControl_DeleteButtonClicked(UserMaterial user)
        {
            int id = Convert.ToInt32(user.ID);
            L_Materials l_materials = new L_Materials();
            flowLayoutPanel1.Controls.Remove(user);
            l_materials.DeleteMaterial(id);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            resetCampos(sender, e);
            tabControl1.SelectedTab = ListaMateriales;
            tabControl1.TabPages.Add(ListaMateriales);
            tabControl1.TabPages.Remove(AddMaterial);
            tabControl1.TabPages.Remove(EditMaterial);
        }

        private void btExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Seleccionar imagen";
            selectorImagen.Filter = "Archivos de imagen|*.png;*.jpeg;*.jpg";

            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(selectorImagen.FileName).ToLower();
                if (extension == ".png" || extension == ".jpeg" || extension == ".jpg")
                {
                    // Asignar la imagen al PictureBox existente
                    pictureBox1.Image = Image.FromFile(selectorImagen.FileName);
                    rutaSeleccionada = selectorImagen.FileName;
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una imagen en formato PNG o JPEG.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btSave_Click(object sender, EventArgs e)
        {
            string nombre = txtNameInsert.Text;
            string stocktext = txtStock.Text;
            string unidad = opcionBox.Text;
            float valor;
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(stocktext) || string.IsNullOrEmpty(unidad))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            L_Materials mat = new L_Materials();
            stocktext = stocktext.Replace(',', '.');
            if (float.TryParse(stocktext, NumberStyles.Float, CultureInfo.InvariantCulture, out valor))
            {
                string mensaje = valor.ToString("F2", CultureInfo.InvariantCulture);
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("Error en el numero, intente nuevamente, recuerde que para agregar un numero decimal ocupe un '.' " );
            }
            if (!string.IsNullOrEmpty(rutaSeleccionada))
            {
                byte[] bytesImage = File.ReadAllBytes(rutaSeleccionada);

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

        private void btSaveMod_Click(object sender, EventArgs e)
        {
            string nombre = txtNameActual.Text;
            string stocktext = txtStockActual.Text;
            string unidad = boxMedidaActual.Text;
            float valor;
            if (string.IsNullOrEmpty(nombre) || (stocktext == null) || string.IsNullOrEmpty(unidad))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Campos vacíos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            stocktext = stocktext.Replace(',', '.');
            if (float.TryParse(stocktext, NumberStyles.Float, CultureInfo.InvariantCulture, out valor))
            {
                string mensaje = valor.ToString("F2", CultureInfo.InvariantCulture);
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("Error en el numero, intente nuevamente, recuerde que para agregar un numero decimal ocupe un '.' ");
            }
            L_Materials ins = new L_Materials();

            if (!string.IsNullOrEmpty(rutaSeleccionada))
            {
                byte[] bytesImage = File.ReadAllBytes(rutaSeleccionada);
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
        }


        private void btCancelMod_Click(object sender, EventArgs e)
        {
            resetCampos(sender, e);

            tabControl1.SelectedTab = ListaMateriales;
            tabControl1.TabPages.Add(ListaMateriales);
            tabControl1.TabPages.Remove(AddMaterial);
            tabControl1.TabPages.Remove(EditMaterial);
        }

        private void btExaminMod_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Seleccionar imagen";
            selectorImagen.Filter = "Archivos de imagen|*.png;*.jpeg;*.jpg";

            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(selectorImagen.FileName).ToLower();
                if (extension == ".png" || extension == ".jpeg" || extension == ".jpg")
                {
                    // Asignar la imagen seleccionada al control picImagenModify
                    picImagenModify.Image = Image.FromFile(selectorImagen.FileName);
                    rutaSeleccionada = selectorImagen.FileName;
                }
                else
                {
                    MessageBox.Show("Por favor, selecciona una imagen en formato PNG o JPEG.", "Formato incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void add_iconButton_Click(object sender, EventArgs e)
        {
            resetCampos(sender, e);
            tabControl1.SelectedTab = AddMaterial;
            tabControl1.TabPages.Add(AddMaterial);
            tabControl1.TabPages.Remove(ListaMateriales);
            tabControl1.TabPages.Remove(EditMaterial);
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
    }
}

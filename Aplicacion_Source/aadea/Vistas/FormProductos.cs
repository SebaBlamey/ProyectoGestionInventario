using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using aadea.Extras;
using aadea.Logicaq;
using aadea.Properties;
using aadea.userControls;
using Image = System.Drawing.Image;

namespace aadea.Vistas
{
    public partial class FormProductos : Form
    {
        private string rutaSeleccionada;
        private UserControl selectedUserControl;
        private int idlocal;

        public FormProductos()
        {
            InitializeComponent();
            tabControl.TabPages.Remove(AddP);
            tabControl.TabPages.Remove(EditP);
        }

        private void resetCampos(object sender, EventArgs e)
        {
            idlocal = -1;
            txtProduct.Text = string.Empty;
            txtDesc.Text = string.Empty;
            examinarPic.Image = null;
            cambiarBox.Image = null;
            textBox1.Text = string.Empty;
            textBox1.Text = string.Empty;
            rutaSeleccionada = null;
            FormProductos_Load(sender, e);
        }
        private string ogProductoName = "";

        private void AddProduct_Click_1(object sender, EventArgs e)
        {
            tabControl.SelectedTab = AddP;
            tabControl.TabPages.Remove(productList);
            ogProductoName = "";
            tabControl.TabPages.Remove(EditP);
            tabControl.TabPages.Add(AddP);
            Principal.menuTitleLaberl.Text = "AGREGAR PRODUCTOS";
            resetCampos(sender, e);
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.Multiline = true;
            flowLayoutPanel1.Controls.Clear();
            var l_products = new L_Products();
            var dataTable = l_products.listProducts();
            bool isFirstRow = true; // Variable para controlar el primer elemento

            foreach (DataRow row in dataTable.Rows)
            {

                var userControl = new UserProduct();
                var id = Convert.ToInt32(row["ID"]);
                var nombre = row["nombre"].ToString();
                var desc = row["descripcion"].ToString();
                var imagen = l_products.ObtenerImagenProducto(id);
                userControl.Tittle = nombre;
                userControl.Desc = desc;
                userControl.ID = Convert.ToInt32(row["ID"]);

                userControl.btDeleteProducto += (s, args) =>
                {
                    UserControl_DeleteButtonClicked(sender, e, userControl);
                    idlocal = userControl.ID;
                };
                userControl.btModifyProducto += (s, args) =>
                {
                    UserControl_ButtonModify(userControl);
                    idlocal = userControl.ID;
                };

                if (imagen != null && imagen.Length > 0)
                {
                    using var ms = new MemoryStream(imagen);
                    var img = Image.FromStream(ms);
                    userControl.PictureBox1 = img;
                }
                else
                {
                    userControl.PictureBox1 = Resource.defaultImage;
                }

                flowLayoutPanel1.Controls.Add(userControl);
            }
        }

        private void UserControl_ButtonModify(UserProduct user)
        {
            Principal.menuTitleLaberl.Text = "MODIFICAR PRODUCTOS";
            string nombre = user.Tittle;
            ogProductoName = user.Tittle;
            string desc = user.Desc;
            int id = user.ID;
            idlocal = user.ID;
            Image imagen = user.PictureBox1;

            tabControl.SelectedTab = EditP;
            tabControl.TabPages.Add(EditP);
            tabControl.TabPages.Remove(AddP);
            tabControl.TabPages.Remove(productList);

            // Rellenar los elementos en la pestaña de modificación
            textBox1.Text = nombre;
            textBox2.Text = desc;
            cambiarBox.Image = imagen;
            idlocal = id;
        }


        private void UserControl_DeleteButtonClicked(object sender, EventArgs e, UserProduct user)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?",
                "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(user.ID);
                L_Products l_Products = new L_Products();
                flowLayoutPanel1.Controls.Remove(user);
                l_Products.DeleteProduct(id);
                this.ParentForm.MostrarNotificacion("Producto eliminado", 1);
            }

            resetCampos(sender, e);
        }

        private void txtProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconBtnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Seleccionar imagen";
            selectorImagen.Filter = "Archivos de imagen|*.png;*.jpeg;*.jpg";

            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(selectorImagen.FileName).ToLower();
                if (extension == ".png" || extension == ".jpeg" || extension == ".jpg")
                {
                    examinarPic.Image = Image.FromStream(selectorImagen.OpenFile());
                    rutaSeleccionada = selectorImagen.FileName;
                }
                else
                {
                    this.ParentForm.MostrarNotificacion("Por favor, selecciona una imagen en formato PNG o JPEG",3);
                }
            }
        }

        private void cancelAdd_btn_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = productList;
            tabControl.TabPages.Remove(AddP);
            tabControl.TabPages.Remove(EditP);
            tabControl.TabPages.Add(productList);
            Principal.menuTitleLaberl.Text = "PRODUCTOS";
            resetCampos(sender, e);
        }

        private bool ProductoExiste(string nombre)
        {
            try
            {
                using (SQLiteConnection connection = Conexion.GetConexion().CrearConexion())
                {
                    string query = "SELECT Nombre FROM Producto WHERE Nombre = @nombre";
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
            string nombre = txtProduct.Text;
            string desc = txtDesc.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(desc))
            {
                this.ParentForm.MostrarNotificacion("Por favor, complete todos los campos", 3);
                return;
            }

            try
            {
                if (ProductoExiste(nombre))
                {
                    this.ParentForm.MostrarNotificacion($"Ya existe el producto '{nombre}'", 3);
                    return;
                }

                // El producto no existe, procedemos a guardarlo en la base de datos
                L_Products ins = new L_Products();

                if (!string.IsNullOrEmpty(rutaSeleccionada))
                {
                    byte[] bytesImagen = File.ReadAllBytes(rutaSeleccionada);
                    ins.InsertProductWI(nombre, desc, bytesImagen);
                }
                else
                {
                    ins.InsertProduct(nombre, desc);
                }

                tabControl.SelectedTab = productList;
                tabControl.TabPages.Remove(AddP);
                tabControl.TabPages.Remove(EditP);
                tabControl.TabPages.Add(productList);
                resetCampos(sender, e);
                Principal.menuTitleLaberl.Text = "PRODUCTOS";
                this.ParentForm.MostrarNotificacion("Producto guardado", 1);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones: muestra un mensaje y registra el error para depuración
                this.ParentForm.MostrarNotificacion("Ha ocurrido un error al guardar el producto.", 3);
                Console.WriteLine(ex.Message);
            }
        }



        private void cancel_BtnEdit_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = productList;
            tabControl.TabPages.Remove(AddP);
            tabControl.TabPages.Remove(EditP);
            tabControl.TabPages.Add(productList);
            Principal.menuTitleLaberl.Text = "PRODUCTOS";
            resetCampos(sender, e);
        }

        private void save_BtnEdit_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string desc = textBox2.Text;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(desc))
            {
                this.ParentForm.MostrarNotificacion("Por favor, complete todos los campos", 3);
                return;
            }

            if (ogProductoName != nombre)
            {
                if (ProductoExiste(nombre))
                {
                    this.ParentForm.MostrarNotificacion($"Ya existe el producto '{nombre}'", 3);
                    return;
                }
            }

            L_Products ins = new L_Products();

            if (!string.IsNullOrEmpty(rutaSeleccionada))
            {
                byte[] bytesImagen = File.ReadAllBytes(rutaSeleccionada);
                ins.updateWI(idlocal, nombre, desc, bytesImagen);
            }
            else
            {
                ins.update(idlocal, nombre, desc);
            }

            tabControl.SelectedTab = productList;
            tabControl.TabPages.Remove(AddP);
            tabControl.TabPages.Remove(EditP);
            tabControl.TabPages.Add(productList);
            Principal.menuTitleLaberl.Text = "PRODUCTOS";
            resetCampos(sender, e);
            this.ParentForm.MostrarNotificacion("Producto editado", 1);
        }

        private void search_BtnEdit_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Seleccionar imagen";
            selectorImagen.Filter = "Archivos de imagen|*.png;*.jpeg;*.jpg";

            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(selectorImagen.FileName).ToLower();
                if (extension == ".png" || extension == ".jpeg" || extension == ".jpg")
                {
                    cambiarBox.Image = System.Drawing.Image.FromStream(selectorImagen.OpenFile());
                    rutaSeleccionada = selectorImagen.FileName;
                }
                else
                {
                    this.ParentForm.MostrarNotificacion("Por favor, selecciona una imagen en formato PNG o JPEG", 3);
                }
            }
        }
    }
}
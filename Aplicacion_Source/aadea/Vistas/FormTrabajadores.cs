using aadea.Extras;
using System.Data.SQLite;

namespace aadea.Vistas
{
    public partial class FormTrabajadores : Form
    {
        private int option;

        public FormTrabajadores()
        {
            InitializeComponent();
            tabControlE.TabPages.Remove(addE);
        }

        private void ListadoT()
        {
            L_Trabajadores datos = new L_Trabajadores();
            DGV_T.DataSource = datos.Listado_Trabajadores();
        }

        private void FormTrabajadores_Load(object sender, EventArgs e)
        {
            this.ListadoT();
            tabControlE.ItemSize = new Size(0, 1);
            tabControlE.SizeMode = TabSizeMode.Fixed;
            tabControlE.Multiline = true;
            DGV_T.ClearSelection();
        }

        private void CleanTextBoxes()
        {
            textBoxRut.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxSurname.Text = string.Empty;
            textBoxAddress.Text = string.Empty;
            textBoxPhNum.Text = string.Empty;
        }

        private void BackToEmpList()
        {
            Principal.menuTitleLaberl.Text = "TRABAJADORES";
            tabControlE.SelectedTab = employeList;
            tabControlE.TabPages.Remove(addE);
            tabControlE.TabPages.Add(employeList);
        }

        private void GoToAddTab()
        {
            tabControlE.SelectedTab = addE;
            tabControlE.TabPages.Remove(employeList);
            tabControlE.TabPages.Add(addE);
        }

        private void employeList_Click(object sender, EventArgs e)
        {
            DGV_T.ClearSelection();
        }

        private void addE_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            Principal.menuTitleLaberl.Text = "AGREGAR TRABAJADOR";
            this.option = 1;
            this.GoToAddTab();
        }

        private string ogTrabajadorName = "";

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (DGV_T.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione una fila para editar", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            textBoxRut.Text = Convert.ToString(DGV_T.SelectedRows[0].Cells["Rut"].Value);
            ogTrabajadorName = textBoxRut.Text;
            textBoxName.Text = Convert.ToString(DGV_T.SelectedRows[0].Cells["Nombre"].Value);
            textBoxSurname.Text = Convert.ToString(DGV_T.SelectedRows[0].Cells["Apellido"].Value);
            textBoxAddress.Text = Convert.ToString(DGV_T.SelectedRows[0].Cells["Direccion"].Value);
            textBoxPhNum.Text = Convert.ToString(DGV_T.SelectedRows[0].Cells["Telefono"].Value);

            Principal.menuTitleLaberl.Text = "MODIFICAR TRABAJADOR";
            this.option = 2;
            this.GoToAddTab();
            textBoxRut.ReadOnly = true;
        }

        private void delete_iconButton_Click(object sender, EventArgs e)
        {
            L_Trabajadores ins = new L_Trabajadores();
            if (DGV_T.SelectedRows.Count == 0)
            {
                this.ParentForm.MostrarNotificacion("Por favor, seleccione una fila para eliminar",3);
                return;
            }

            string rut = Convert.ToString(DGV_T.SelectedRows[0].Cells["Rut"].Value);

            // Mostrar ventana emergente de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este trabajador?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ins.EliminarTrabajador(rut);
                DGV_T.DataSource = null;
                DGV_T.Rows.Clear();
                FormTrabajadores_Load(sender, e);
                this.ParentForm.MostrarNotificacion("Trabajador eliminado", 1);
            }
        }

        private bool TrabajadorExiste(string rut)
        {
            try
            {
                using (SQLiteConnection connection = Conexion.GetConexion().CrearConexion())
                {
                    string query = "SELECT rut FROM Trabajador WHERE rut = @rut";
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@rut", rut);
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

        private void trabajadoresAdd_Click(object sender, EventArgs e)
        {

            L_Trabajadores ins = new L_Trabajadores();
            string rut = textBoxRut.Text;
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string address = textBoxAddress.Text;
            string phNum = textBoxPhNum.Text;

            if (ogTrabajadorName != rut)
            {
                if (TrabajadorExiste(rut) == true)
                {
                    this.ParentForm.MostrarNotificacion($"El trabajador con rut {rut} ya existe", 3);
                    return;
                }
            }

            if (this.option == 1)
            {
                if (!string.IsNullOrEmpty(rut) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname))
                {
                    ins.InsertarTrabajador(rut, name, surname, address, phNum);
                    this.BackToEmpList();
                    this.CleanTextBoxes();
                    this.FormTrabajadores_Load(sender, e);
                    this.ParentForm.MostrarNotificacion("Trabajador guardado", 1);
                }
                else
                {
                    this.ParentForm.MostrarNotificacion("Llene los campos necesarios", 3);
                }
            }

            if (this.option == 2)
            {
                //textBoxRut.ReadOnly = true;
                if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname))
                {
                    ins.EditEmployee(rut, name, surname, address, phNum);
                    this.BackToEmpList();
                    this.CleanTextBoxes();
                    this.FormTrabajadores_Load(sender, e);
                    this.ParentForm.MostrarNotificacion("Trabajador modificado", 1);
                }
                else
                {
                    //MessageBox.Show("Llene los campos necesarios (Nombre y Apellido)", "Error", MessageBoxButtons.OK,
                    //    MessageBoxIcon.Error);
                    this.ParentForm.MostrarNotificacion("Llene los campos necesarios", 3);

                }

                textBoxRut.ReadOnly = false;
            }

        }

        private void trabajadoresDelete_Click(object sender, EventArgs e)
        {
            this.BackToEmpList();
            this.CleanTextBoxes();
            this.FormTrabajadores_Load(sender, e);
        }
    }
}

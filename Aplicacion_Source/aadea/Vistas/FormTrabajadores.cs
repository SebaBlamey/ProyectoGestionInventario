using aadea.Logicaq;
using aadea.Model;
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
            DGV_T.ClearSelection();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.option = 1;
            this.GoToAddTab();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (DGV_T.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione una fila para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBoxRut.Text = Convert.ToString(DGV_T.SelectedRows[0].Cells["Rut"].Value);
            textBoxName.Text = Convert.ToString(DGV_T.SelectedRows[0].Cells["Nombre"].Value);
            textBoxSurname.Text = Convert.ToString(DGV_T.SelectedRows[0].Cells["Apellido"].Value);
            textBoxAddress.Text = Convert.ToString(DGV_T.SelectedRows[0].Cells["Direccion"].Value);
            textBoxPhNum.Text = Convert.ToString(DGV_T.SelectedRows[0].Cells["Telefono"].Value);

            this.option = 2;
            this.GoToAddTab();
            textBoxRut.ReadOnly = true;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            L_Trabajadores ins = new L_Trabajadores();
            if (DGV_T.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione una fila para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string rut = Convert.ToString(DGV_T.SelectedRows[0].Cells["Rut"].Value);
            ins.EliminarTrabajador(rut);
            DGV_T.DataSource = null;
            DGV_T.Rows.Clear();
            FormTrabajadores_Load(sender, e);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            L_Trabajadores ins = new L_Trabajadores();
            string rut = textBoxRut.Text;
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string address = textBoxAddress.Text;
            string phNum = textBoxPhNum.Text;

            if (this.option == 1)
            {
                if (!string.IsNullOrEmpty(rut) && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname))
                {
                    ins.InsertarTrabajador(rut, name, surname, address, phNum);
                    this.BackToEmpList();
                    this.CleanTextBoxes();
                    this.FormTrabajadores_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Llene los campos necesarios (Rut, Nombre y Apellido)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                }
                else
                {
                    MessageBox.Show("Llene los campos necesarios (Nombre y Apellido)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textBoxRut.ReadOnly = false;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.BackToEmpList();
            this.CleanTextBoxes();
            this.FormTrabajadores_Load(sender, e);
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
    }
}

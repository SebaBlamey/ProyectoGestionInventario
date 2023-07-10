using aadea.Logicaq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing.Text;
using System.Windows.Controls;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace aadea.Vistas
{
    public partial class FormAsistencia : Form
    {

        private readonly string expresionRegular = @"^([01][0-9]|2[0-3]):[0-5][0-9]$";

        public FormAsistencia()
        {


            InitializeComponent();
            DGV_Asist.CellFormatting += DGV_Asist_CellFormatting;
            dateTimePickerFecha.CustomFormat = "dd/MM/yyyy";
            TabPrincipal.TabPages.Remove(Add);
        }

        public void ListadoAsist()
        {
            L_Asistencia datos = new L_Asistencia();
            DGV_Asist.DataSource = datos.listAsist();
        }
        private void ListadoTrabajador()
        {
            L_Asistencia datos = new L_Asistencia();
            DGV_Trabajador.DataSource = datos.listTrabajadoresAsist();
        }



        private void FormAsist_Load(object sender, EventArgs e)
        {

            this.ListadoAsist();
            this.ListadoTrabajador();
            this.Formato_Asist();
        }

        private void Formato_Asist()
        {
            DGV_Asist.Columns[0].Width = 100;


        }


        private void resetCamp(object sender, EventArgs e)
        {
            CheckIn.Text = string.Empty;
            CheckOut.Text = string.Empty;
            FormAsist_Load(sender, e);
        }


        //Boton Guardar en Añadir
        private void AddSave_Click(object sender, EventArgs e)
        {

            if (queryCall(sender, e))
            {
                TabPrincipal.SelectedTab = History;
                TabPrincipal.TabPages.Add(History);
                TabPrincipal.TabPages.Remove(Add);
            }
            resetCamp(sender, e);
        }
        private bool repeat(string rut, DateTime fecha, DateTime horallegada, DateTime horasalida)
        {
            L_Asistencia l_Asistencia = new L_Asistencia();
            bool answer = l_Asistencia.checkRepeat(rut,fecha,horallegada,horasalida);
            return answer;

        }

        private bool queryCall(object sender, EventArgs e)
        {
            L_Asistencia l_Asistencia = new L_Asistencia();

            string rut;

            if (DGV_Trabajador.SelectedRows.Count > 0)
            {
                // Se seleccionó una fila completa del trabajador
                DataGridViewRow filaSeleccionada = DGV_Trabajador.SelectedRows[0];
                rut = filaSeleccionada.Cells["rut"].Value.ToString();
            }
            else if (DGV_Trabajador.SelectedCells.Count > 0)
            {
                // Se seleccionó solo el valor del rut
                int rowIndex = DGV_Trabajador.SelectedCells[0].RowIndex;
                DataGridViewRow filaSeleccionada = DGV_Trabajador.Rows[rowIndex];
                rut = filaSeleccionada.Cells["rut"].Value.ToString();
            }
            else
            {
                // No se seleccionó ninguna fila o celda
                MessageBox.Show("Seleccione un trabajador o el valor del rut.", "Error");
                return false;
            }

            DateTime fechaSeleccionada = dateTimePickerFecha.Value.Date;
            string horaLlegada = CheckIn.Text;
            string horaSalida = CheckOut.Text;

            Regex regex = new Regex(@"^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$");
            if (!regex.IsMatch(horaLlegada) || !regex.IsMatch(horaSalida))
            {
                // Mostrar mensaje de error o realizar alguna acción apropiada
                MessageBox.Show("Formato de hora incorrecto. Utilice el formato HH:mm.", "Error");
                
                return false;
            }

            // Calcular las horas trabajadas
            DateTime llegada = DateTime.ParseExact(horaLlegada, "HH:mm", CultureInfo.InvariantCulture);
            DateTime salida = DateTime.ParseExact(horaSalida, "HH:mm", CultureInfo.InvariantCulture);

            DateTime NewFormatLlegada = llegada.Date + llegada.TimeOfDay;
            DateTime NewFormatSalida = salida.Date + salida.TimeOfDay;

            TimeSpan horasTrabajadas = salida - llegada;

            // Obtener las horas trabajadas en formato float
            float horasTrabajadasFloat = (float)horasTrabajadas.TotalHours;
            TotalsHours.Text = horasTrabajadasFloat.ToString();
            bool answer = l_Asistencia.checkRepeat(rut, fechaSeleccionada, NewFormatLlegada, NewFormatSalida);
            if (answer)
            {
                MessageBox.Show("La informacion que esta ingresando, esta repetida.");
                Windows("Add");
                return false;
            }

            l_Asistencia.InsertAssistance(rut, fechaSeleccionada, NewFormatLlegada, NewFormatSalida, horasTrabajadasFloat);
            FormAsist_Load(sender, e);
            MessageBox.Show("Asistencia Agregada Correctamente");
            Windows("History");
            return true;
        }



        private void Windows(string pestaña)
        {
            TabPrincipal.SelectTab(pestaña);
        }

        private void Disguise(TabPage name)
        {
            TabPrincipal.TabPages.Remove(name);
        }
        private void Show(TabPage name)
        {
            TabPrincipal.TabPages.Add(name);
        }


        private void DGV_Asist_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DGV_Asist.Columns[e.ColumnIndex].Name == "Llegada" || DGV_Asist.Columns[e.ColumnIndex].Name == "Salida")
            {
                if (e.Value != null && e.Value is DateTime)
                {
                    DateTime fecha = (DateTime)e.Value;
                    string horaReducida = fecha.ToString("HH:mm"); // Formato HH:MM

                    e.Value = horaReducida;
                    e.FormattingApplied = true;
                }
            }
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            TabPrincipal.SelectedTab = Add;
            TabPrincipal.TabPages.Add(Add);
            TabPrincipal.TabPages.Remove(History);
            resetCamp(sender, e);
            Windows("Add");
        }

        //Cancelar boton de agregar
        private void CancelBT_Click(object sender, EventArgs e)
        {
            TabPrincipal.SelectedTab = History;
            TabPrincipal.TabPages.Add(History);
            TabPrincipal.TabPages.Remove(Add);
            resetCamp(sender, e);
            Windows("History");

        }

        private void Save_Click(object sender, EventArgs e)
        {
            Windows("History");
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Windows("History");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            L_Asistencia l_Asistencia = new L_Asistencia();

            // Verificar si hay una fila seleccionada
            if (DGV_Asist.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = DGV_Asist.SelectedRows[0];

                // Obtener los valores de las celdas de la fila
                string rut = filaSeleccionada.Cells["rut"].Value.ToString();
                DateTime fecha = Convert.ToDateTime(filaSeleccionada.Cells["Dia"].Value);
                DateTime horaLlegada = Convert.ToDateTime(filaSeleccionada.Cells["Llegada"].Value);
                // Obtener el ID utilizando el método GetID;
                // Llamar al método de eliminación en tu otra clase, pasando el ID
                l_Asistencia.DeleteAssistance(rut,fecha,horaLlegada);

                // Actualizar el DataGridView si es necesario
                // dgvDatos.DataSource = ...;
                Windows("History");
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila antes de eliminar.");
            }

            TabPrincipal.TabPages.Remove(Add);
            resetCamp(sender, e);
        }


        private void Cancel_Delete_Btn_Click(object sender, EventArgs e)
        {
            TabPrincipal.SelectedTab = History;
            TabPrincipal.TabPages.Add(History);
            TabPrincipal.TabPages.Remove(Add);

        }
    }
}

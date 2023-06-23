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
            Disguise(Delete);
            dateTimePickerFecha.CustomFormat = "dd/MM/yyyy";
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






        private void AddSave_Click(object sender, EventArgs e)
        {
            queryCall(sender, e);

        }

        private void queryCall(object sender, EventArgs e)
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
                return;
            }

            DateTime fechaSeleccionada = dateTimePickerFecha.Value.Date;
            string horaLlegada = CheckIn.Text;
            string horaSalida = CheckOut.Text;

            Regex regex = new Regex(@"^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$");
            if (!regex.IsMatch(horaLlegada) || !regex.IsMatch(horaSalida))
            {
                // Mostrar mensaje de error o realizar alguna acción apropiada
                MessageBox.Show("Formato de hora incorrecto. Utilice el formato HH:mm.", "Error");
                return;
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

            l_Asistencia.InsertAssistance(rut, fechaSeleccionada, NewFormatLlegada, NewFormatSalida, horasTrabajadasFloat);
            FormAsist_Load(sender, e);
            MessageBox.Show("Asistencia Agregada Correctamente");
            Windows("History");
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                Diseño();
                Windows("Edit");

                int rowIndex = DGV_Asist.SelectedCells[0].RowIndex;
                DataGridViewRow row = DGV_Asist.Rows[rowIndex];


                newArrival.Text = Convert.ToDateTime(row.Cells["Dia"].Value).ToString();
                DateTime Llegada = Convert.ToDateTime(row.Cells["Llegada"].Value);
                DateTime Salida = Convert.ToDateTime(row.Cells["Salida"].Value);
                float HorasTrabajadas = Convert.ToSingle(row.Cells["Horas trabajadas"].Value);







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }
        private void Diseño()
        {
            int rowIndex = DGV_Asist.SelectedCells[0].RowIndex;
            DataGridViewRow row = DGV_Asist.Rows[rowIndex];

            // Obtener los valores de la fila seleccionada

            string Rut = row.Cells["Rut"].Value.ToString();
            string Nombre = row.Cells["Nombre"].Value.ToString();
            string Apellido = row.Cells["Apellido"].Value.ToString();
            DateTime Fecha = Convert.ToDateTime(row.Cells["Dia"].Value);
            DateTime Llegada = Convert.ToDateTime(row.Cells["Llegada"].Value);
            DateTime Salida = Convert.ToDateTime(row.Cells["Salida"].Value);
            float HorasTrabajadas = Convert.ToSingle(row.Cells["Horas trabajadas"].Value);

            rut.Text = "Rut: " + Rut;
            nombre.Text = "Nombre: " + Nombre;
            lastName.Text = "Apellido: " + Apellido;


            string[] dateList = Fecha.ToString().Split(' ');
            string dia = dateList[0];
            date.Text = "Fecha: " + dia;

            string[] arrivalList = Llegada.ToString().Split(" ");
            string llegadaString = dateList[1];
            llegadaString += " " + dateList[2];
            llegadaString += dateList[3];
            Arrival.Text = "Hora de llegada: " + llegadaString;


            string[] leaveList = Salida.ToString().Split(" ");
            string salidaString = leaveList[1];
            salidaString += " " + leaveList[2];
            salidaString += leaveList[3];
            leave.Text = "Hora de salida: " + salidaString;
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
            Windows("Add");
        }

        private void CancelBT_Click(object sender, EventArgs e)
        {
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
            MessageBox.Show("Proximamente");
        }
    }
}

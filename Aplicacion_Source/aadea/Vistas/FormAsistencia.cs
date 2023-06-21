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

namespace aadea.Vistas
{
    public partial class FormAsistencia : Form
    {

        private readonly string expresionRegular = @"^([01][0-9]|2[0-3]):[0-5][0-9]$";
        public FormAsistencia()
        {
            InitializeComponent();
        }

        private void ListadoAsist()
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
            DGV_Asist.Columns[0].Width = 200;

        }






        private void AddSave_Click(object sender, EventArgs e)
        {
            L_Asistencia l_Asistencia = new L_Asistencia();

            string rut;
            string nombre;
            string apellido;

   

            DateTime fechaSeleccionada = dateTimePickerFecha.Value;
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

            TimeSpan horasTrabajadas = salida - llegada;

            // Obtener las horas trabajadas en formato float
            float horasTrabajadasFloat = (float)horasTrabajadas.TotalHours;
 
                DataGridViewRow filaSeleccionada = DGV_Trabajador.SelectedRows[0];
                rut = filaSeleccionada.Cells["rut"].Value.ToString();
                nombre = filaSeleccionada.Cells["nombre"].Value.ToString();
                apellido = filaSeleccionada.Cells["apellido"].Value.ToString();

                l_Asistencia.InsertAssistance(rut, fechaSeleccionada, llegada, salida, nombre, apellido, horasTrabajadasFloat);

            

        }



    }
}

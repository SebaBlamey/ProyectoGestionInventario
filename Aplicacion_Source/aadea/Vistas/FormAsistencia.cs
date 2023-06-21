using aadea.Logicaq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aadea.Vistas
{
    public partial class FormAsistencia : Form
    {
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
            if (DGV_Trabajador.SelectedRows.Count > 0)
            {
                // Obtener el índice de la columna del nombre del trabajador en DGV_Trabajador
                int nombreColumnIndex = DGV_Trabajador.Columns["Nombre"].Index;

                // Obtener el nombre del trabajador de la fila seleccionada
                string nombre = DGV_Trabajador.SelectedRows[0].Cells[nombreColumnIndex].Value.ToString();

                // Obtener los valores seleccionados en la pestaña "Añadir"
                string rut = DGV_Trabajador.SelectedRows[0].Cells["Rut"].Value.ToString();
                string apellido = DGV_Trabajador.SelectedRows[0].Cells["Apellido"].Value.ToString();
                DateTime fecha = dateTimePickerFecha.Value;
                string horaLlegada = CheckIn.Text;
                string horaSalida = CheckOut.Text;

                // Calcular la diferencia de tiempo entre la hora de llegada y la hora de salida
                TimeSpan tiempoLlegada = TimeSpan.Parse(horaLlegada);
                TimeSpan tiempoSalida = TimeSpan.Parse(horaSalida);
                TimeSpan horasTrabajadas = tiempoSalida - tiempoLlegada;

                // Obtener la cantidad total de horas trabajadas como un valor decimal
                double totalHorasTrabajadas = horasTrabajadas.TotalHours;

                // Agregar una nueva fila al DataGridView de la pestaña "Historial"
                DGV_Asist.Rows.Add(rut, nombre, apellido, fecha, horaLlegada, horaSalida, totalHorasTrabajadas);
            }
        }



    }
}

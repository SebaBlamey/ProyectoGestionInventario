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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Documents;
using aadea.Extras;

namespace aadea.Vistas
{
    public partial class FormAsistencia : Form
    {
        bool opcionSeleccionada = false;
        private readonly string expresionRegular = @"^([01][0-9]|2[0-3]):[0-5][0-9]$";
        Mes[] meses = new[]
        {
            new Mes("Enero"),
            new Mes("Febrero"),
            new Mes("Marzo"),
            new Mes("Abril"),
            new Mes("Mayo"),
            new Mes("Junio"),
            new Mes("Julio"),
            new Mes("Agosto"),
            new Mes("Septiembre"),
            new Mes("Octubre"),
            new Mes("Noviembre"),
            new Mes("Diciembre")
        };
        public FormAsistencia()
        {
            InitializeComponent();
            TabPrincipal.ItemSize = new Size(0, 1);
            TabPrincipal.SizeMode = TabSizeMode.Fixed;
            TabPrincipal.Multiline = true;
            DGV_Asist.CellFormatting += DGV_Asist_CellFormatting;
            dateTimePickerFecha.CustomFormat = "dd/MM/yyyy";
            Disguise(Add);
            Disguise(Filtrar);
        }
        public void editDGV_Meses()
        {
            DGV_Meses.DataSource = meses;
            DGV_Meses.ReadOnly = true;
            foreach (DataGridViewColumn column in DGV_Meses.Columns)
            {
                column.ReadOnly = true;
            }
        }
        public void editDGV_Rut()
        {
            L_Asistencia l_Asistencia = new L_Asistencia();
            DGV_Meses.DataSource = l_Asistencia.listNTrabajador();
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
        private void ListadoFiltroTrabajador_M(string mes)
        {
            L_Asistencia datos = new L_Asistencia();
            DGV_Filter.DataSource = datos.ListAsistFilterM(mes);
        }
        public void ListadoFiltroTrabajador_T(string rut)
        {
            L_Asistencia datos = new L_Asistencia();
            DGV_Filter.DataSource = datos.ListAsistFilterT(rut);
        }
        public void ListadoAsist2()
        {
            L_Asistencia datos = new L_Asistencia();
            DGV_Filter.DataSource = datos.listAsist();
        }
        private void FormAsist_Load(object sender, EventArgs e)
        {

            this.ListadoAsist();
            this.ListadoTrabajador();
            this.Formato_Asist();

            if (!opcionSeleccionada)
            {
                this.ListadoAsist2();
                this.editDGV_Meses();
            }

        }
        private void Formato_Asist()
        {
            DGV_Asist.Columns[0].Width = 100;


        } //FORMATO ASISTENCIA
        private void resetCamp(object sender, EventArgs e)
        {
            CheckIn.Text = string.Empty;
            FormAsist_Load(sender, e);
        } //REINICIAR CAMPOS
        private void AddSave_Click(object sender, EventArgs e)
        {
        }//Boton Guardar en Añadir
        private bool queryCall(object sender, EventArgs e)
        {
            try
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
                //string horaSalida = CheckOut.Text;
                Regex regex = new Regex(@"^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$");
                if (!regex.IsMatch(horaLlegada))
                {
                    // Mostrar mensaje de error o realizar alguna acción apropiada
                    MessageBox.Show("Formato de hora incorrecto. Utilice el formato HH:mm.", "Error");

                    return false;
                }
                // Calcular las horas trabajadas
                DateTime llegada = DateTime.ParseExact(horaLlegada, "HH:mm", CultureInfo.InvariantCulture);
                //DateTime salida = DateTime.ParseExact(horaSalida, "HH:mm", CultureInfo.InvariantCulture);
                DateTime NewFormatLlegada = llegada.Date + llegada.TimeOfDay;
                //DateTime NewFormatSalida = salida.Date + salida.TimeOfDay;
                //TimeSpan horasTrabajadas = salida - llegada;
                // Obtener las horas trabajadas en formato float
                //float horasTrabajadasFloat = (float)horasTrabajadas.TotalHours;
                //TotalsHours.Text = horasTrabajadasFloat.ToString();
                //bool answer = l_Asistencia.checkRepeat(rut, fechaSeleccionada, NewFormatLlegada, NewFormatSalida);

                MessageBox.Show(rut);
                MessageBox.Show(fechaSeleccionada.ToString());
                //MessageBox.Show(NewFormatLlegada.ToString());
                l_Asistencia.InsertAssistance(rut, fechaSeleccionada, NewFormatLlegada);

                FormAsist_Load(sender, e);
                MessageBox.Show("Asistencia Agregada Correctamente");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        } //LOGICA PARA AGREGAR ASISTENCIA
        private void Windows(TabPage pestaña)
        {
            TabPrincipal.SelectTab(pestaña);
        } //LOGICA PARA CAMBIAR DE VENTANA
        private void Disguise(TabPage name)
        {
            TabPrincipal.TabPages.Remove(name);
        } //LOGICA PARA ELIMINAR VENTANA
        private void Show(TabPage name) //LOGICA PARA MOSTRAR VENTANA
        {
            TabPrincipal.TabPages.Add(name);
        }
        private void DGV_Asist_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) //FORMATO DE DGV
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
        private void finalHourConfirm()
        {
            try
            {

                Regex regex = new Regex(@"^(0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$");
                L_Asistencia l_Asistencia = new L_Asistencia();
                DataGridViewRow filaSeleccionada = DGV_Asist.SelectedRows[0];
                // Obtener los valores de las celdas de la fila
                string rut = filaSeleccionada.Cells["rut"].Value.ToString();
                DateTime fecha = Convert.ToDateTime(filaSeleccionada.Cells["Dia"].Value);
                DateTime horaLlegada = Convert.ToDateTime(filaSeleccionada.Cells["Llegada"].Value);
                if (!regex.IsMatch(FinalHourTB.Text))
                {
                    // Mostrar mensaje de error o realizar alguna acción apropiada
                    MessageBox.Show("Formato de hora no valida. Utilice el formato HH:mm.", "Error");

                    return;
                }
                DateTime horaSalida = Convert.ToDateTime(FinalHourTB.Text);
                if (!ValidarHoraSalida(horaLlegada, horaSalida))
                {
                    MessageBox.Show("Esta ingresando una hora de salida menor a la de llegada.", "Error");
                    return;
                }
                l_Asistencia.UpdateAssistance(rut, fecha, horaLlegada, horaSalida);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } //MODIFICACION DE HORA DE SALIDA
        private bool ValidarHoraSalida(DateTime horaLlegada, DateTime horaSalida) //VERIFICACION DE HORA DE SALIDA PARA QUE NO SEA MENOR A LA DE LLEGADA
        {
            // Verificar si la hora de salida es menor a la hora de llegada
            if (horaSalida < horaLlegada)
            {
                return false;
            }

            return true;
        }
        private void FinalHouBTAccept_Click(object sender, EventArgs e) //ACEPTAR DE LA ELIMINACION
        {
        }
        private void OpcionCB_CheckedChanged_1(object sender, EventArgs e)
        {


            if (OpcionCB.Checked)
            {
                opcionSeleccionada = true;
                this.editDGV_Rut();



            }
            else
            {
                opcionSeleccionada = false;
                this.editDGV_Meses();

            }
        }// CAMBIAR DE MODO TRABAJADOR A MESES
        private void DGV_Meses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (opcionSeleccionada)
            {
                string rut = DGV_Meses.CurrentRow.Cells["Rut"].Value.ToString();
                this.ListadoFiltroTrabajador_T(rut);
            }
            else
            {
                string mesSeleccionado = DGV_Meses.CurrentRow.Cells["Nombre"].Value.ToString();
                int numeroMes = DateTime.ParseExact(mesSeleccionado, "MMMM", CultureInfo.CurrentCulture).Month;
                string numeroMesFormateado = numeroMes.ToString("00");
                this.ListadoFiltroTrabajador_M(numeroMesFormateado);
            }

        }

        private void FilterBT_Click(object sender, EventArgs e)
        {
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            TabPrincipal.SelectedTab = Add;
            TabPrincipal.TabPages.Add(Add);
            TabPrincipal.TabPages.Remove(History);
            resetCamp(sender, e);
            Windows(Add);
        }

        private void FilterAsistencia_Click(object sender, EventArgs e)
        {
            Show(Filtrar);
            Windows(Filtrar);
        }

        private void delete_iconButton_Click(object sender, EventArgs e)
        {
            L_Asistencia l_Asistencia = new L_Asistencia();
            // Verificar si hay una fila seleccionada
            if (DGV_Asist.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debes seleccionar una fila antes de eliminar.");
            }



            DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta asistencia?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Obtener la fila seleccionada
            if (result == DialogResult.Yes)
            {
                DataGridViewRow filaSeleccionada = DGV_Asist.SelectedRows[0];
                // Obtener los valores de las celdas de la fila
                string rut = filaSeleccionada.Cells["rut"].Value.ToString();
                DateTime fecha = Convert.ToDateTime(filaSeleccionada.Cells["Dia"].Value);
                DateTime horaLlegada = Convert.ToDateTime(filaSeleccionada.Cells["Llegada"].Value);
                // Obtener el ID utilizando el método GetID;
                // Llamar al método de eliminación en tu otra clase, pasando el ID
                l_Asistencia.DeleteAssistance(rut, fecha, horaLlegada);

                // Actualizar el DataGridView si es necesario
                // dgvDatos.DataSource = ...;
                Windows(History);


                TabPrincipal.TabPages.Remove(Add);
                resetCamp(sender, e);
            }
        }

        private void ConfirmAsistencia_Click(object sender, EventArgs e)
        {
            finalHourConfirm();
            FormAsist_Load(sender, e);
        }

        private void AceptarAdd_Click(object sender, EventArgs e)
        {
            if (queryCall(sender, e))
            {
                TabPrincipal.SelectedTab = History;
                TabPrincipal.TabPages.Add(History);
                TabPrincipal.TabPages.Remove(Add);
            }
            resetCamp(sender, e);
        }

        private void cancelAdd_Click(object sender, EventArgs e)
        {
            TabPrincipal.SelectedTab = History;
            TabPrincipal.TabPages.Add(History);
            TabPrincipal.TabPages.Remove(Add);
            resetCamp(sender, e);
            Windows(History);
        }
    }
}

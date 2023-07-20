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
using System.Reflection;


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
            iconButton1.Click += Cancelar_Click;
            TabPrincipal.ItemSize = new Size(0, 1);
            TabPrincipal.SizeMode = TabSizeMode.Fixed;
            TabPrincipal.Multiline = true;
            DGV_Asist.CellFormatting += DGV_Asist_CellFormatting;
            DGV_Filter.CellFormatting += DGV_Filter_CellFormatting;
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
            DGV_Asist.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;



        } //FORMATO ASISTENCIA
        private void resetCamp(object sender, EventArgs e)
        {
            CheckIn.Text = string.Empty;
            FormAsist_Load(sender, e);
        } //REINICIAR CAMPOS

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

                //MessageBox.Show(NewFormatLlegada.ToString());
                l_Asistencia.InsertAssistance(rut, fechaSeleccionada, NewFormatLlegada);

                FormAsist_Load(sender, e);
                this.ParentForm.MostrarNotificacion("Asistencia Agregada Correctamente", 1);


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
        private void DGV_Asist_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (e.ColumnIndex == DGV_Asist.Columns["Llegada"].Index || e.ColumnIndex == DGV_Asist.Columns["Salida"].Index)
            {
                if (e.Value != null && e.Value is DateTime)
                {
                    DateTime fecha = (DateTime)e.Value;
                    string horaReducida = fecha.ToString("HH:mm"); // Formato HH:mm

                    e.Value = horaReducida;
                    e.FormattingApplied = true;
                }
            }
        }

        private void DGV_Filter_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (e.ColumnIndex == DGV_Filter.Columns["Llegada"].Index || e.ColumnIndex == DGV_Filter.Columns["Salida"].Index)
            {
                if (e.Value != null && e.Value is DateTime)
                {
                    DateTime fecha = (DateTime)e.Value;
                    string horaReducida = fecha.ToString("HH:mm"); // Formato HH:mm

                    e.Value = horaReducida;
                    e.FormattingApplied = true;
                }
            }
        }

        private bool FinalHourConfirm()
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
                    MessageBox.Show("Formato de hora no válida. Utilice el formato HH:mm.", "Error");
                    return false;
                }

                DateTime horaSalida = Convert.ToDateTime(FinalHourTB.Text);

                if (!ValidarHoraSalida(horaLlegada, horaSalida))
                {
                    MessageBox.Show("Está ingresando una hora de salida menor a la de llegada.", "Error");
                    return false;
                }

                l_Asistencia.UpdateAssistance(rut, fecha, horaLlegada, horaSalida);

                // El proceso se ha realizado correctamente
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        //MODIFICACION DE HORA DE SALIDA
        private bool ValidarHoraSalida(DateTime horaLlegada, DateTime horaSalida) //VERIFICACION DE HORA DE SALIDA PARA QUE NO SEA MENOR A LA DE LLEGADA
        {
            // Verificar si la hora de salida es menor a la hora de llegada
            if (horaSalida < horaLlegada)
            {
                return false;
            }

            return true;
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
        private void AddProduct_Click(object sender, EventArgs e)
        {
            TabPrincipal.SelectedTab = Add;
            TabPrincipal.TabPages.Add(Add);
            TabPrincipal.TabPages.Remove(History);
            resetCamp(sender, e);
            Principal.menuTitleLaberl.Text = "AGREGAR ASISTENCIA";
            Windows(Add);
        }

        private void FilterAsistencia_Click(object sender, EventArgs e)
        {
            Principal.menuTitleLaberl.Text = "FILTRAR ASISTENCIA";
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
                this.ParentForm.MostrarNotificacion("Asistencia eliminada", 3);
            }
        }

        private void ConfirmAsistencia_Click(object sender, EventArgs e)
        {
            if (FinalHourConfirm())
            {
                FormAsist_Load(sender, e);
                this.ParentForm.MostrarNotificacion("Hora de salida Ingresada", 1);
            }
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
            Principal.menuTitleLaberl.Text = "ASISTENCIA";
            TabPrincipal.SelectedTab = History;
            TabPrincipal.TabPages.Add(History);
            TabPrincipal.TabPages.Remove(Add);
            resetCamp(sender, e);
            Windows(History);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Show(History);
            Windows(History);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            string ayudaTexto = @"Ayuda: Uso de la Tabla de Asistencias

            La Tabla de Asistencias muestra información básica de los trabajadores, incluyendo la fecha de ingreso y la hora de llegada. No se muestra la hora de salida, ya que al momento de ingresar la asistencia, no se conoce con precisión a qué hora saldrá el trabajador.

            En la parte derecha de la Tabla de Asistencias, encontrarás tres botones:

            1. Agregar: Este botón te llevará a la pestaña de agregar asistencia, donde podrás ingresar los detalles de una nueva asistencia.

            2. Filtrar: Con este botón, puedes filtrar la tabla según trabajadores y meses del año. Utiliza este botón para visualizar solo la información que te interese.

            3. Eliminar: Para eliminar una asistencia, selecciona la fila correspondiente en la tabla y presiona este botón. Ten en cuenta que se mostrará una advertencia, ya que esta acción no se puede deshacer.

            Además, encontrarás la opción de Agregar Hora de Salida. Esta opción te permite ingresar la hora de salida para una fila seleccionada o editarla si ya ha sido ingresada.

            Recuerda que el formato de la hora de salida debe ser ingresado en el formato HH:MM (por ejemplo, 17:30 para las 5:30 PM).";



            help.TextoAyuda = ayudaTexto;
            help.StartPosition = FormStartPosition.CenterScreen;
            help.ShowDialog();
        }

        private void iconPictureBoxBTAdd_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            string ayudaTexto = @"Ayuda: Pestaña de Añadir Asistencia

            En esta pestaña, podrás añadir una nueva asistencia a la tabla. A continuación se explica cómo utilizarla:

            1. Visualiza la tabla de trabajadores existentes: La tabla muestra la lista de trabajadores disponibles. Debes seleccionar la fila correspondiente al trabajador para el cual deseas añadir la asistencia.

            2. Selecciona la fecha y hora de la asistencia: A la derecha de la tabla, encontrarás un calendario y un apartado para ingresar la fecha y hora de la asistencia. La hora debe estar en formato HH:MM (por ejemplo, 09:30 para las 9:30 AM).

            3. Guarda o cancela la asistencia: Al final de la pestaña, encontrarás las opciones de guardar y cancelar. Utiliza el botón de guardar para registrar la asistencia en la tabla. Si deseas cancelar y no guardar los cambios, utiliza el botón de cancelar.

            Recuerda que al guardar la asistencia, esta quedará registrada en la tabla para el trabajador seleccionado con la fecha y hora correspondiente.

            ¡Asegúrate de ingresar los datos correctamente antes de guardar la asistencia!
            ";
            help.TextoAyuda = ayudaTexto;
            help.StartPosition = FormStartPosition.CenterScreen;
            help.ShowDialog();
        }

        private void iconPictureBoxBTFilter_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            string ayudaTexto = @"Ayuda: Pestaña de Filtro

            En esta pestaña, puedes filtrar las asistencias según diferentes criterios. A continuación, se explica cómo utilizarla:

            1. Tabla de Asistencias: En la parte izquierda, encontrarás una tabla que muestra todas las asistencias registradas. Cada fila representa una asistencia con su respectivo trabajador, fecha y hora.

            2. Tabla de Meses: En la parte derecha, verás una tabla que muestra los meses del año. Si seleccionas un mes específico en esta tabla, la tabla de asistencias se actualizará y mostrará solo las asistencias registradas en ese mes.

            3. Filtrar por Trabajadores: Debajo de la tabla de asistencias, encontrarás un checkbox para filtrar por trabajadores. Si seleccionas este checkbox, la tabla de la derecha cambiará y mostrará todos los RUTs disponibles de los trabajadores. Al seleccionar un RUT específico en esta tabla, la tabla de asistencias se actualizará y mostrará todas las asistencias registradas para ese trabajador.

            Recuerda que la tabla de la izquierda muestra las asistencias, mientras que la tabla de la derecha se utiliza para filtrar por meses o trabajadores.

            Utiliza estas opciones de filtrado para visualizar las asistencias de acuerdo a tus necesidades y realizar un seguimiento más preciso de las asistencias registradas.
            ";
            help.TextoAyuda = ayudaTexto;
            help.StartPosition = FormStartPosition.CenterScreen;
            help.ShowDialog();
        }

        private void HelpBTHistory_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

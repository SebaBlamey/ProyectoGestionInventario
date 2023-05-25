using System;
using System.Windows.Forms;

namespace MiAplicacion
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Configuración de la ventana
            this.Text = "Mi Aplicación";
            this.Size = new System.Drawing.Size(400, 300);

            // Creación de los botones
            Button btnProductos = new Button();
            btnProductos.Text = "Productos";
            btnProductos.Size = new System.Drawing.Size(120, 30);
            btnProductos.Location = new System.Drawing.Point(140, 100);
            btnProductos.Click += btnProductos_Click;

            Button btnMateriales = new Button();
            btnMateriales.Text = "Materiales";
            btnMateriales.Size = new System.Drawing.Size(120, 30);
            btnMateriales.Location = new System.Drawing.Point(140, 150);
            btnMateriales.Click += btnMateriales_Click;

            Button btnAsistencia = new Button();
            btnAsistencia.Text = "Asistencia";
            btnAsistencia.Size = new System.Drawing.Size(120, 30);
            btnAsistencia.Location = new System.Drawing.Point(140, 200);
            btnAsistencia.Click += btnAsistencia_Click;

            Button btnHistorial = new Button();
            btnHistorial.Text = "Historial de producción";
            btnHistorial.Size = new System.Drawing.Size(120, 30);
            btnHistorial.Location = new System.Drawing.Point(140, 250);
            btnHistorial.Click += btnHistorial_Click;

            // Agregar los botones a la ventana
            this.Controls.Add(btnProductos);
            this.Controls.Add(btnMateriales);
            this.Controls.Add(btnAsistencia);
            this.Controls.Add(btnHistorial);
        }

        // Eventos de los botones
        private void btnProductos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Haz clic en el botón Productos");
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Haz clic en el botón Materiales");
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Haz clic en el botón Asistencia");
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Haz clic en el botón Historial de producción");
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

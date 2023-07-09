using aadea.Vistas;
using System.Runtime.InteropServices;
using System.Data.SQLite;

namespace aadea
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private void Login_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PIN_box.Text == "1234")
            {
                this.Hide();
                Principal principal = new Principal();
                principal.ShowDialog();

                Application.Exit();
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }
        }


        private void PIN_box_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PIN_box.ForeColor = Color.Black;
            }
            catch { }
        }

        private void PIN_box_Click(object sender, EventArgs e)
        {
            PIN_box.SelectAll();
            if (PIN_box.Text == "Ingrese PIN")
            {
                PIN_box.Text = "";
            }
            PIN_box.UseSystemPasswordChar = true;
        }

        private void PIN_box_MouseClick(object sender, MouseEventArgs e)
        {
            PIN_box.SelectAll();
            if (PIN_box.Text == "Ingrese PIN")
            {
                PIN_box.Text = "";
            }
            PIN_box.ForeColor = Color.Black;
            VerContrasena.Checked = false;
        }

        private void VerContrasena_CheckedChanged(object sender, EventArgs e)
        {
            if (VerContrasena.Checked == true)
            {
                PIN_box.UseSystemPasswordChar = false;
            }
            else
            {
                PIN_box.UseSystemPasswordChar = true;
            }
        }

        private Point mouseOffset;
        private bool isMouseDown;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
        [DllImport("user32.dll")]
        public static extern bool AnimateWindow(IntPtr hWnd, int dwTime, int dwFlags);

        private void iconButton1_Click(object sender, EventArgs e)
        {
            const int AW_SLIDE = 0x40000;
            const int AW_HOR_NEGATIVE = 0x1;
            const int AW_HIDE = 0x10000;
            const int AnimationDuration = 500; // Duración de la animación en milisegundos

            // Realizar animación de cierre deslizante hacia la izquierda
            AnimateWindow(this.Handle, AnimationDuration, AW_SLIDE | AW_HOR_NEGATIVE | AW_HIDE);

            // Esperar a que finalice la animación antes de cerrar la aplicación
            System.Threading.Thread.Sleep(AnimationDuration);
            Application.Exit();
        }
    }
}
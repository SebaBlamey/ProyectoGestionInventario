using aadea.Vistas;
using System.Runtime.InteropServices;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PIN_box.Text == "12345678")
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
            PIN_box.UseSystemPasswordChar = true;
        }

        private void PIN_box_MouseClick(object sender, MouseEventArgs e)
        {
            PIN_box.SelectAll();
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
    }
}
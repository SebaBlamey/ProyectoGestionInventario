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
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Holaa");
        }


        private void PIN_box_TextChanged(object sender, EventArgs e)
        {
            try
            {
                PIN_box.ForeColor = Color.White;
            }
            catch { }
        }

        private void PIN_box_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click");
            PIN_box.SelectAll();
        }

        private void PIN_box_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Click");
            PIN_box.SelectAll();
            PIN_box.ForeColor = Color.Black;
        }

        private void VerContrasena_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine(VerContrasena.Checked.ToString());
            Console.WriteLine("OFFFF");
            if (VerContrasena.Checked == true)
            {
                Console.WriteLine("OFF");
                PIN_box.UseSystemPasswordChar = false;
            }
            else
            {
                Console.WriteLine("ON");
                PIN_box.UseSystemPasswordChar = true;
            }
        }

        private void VerContrasena_Click(object sender, EventArgs e)
        {
        }
    }
}
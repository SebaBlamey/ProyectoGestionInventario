using System;
using System.Drawing;
using System.Windows.Forms;

namespace aadea.Vistas
{
    public partial class Notificaciones : Form
    {
        public Notificaciones()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Notificaciones
        /// </summary>
        /// <param name="Mensaje"></param>
        /// <param name="tipo">1 Succes. 2 Info. 3 Error</param>
        public Notificaciones(string Mensaje, int tipo)
        {
            InitializeComponent();
            //pcInfo.Visible = false;
            //pcSucc.Visible = false;
            //pictureBox3.Visible = false;
            label1.Text = Mensaje;
            switch (tipo)
            {
                case 3:
                    //pcSucc.Visible = true;
                    this.BackColor = Color.FromArgb(247, 168, 164);
                    label1.ForeColor = Color.FromArgb(112, 15, 35);
                    pToo.BackColor = Color.FromArgb(112, 15, 35);
                    break;
                case 1:
                    //pcInfo.Visible = true;
                    this.BackColor = Color.FromArgb(170, 243, 198);
                    label1.ForeColor = Color.FromArgb(25, 117, 68);
                    pToo.BackColor = Color.FromArgb(25, 117, 68);
                    break;
                case 2:
                    //pictureBox3.Visible = true;
                    this.BackColor = Color.FromArgb(236, 236, 236);
                    label1.ForeColor = Color.FromArgb(101, 101, 101);
                    pToo.BackColor = Color.FromArgb(101, 101, 101);
                    break;
            }
        }
        private int conteo;
        private void timer1_Tick(object sender, EventArgs e)
        {
            conteo++;
            if (conteo == 20)
            {
                this.Close();
            }
        }

        private void Notificaciones_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Notificaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

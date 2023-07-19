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

        public Notificaciones(string Mensaje, Color color, int tipo)
        {
            InitializeComponent();

            label1.Text = Mensaje;
            label1.ForeColor = color;
            pToo.BackColor = color;
            if (tipo == 1)
            {
                pcInfo.Visible=false;
                pcSucc.Visible=true;
                pictureBox3.Visible=false;
            }
            else if (tipo == 2)
            {
                pcInfo.Visible=true;
                pcSucc.Visible=false;
                pictureBox3.Visible=false;
            }
            else if (tipo == 3)
            {
                pcInfo.Visible=false;
                pcSucc.Visible=false;
                pictureBox3.Visible=true;
            }
        }
        private int conteo;
        private void timer1_Tick(object sender, EventArgs e)
        {
            conteo++;
            if (conteo==20)
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
            timer1.Enabled=false;
        }
    }
}

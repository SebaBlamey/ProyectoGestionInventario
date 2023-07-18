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
    public partial class Help : Form
    {
        public string TextoAyuda { get; set; }

        public Help()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            // Mostrar el texto de ayuda en la etiqueta
            textBoxAyuda.Text = TextoAyuda;
            textBoxAyuda.Select(0, 0); // Establece la selección inicial en el inicio del TextBox
            textBoxAyuda.ScrollToCaret();
            textBoxAyuda.HideSelection = false;
        }


    }
}

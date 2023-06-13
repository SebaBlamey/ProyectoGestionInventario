using aadea.Logicaq;
using aadea.userControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace aadea.Vistas
{
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
            Load += FormProduccion_Load;

        }

        private void FormProduccion_Load(object? sender, EventArgs e)
        {
            L_inventario l_Inventario = new L_inventario();
            DataTable dataTable = l_Inventario.listProducts();
            foreach (DataRow row in dataTable.Rows)
            {
                productBodega userControl = new productBodega();

                int id = Convert.ToInt32(row["ID"]);
                string nombre = row["nombre"].ToString();
                byte[] imagen = DBNull.Value.Equals(row["imagen"]) ? null : (byte[])row["imagen"];


                userControl.Tittle = nombre;
                if (imagen != null && imagen.Length > 0)
                {

                    using (MemoryStream ms = new MemoryStream(imagen))
                    {
                        System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                        userControl.PictureBox1 = img;
                    }
                }
                flowLayoutPanel1.Controls.Add(userControl);
                L_bodega l_Bodega = new L_bodega();
                DataTable list = l_Bodega.listInventarioporID(id);
                userControl.DataGridView1.DataSource = list;
            }


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

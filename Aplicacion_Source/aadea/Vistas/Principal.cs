﻿using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using System.Data.SQLite;
using System.Data;
using System.Configuration;

namespace aadea.Vistas
{
    public partial class Principal : Form
    {
        private SQLiteConnection connection;
        private static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        public Principal()
        {
            InitializeComponent();
            connection = new SQLiteConnection(cadena);
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

        private void Principal_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        #region Mover Ventana
        private Point mouseOffset;
        private bool isMouseDown;

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }
        #endregion Mover Ventana

        private IconButton currentBtn;
        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                DisableButton();
                currentBtn = (IconButton)sender;
                currentBtn.BackColor = Color.FromArgb(138, 106, 61);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                pictureBox1.Hide();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(85, 59, 16);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void iconButtonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();

            Application.Exit();
        }
        private IconButton? actualButton;
        private void SetActualButton(object sender, string text)
        {
            if (sender != null)
            {
                UnsetActualButton();
                actualButton = (IconButton?)sender;
                menuTitleLaberl.Text = text;
                menuTitleLaberl.ForeColor = Color.FromArgb(111, 82, 38);
                menuTitleLaberl.TextAlign = ContentAlignment.MiddleCenter;
                dataGridView1.DataSource = null;
            }
        }
        private void UnsetActualButton()
        {
            actualButton = null;
        }

        private void iconButtonProductos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            try
            {
                SetActualButton(sender, "PRODUCTOS");
                connection.Open();
                string query = "SELECT * FROM producto";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                dataGridView1.ForeColor = Color.White;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos " + ex.Message);
            }
        }

        private void iconButtonMateriales_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ActivateButton(sender);
            try
            {
                SetActualButton(sender, "MATERIALES");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos " + ex.Message);
            }
        }

        private void iconButtonProduccion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            try
            {
                SetActualButton(sender, "PRODUCCION");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos " + ex.Message);
            }
        }

        private void iconButtonTrabajadores_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ActivateButton(sender);
            try
            {
                SetActualButton(sender, "TRABAJADORES");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos " + ex.Message);
            }
        }

        private void iconButtonAsistencia_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ActivateButton(sender);
            try
            {
                SetActualButton(sender, "ASISTENCIA");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la base de datos " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

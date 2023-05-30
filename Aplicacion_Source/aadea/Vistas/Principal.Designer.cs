using System.Data.SQLite;

namespace aadea.Vistas
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            iconButtonSalir = new FontAwesome.Sharp.IconButton();
            iconButtonAsistencia = new FontAwesome.Sharp.IconButton();
            iconButtonTrabajadores = new FontAwesome.Sharp.IconButton();
            iconButtonProductos = new FontAwesome.Sharp.IconButton();
            iconButtonProduccion = new FontAwesome.Sharp.IconButton();
            iconButtonMateriales = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(85, 59, 16);
            panel1.Controls.Add(iconButtonSalir);
            panel1.Controls.Add(iconButtonAsistencia);
            panel1.Controls.Add(iconButtonTrabajadores);
            panel1.Controls.Add(iconButtonProductos);
            panel1.Controls.Add(iconButtonProduccion);
            panel1.Controls.Add(iconButtonMateriales);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 696);
            panel1.TabIndex = 0;
            // 
            // iconButtonSalir
            // 
            iconButtonSalir.FlatAppearance.BorderSize = 0;
            iconButtonSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 106, 61);
            iconButtonSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(111, 82, 38);
            iconButtonSalir.FlatStyle = FlatStyle.Flat;
            iconButtonSalir.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonSalir.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            iconButtonSalir.IconColor = Color.White;
            iconButtonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSalir.IconSize = 35;
            iconButtonSalir.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonSalir.Location = new Point(0, 633);
            iconButtonSalir.Margin = new Padding(3, 4, 6, 4);
            iconButtonSalir.Name = "iconButtonSalir";
            iconButtonSalir.Padding = new Padding(6, 0, 0, 0);
            iconButtonSalir.Size = new Size(249, 63);
            iconButtonSalir.TabIndex = 16;
            iconButtonSalir.Text = "Salir";
            iconButtonSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonSalir.UseVisualStyleBackColor = true;
            iconButtonSalir.Click += iconButtonSalir_Click;
            // 
            // iconButtonAsistencia
            // 
            iconButtonAsistencia.FlatAppearance.BorderSize = 0;
            iconButtonAsistencia.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 106, 61);
            iconButtonAsistencia.FlatAppearance.MouseOverBackColor = Color.FromArgb(111, 82, 38);
            iconButtonAsistencia.FlatStyle = FlatStyle.Flat;
            iconButtonAsistencia.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonAsistencia.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            iconButtonAsistencia.IconColor = Color.White;
            iconButtonAsistencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonAsistencia.IconSize = 35;
            iconButtonAsistencia.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonAsistencia.Location = new Point(0, 459);
            iconButtonAsistencia.Margin = new Padding(3, 4, 6, 4);
            iconButtonAsistencia.Name = "iconButtonAsistencia";
            iconButtonAsistencia.Padding = new Padding(6, 0, 0, 0);
            iconButtonAsistencia.Size = new Size(249, 63);
            iconButtonAsistencia.TabIndex = 15;
            iconButtonAsistencia.Text = "Asistencia";
            iconButtonAsistencia.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonAsistencia.UseVisualStyleBackColor = true;
            iconButtonAsistencia.Click += iconButtonAsistencia_Click;
            // 
            // iconButtonTrabajadores
            // 
            iconButtonTrabajadores.FlatAppearance.BorderSize = 0;
            iconButtonTrabajadores.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 106, 61);
            iconButtonTrabajadores.FlatAppearance.MouseOverBackColor = Color.FromArgb(111, 82, 38);
            iconButtonTrabajadores.FlatStyle = FlatStyle.Flat;
            iconButtonTrabajadores.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonTrabajadores.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconButtonTrabajadores.IconColor = Color.White;
            iconButtonTrabajadores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonTrabajadores.IconSize = 35;
            iconButtonTrabajadores.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonTrabajadores.Location = new Point(0, 388);
            iconButtonTrabajadores.Margin = new Padding(3, 4, 6, 4);
            iconButtonTrabajadores.Name = "iconButtonTrabajadores";
            iconButtonTrabajadores.Padding = new Padding(6, 0, 0, 0);
            iconButtonTrabajadores.Size = new Size(249, 63);
            iconButtonTrabajadores.TabIndex = 14;
            iconButtonTrabajadores.Text = "Trabajadores";
            iconButtonTrabajadores.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonTrabajadores.UseVisualStyleBackColor = true;
            iconButtonTrabajadores.Click += iconButtonTrabajadores_Click;
            // 
            // iconButtonProductos
            // 
            iconButtonProductos.FlatAppearance.BorderSize = 0;
            iconButtonProductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 106, 61);
            iconButtonProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(111, 82, 38);
            iconButtonProductos.FlatStyle = FlatStyle.Flat;
            iconButtonProductos.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonProductos.IconChar = FontAwesome.Sharp.IconChar.BowlFood;
            iconButtonProductos.IconColor = Color.White;
            iconButtonProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonProductos.IconSize = 35;
            iconButtonProductos.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonProductos.Location = new Point(0, 176);
            iconButtonProductos.Margin = new Padding(3, 4, 3, 4);
            iconButtonProductos.Name = "iconButtonProductos";
            iconButtonProductos.Padding = new Padding(6, 0, 6, 0);
            iconButtonProductos.Size = new Size(249, 63);
            iconButtonProductos.TabIndex = 13;
            iconButtonProductos.Text = "Productos";
            iconButtonProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonProductos.UseVisualStyleBackColor = true;
            iconButtonProductos.Click += iconButtonProductos_Click;
            // 
            // iconButtonProduccion
            // 
            iconButtonProduccion.FlatAppearance.BorderSize = 0;
            iconButtonProduccion.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 106, 61);
            iconButtonProduccion.FlatAppearance.MouseOverBackColor = Color.FromArgb(111, 82, 38);
            iconButtonProduccion.FlatStyle = FlatStyle.Flat;
            iconButtonProduccion.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonProduccion.IconChar = FontAwesome.Sharp.IconChar.Building;
            iconButtonProduccion.IconColor = Color.White;
            iconButtonProduccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonProduccion.IconSize = 35;
            iconButtonProduccion.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonProduccion.Location = new Point(0, 317);
            iconButtonProduccion.Margin = new Padding(3, 4, 3, 4);
            iconButtonProduccion.Name = "iconButtonProduccion";
            iconButtonProduccion.Padding = new Padding(6, 0, 0, 0);
            iconButtonProduccion.Size = new Size(249, 63);
            iconButtonProduccion.TabIndex = 12;
            iconButtonProduccion.Text = "Produccion";
            iconButtonProduccion.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonProduccion.UseVisualStyleBackColor = true;
            iconButtonProduccion.Click += iconButtonProduccion_Click;
            // 
            // iconButtonMateriales
            // 
            iconButtonMateriales.FlatAppearance.BorderSize = 0;
            iconButtonMateriales.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 106, 61);
            iconButtonMateriales.FlatAppearance.MouseOverBackColor = Color.FromArgb(111, 82, 38);
            iconButtonMateriales.FlatStyle = FlatStyle.Flat;
            iconButtonMateriales.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonMateriales.IconChar = FontAwesome.Sharp.IconChar.KitchenSet;
            iconButtonMateriales.IconColor = Color.White;
            iconButtonMateriales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonMateriales.IconSize = 35;
            iconButtonMateriales.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonMateriales.Location = new Point(0, 247);
            iconButtonMateriales.Margin = new Padding(3, 4, 3, 4);
            iconButtonMateriales.Name = "iconButtonMateriales";
            iconButtonMateriales.Padding = new Padding(6, 0, 0, 0);
            iconButtonMateriales.Size = new Size(249, 63);
            iconButtonMateriales.TabIndex = 11;
            iconButtonMateriales.Text = "Materiales";
            iconButtonMateriales.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonMateriales.UseVisualStyleBackColor = true;
            iconButtonMateriales.Click += iconButtonMateriales_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(249, 696);
            panel3.TabIndex = 6;
            panel3.MouseDown += panel3_MouseDown;
            panel3.MouseMove += panel3_MouseMove;
            panel3.MouseUp += panel3_MouseUp;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resource.logo3;
            pictureBox2.Location = new Point(15, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(219, 199);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(249, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(808, 83);
            panel2.TabIndex = 1;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            panel2.MouseUp += panel2_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resource.nube;
            pictureBox1.Location = new Point(354, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1082, 1001);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(354, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(676, 399);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1057, 696);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Load += Principal_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButtonProduccion;
        private FontAwesome.Sharp.IconButton iconButtonMateriales;
        private FontAwesome.Sharp.IconButton iconButtonAsistencia;
        private FontAwesome.Sharp.IconButton iconButtonTrabajadores;
        private FontAwesome.Sharp.IconButton iconButtonProductos;
        private FontAwesome.Sharp.IconButton iconButtonSalir;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
    }
}
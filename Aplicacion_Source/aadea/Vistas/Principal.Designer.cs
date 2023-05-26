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
            panel3 = new Panel();
            btn_asistencia = new Button();
            btn_trabajadores = new Button();
            btn_produccion = new Button();
            btn_productos = new Button();
            btn_materiales = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(85, 59, 16);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btn_asistencia);
            panel1.Controls.Add(btn_trabajadores);
            panel1.Controls.Add(btn_produccion);
            panel1.Controls.Add(btn_productos);
            panel1.Controls.Add(btn_materiales);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 522);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(218, 59);
            panel3.TabIndex = 6;
            panel3.MouseDown += panel3_MouseDown;
            panel3.MouseMove += panel3_MouseMove;
            panel3.MouseUp += panel3_MouseUp;
            // 
            // btn_asistencia
            // 
            btn_asistencia.FlatAppearance.BorderSize = 0;
            btn_asistencia.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 106, 61);
            btn_asistencia.FlatAppearance.MouseOverBackColor = Color.FromArgb(111, 82, 38);
            btn_asistencia.FlatStyle = FlatStyle.Flat;
            btn_asistencia.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_asistencia.ForeColor = Color.White;
            btn_asistencia.Location = new Point(0, 351);
            btn_asistencia.Name = "btn_asistencia";
            btn_asistencia.Padding = new Padding(20, 0, 0, 0);
            btn_asistencia.Size = new Size(218, 52);
            btn_asistencia.TabIndex = 10;
            btn_asistencia.Text = "Asistencia";
            btn_asistencia.TextAlign = ContentAlignment.MiddleLeft;
            btn_asistencia.UseVisualStyleBackColor = true;
            // 
            // btn_trabajadores
            // 
            btn_trabajadores.FlatAppearance.BorderSize = 0;
            btn_trabajadores.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 106, 61);
            btn_trabajadores.FlatAppearance.MouseOverBackColor = Color.FromArgb(111, 82, 38);
            btn_trabajadores.FlatStyle = FlatStyle.Flat;
            btn_trabajadores.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_trabajadores.ForeColor = Color.White;
            btn_trabajadores.Location = new Point(0, 293);
            btn_trabajadores.Name = "btn_trabajadores";
            btn_trabajadores.Padding = new Padding(20, 0, 0, 0);
            btn_trabajadores.Size = new Size(218, 52);
            btn_trabajadores.TabIndex = 9;
            btn_trabajadores.Text = "Trabajadores";
            btn_trabajadores.TextAlign = ContentAlignment.MiddleLeft;
            btn_trabajadores.UseVisualStyleBackColor = true;
            // 
            // btn_produccion
            // 
            btn_produccion.FlatAppearance.BorderSize = 0;
            btn_produccion.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 106, 61);
            btn_produccion.FlatAppearance.MouseOverBackColor = Color.FromArgb(111, 82, 38);
            btn_produccion.FlatStyle = FlatStyle.Flat;
            btn_produccion.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_produccion.ForeColor = Color.White;
            btn_produccion.Location = new Point(0, 235);
            btn_produccion.Name = "btn_produccion";
            btn_produccion.Padding = new Padding(20, 0, 0, 0);
            btn_produccion.Size = new Size(218, 52);
            btn_produccion.TabIndex = 8;
            btn_produccion.Text = "Producción";
            btn_produccion.TextAlign = ContentAlignment.MiddleLeft;
            btn_produccion.UseVisualStyleBackColor = true;
            // 
            // btn_productos
            // 
            btn_productos.FlatAppearance.BorderSize = 0;
            btn_productos.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 106, 61);
            btn_productos.FlatAppearance.MouseOverBackColor = Color.FromArgb(111, 82, 38);
            btn_productos.FlatStyle = FlatStyle.Flat;
            btn_productos.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_productos.ForeColor = Color.White;
            btn_productos.Location = new Point(0, 177);
            btn_productos.Name = "btn_productos";
            btn_productos.Padding = new Padding(20, 0, 0, 0);
            btn_productos.Size = new Size(218, 52);
            btn_productos.TabIndex = 7;
            btn_productos.Text = "Productos";
            btn_productos.TextAlign = ContentAlignment.MiddleLeft;
            btn_productos.UseVisualStyleBackColor = true;
            // 
            // btn_materiales
            // 
            btn_materiales.FlatAppearance.BorderSize = 0;
            btn_materiales.FlatAppearance.MouseDownBackColor = Color.FromArgb(138, 106, 61);
            btn_materiales.FlatAppearance.MouseOverBackColor = Color.FromArgb(111, 82, 38);
            btn_materiales.FlatStyle = FlatStyle.Flat;
            btn_materiales.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_materiales.ForeColor = Color.White;
            btn_materiales.Location = new Point(0, 119);
            btn_materiales.Name = "btn_materiales";
            btn_materiales.Padding = new Padding(20, 0, 0, 0);
            btn_materiales.Size = new Size(218, 52);
            btn_materiales.TabIndex = 3;
            btn_materiales.Text = "Materiales";
            btn_materiales.TextAlign = ContentAlignment.MiddleLeft;
            btn_materiales.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(218, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(707, 62);
            panel2.TabIndex = 1;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            panel2.MouseUp += panel2_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resource.nube;
            pictureBox1.Location = new Point(202, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1110, 905);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(925, 522);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Load += Principal_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button btn_materiales;
        private Button btn_asistencia;
        private Button btn_trabajadores;
        private Button btn_produccion;
        private Button btn_productos;
    }
}
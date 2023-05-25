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
            label_asistencia = new Label();
            label_trabajadores = new Label();
            label_producction = new Label();
            label_productos = new Label();
            label_materiales = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(85, 59, 16);
            panel1.Controls.Add(label_asistencia);
            panel1.Controls.Add(label_trabajadores);
            panel1.Controls.Add(label_producction);
            panel1.Controls.Add(label_productos);
            panel1.Controls.Add(label_materiales);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 450);
            panel1.TabIndex = 0;
            // 
            // label_asistencia
            // 
            label_asistencia.AutoSize = true;
            label_asistencia.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_asistencia.Location = new Point(12, 309);
            label_asistencia.Name = "label_asistencia";
            label_asistencia.Size = new Size(138, 34);
            label_asistencia.TabIndex = 5;
            label_asistencia.Text = "Asistencia";
            // 
            // label_trabajadores
            // 
            label_trabajadores.AutoSize = true;
            label_trabajadores.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_trabajadores.Location = new Point(12, 259);
            label_trabajadores.Name = "label_trabajadores";
            label_trabajadores.Size = new Size(177, 34);
            label_trabajadores.TabIndex = 4;
            label_trabajadores.Text = "Trabajadores";
            label_trabajadores.Click += label1_Click;
            // 
            // label_producction
            // 
            label_producction.AutoSize = true;
            label_producction.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_producction.Location = new Point(12, 209);
            label_producction.Name = "label_producction";
            label_producction.Size = new Size(149, 34);
            label_producction.TabIndex = 2;
            label_producction.Text = "Producción";
            // 
            // label_productos
            // 
            label_productos.AutoSize = true;
            label_productos.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_productos.Location = new Point(12, 156);
            label_productos.Name = "label_productos";
            label_productos.Size = new Size(136, 34);
            label_productos.TabIndex = 3;
            label_productos.Text = "Productos";
            // 
            // label_materiales
            // 
            label_materiales.AutoSize = true;
            label_materiales.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_materiales.Location = new Point(12, 106);
            label_materiales.Name = "label_materiales";
            label_materiales.Size = new Size(141, 34);
            label_materiales.TabIndex = 2;
            label_materiales.Text = "Materiales";
            label_materiales.MouseHover += label_materiales_MouseHover;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(249, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(551, 39);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resource.nube;
            pictureBox1.Location = new Point(326, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 600);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Principal";
            Text = "Principal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label_materiales;
        private Label label_producction;
        private Label label_productos;
        private Label label_trabajadores;
        private Label label_asistencia;
        private PictureBox pictureBox1;
    }
}
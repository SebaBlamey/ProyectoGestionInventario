﻿using System.Data.SQLite;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            menuTitleLaberl = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 522);
            panel1.TabIndex = 0;
            // 
            // iconButtonSalir
            // 
            iconButtonSalir.BackColor = Color.FromArgb(33, 36, 53);
            iconButtonSalir.FlatAppearance.BorderSize = 0;
            iconButtonSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 104, 255);
            iconButtonSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(123, 72, 154);
            iconButtonSalir.FlatStyle = FlatStyle.Flat;
            iconButtonSalir.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonSalir.ForeColor = Color.FromArgb(144, 147, 166);
            iconButtonSalir.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            iconButtonSalir.IconColor = Color.FromArgb(144, 147, 166);
            iconButtonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSalir.IconSize = 35;
            iconButtonSalir.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonSalir.Location = new Point(0, 475);
            iconButtonSalir.Margin = new Padding(3, 3, 5, 3);
            iconButtonSalir.Name = "iconButtonSalir";
            iconButtonSalir.Padding = new Padding(5, 0, 0, 0);
            iconButtonSalir.Size = new Size(218, 47);
            iconButtonSalir.TabIndex = 16;
            iconButtonSalir.Text = "Salir";
            iconButtonSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonSalir.UseVisualStyleBackColor = false;
            iconButtonSalir.Click += iconButtonSalir_Click;
            // 
            // iconButtonAsistencia
            // 
            iconButtonAsistencia.BackColor = Color.FromArgb(33, 36, 53);
            iconButtonAsistencia.FlatAppearance.BorderSize = 0;
            iconButtonAsistencia.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 104, 255);
            iconButtonAsistencia.FlatAppearance.MouseOverBackColor = Color.FromArgb(123, 72, 154);
            iconButtonAsistencia.FlatStyle = FlatStyle.Flat;
            iconButtonAsistencia.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonAsistencia.ForeColor = Color.FromArgb(144, 147, 166);
            iconButtonAsistencia.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            iconButtonAsistencia.IconColor = Color.FromArgb(144, 147, 166);
            iconButtonAsistencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonAsistencia.IconSize = 35;
            iconButtonAsistencia.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonAsistencia.Location = new Point(0, 344);
            iconButtonAsistencia.Margin = new Padding(3, 3, 5, 3);
            iconButtonAsistencia.Name = "iconButtonAsistencia";
            iconButtonAsistencia.Padding = new Padding(5, 0, 0, 0);
            iconButtonAsistencia.Size = new Size(218, 47);
            iconButtonAsistencia.TabIndex = 15;
            iconButtonAsistencia.Text = "Asistencia";
            iconButtonAsistencia.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonAsistencia.UseVisualStyleBackColor = false;
            iconButtonAsistencia.Click += iconButtonAsistencia_Click;
            // 
            // iconButtonTrabajadores
            // 
            iconButtonTrabajadores.BackColor = Color.FromArgb(33, 36, 53);
            iconButtonTrabajadores.FlatAppearance.BorderSize = 0;
            iconButtonTrabajadores.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 104, 255);
            iconButtonTrabajadores.FlatAppearance.MouseOverBackColor = Color.FromArgb(123, 72, 154);
            iconButtonTrabajadores.FlatStyle = FlatStyle.Flat;
            iconButtonTrabajadores.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonTrabajadores.ForeColor = Color.FromArgb(144, 147, 166);
            iconButtonTrabajadores.IconChar = FontAwesome.Sharp.IconChar.Users;
            iconButtonTrabajadores.IconColor = Color.FromArgb(144, 147, 166);
            iconButtonTrabajadores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonTrabajadores.IconSize = 35;
            iconButtonTrabajadores.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonTrabajadores.Location = new Point(0, 291);
            iconButtonTrabajadores.Margin = new Padding(3, 3, 5, 3);
            iconButtonTrabajadores.Name = "iconButtonTrabajadores";
            iconButtonTrabajadores.Padding = new Padding(5, 0, 0, 0);
            iconButtonTrabajadores.Size = new Size(218, 47);
            iconButtonTrabajadores.TabIndex = 14;
            iconButtonTrabajadores.Text = "Trabajadores";
            iconButtonTrabajadores.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonTrabajadores.UseVisualStyleBackColor = false;
            iconButtonTrabajadores.Click += iconButtonTrabajadores_Click;
            // 
            // iconButtonProductos
            // 
            iconButtonProductos.BackColor = Color.FromArgb(33, 36, 53);
            iconButtonProductos.FlatAppearance.BorderSize = 0;
            iconButtonProductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 104, 255);
            iconButtonProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(123, 72, 154);
            iconButtonProductos.FlatStyle = FlatStyle.Flat;
            iconButtonProductos.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonProductos.ForeColor = Color.FromArgb(144, 147, 166);
            iconButtonProductos.IconChar = FontAwesome.Sharp.IconChar.BowlFood;
            iconButtonProductos.IconColor = Color.FromArgb(144, 147, 166);
            iconButtonProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonProductos.IconSize = 35;
            iconButtonProductos.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonProductos.Location = new Point(0, 132);
            iconButtonProductos.Name = "iconButtonProductos";
            iconButtonProductos.Padding = new Padding(5, 0, 5, 0);
            iconButtonProductos.Size = new Size(218, 47);
            iconButtonProductos.TabIndex = 13;
            iconButtonProductos.Text = "Productos";
            iconButtonProductos.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonProductos.UseVisualStyleBackColor = false;
            iconButtonProductos.Click += iconButtonProductos_Click;
            // 
            // iconButtonProduccion
            // 
            iconButtonProduccion.BackColor = Color.FromArgb(33, 36, 53);
            iconButtonProduccion.FlatAppearance.BorderSize = 0;
            iconButtonProduccion.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 104, 255);
            iconButtonProduccion.FlatAppearance.MouseOverBackColor = Color.FromArgb(123, 72, 154);
            iconButtonProduccion.FlatStyle = FlatStyle.Flat;
            iconButtonProduccion.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonProduccion.ForeColor = Color.FromArgb(144, 147, 166);
            iconButtonProduccion.IconChar = FontAwesome.Sharp.IconChar.Building;
            iconButtonProduccion.IconColor = Color.FromArgb(144, 147, 166);
            iconButtonProduccion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonProduccion.IconSize = 35;
            iconButtonProduccion.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonProduccion.Location = new Point(0, 238);
            iconButtonProduccion.Name = "iconButtonProduccion";
            iconButtonProduccion.Padding = new Padding(5, 0, 0, 0);
            iconButtonProduccion.Size = new Size(218, 47);
            iconButtonProduccion.TabIndex = 12;
            iconButtonProduccion.Text = "Produccion";
            iconButtonProduccion.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonProduccion.UseVisualStyleBackColor = false;
            iconButtonProduccion.Click += iconButtonProduccion_Click;
            // 
            // iconButtonMateriales
            // 
            iconButtonMateriales.BackColor = Color.FromArgb(33, 36, 53);
            iconButtonMateriales.FlatAppearance.BorderSize = 0;
            iconButtonMateriales.FlatAppearance.MouseDownBackColor = Color.FromArgb(212, 104, 255);
            iconButtonMateriales.FlatAppearance.MouseOverBackColor = Color.FromArgb(123, 72, 154);
            iconButtonMateriales.FlatStyle = FlatStyle.Flat;
            iconButtonMateriales.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonMateriales.ForeColor = Color.FromArgb(144, 147, 166);
            iconButtonMateriales.IconChar = FontAwesome.Sharp.IconChar.KitchenSet;
            iconButtonMateriales.IconColor = Color.FromArgb(144, 147, 166);
            iconButtonMateriales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonMateriales.IconSize = 35;
            iconButtonMateriales.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonMateriales.Location = new Point(0, 185);
            iconButtonMateriales.Name = "iconButtonMateriales";
            iconButtonMateriales.Padding = new Padding(5, 0, 0, 0);
            iconButtonMateriales.Size = new Size(218, 47);
            iconButtonMateriales.TabIndex = 11;
            iconButtonMateriales.Text = "Materiales";
            iconButtonMateriales.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonMateriales.UseVisualStyleBackColor = false;
            iconButtonMateriales.Click += iconButtonMateriales_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(33, 36, 53);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(218, 522);
            panel3.TabIndex = 6;
            panel3.MouseDown += panel3_MouseDown;
            panel3.MouseMove += panel3_MouseMove;
            panel3.MouseUp += panel3_MouseUp;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resource.logo3;
            pictureBox2.Location = new Point(13, 0);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(192, 149);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(menuTitleLaberl);
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
            // menuTitleLaberl
            // 
            menuTitleLaberl.AutoSize = true;
            menuTitleLaberl.Font = new Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuTitleLaberl.ImageAlign = ContentAlignment.TopCenter;
            menuTitleLaberl.Location = new Point(290, 10);
            menuTitleLaberl.Name = "menuTitleLaberl";
            menuTitleLaberl.Size = new Size(0, 42);
            menuTitleLaberl.TabIndex = 0;
            menuTitleLaberl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.BurlyWood;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(138, 106, 61);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(218, 66);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.BurlyWood;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(138, 106, 61);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(707, 456);
            dataGridView1.TabIndex = 3;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(925, 522);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            Load += Principal_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButtonProduccion;
        private FontAwesome.Sharp.IconButton iconButtonMateriales;
        private FontAwesome.Sharp.IconButton iconButtonAsistencia;
        private FontAwesome.Sharp.IconButton iconButtonTrabajadores;
        private FontAwesome.Sharp.IconButton iconButtonProductos;
        private FontAwesome.Sharp.IconButton iconButtonSalir;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private Label menuTitleLaberl;
    }
}
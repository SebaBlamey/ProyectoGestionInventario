﻿namespace aadea.userControls
{
    partial class UserProduct
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            picProducto = new PictureBox();
            lblTittle = new Label();
            lblDescripcion = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            delete_iconButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)picProducto).BeginInit();
            SuspendLayout();
            // 
            // picProducto
            // 
            picProducto.Location = new Point(12, 46);
            picProducto.Name = "picProducto";
            picProducto.Size = new Size(125, 124);
            picProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            picProducto.TabIndex = 0;
            picProducto.TabStop = false;
            // 
            // lblTittle
            // 
            lblTittle.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTittle.ImageAlign = ContentAlignment.MiddleLeft;
            lblTittle.Location = new Point(0, 12);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(549, 31);
            lblTittle.TabIndex = 1;
            lblTittle.Text = "label1";
            lblTittle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescripcion.Location = new Point(143, 74);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(270, 70);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "label1";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(121, 160, 191);
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatAppearance.BorderColor = Color.FromArgb(81, 120, 151);
            iconButton1.FlatAppearance.BorderSize = 2;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(81, 120, 151);
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(101, 140, 171);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = SystemColors.Control;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PaintBrush;
            iconButton1.IconColor = SystemColors.Control;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 28;
            iconButton1.Location = new Point(419, 74);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(118, 33);
            iconButton1.TabIndex = 5;
            iconButton1.Text = "Modificar";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // delete_iconButton
            // 
            delete_iconButton.BackColor = Color.FromArgb(204, 102, 102);
            delete_iconButton.Cursor = Cursors.Hand;
            delete_iconButton.FlatAppearance.BorderColor = Color.FromArgb(154, 52, 52);
            delete_iconButton.FlatAppearance.BorderSize = 2;
            delete_iconButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(154, 52, 52);
            delete_iconButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(164, 62, 62);
            delete_iconButton.FlatStyle = FlatStyle.Flat;
            delete_iconButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            delete_iconButton.ForeColor = SystemColors.Control;
            delete_iconButton.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            delete_iconButton.IconColor = SystemColors.Control;
            delete_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            delete_iconButton.IconSize = 28;
            delete_iconButton.Location = new Point(419, 111);
            delete_iconButton.Name = "delete_iconButton";
            delete_iconButton.Size = new Size(118, 33);
            delete_iconButton.TabIndex = 6;
            delete_iconButton.Text = "Eliminar";
            delete_iconButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            delete_iconButton.UseVisualStyleBackColor = false;
            delete_iconButton.Click += iconButton_Click;
            // 
            // UserProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(155, 164, 181);
            Controls.Add(delete_iconButton);
            Controls.Add(iconButton1);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTittle);
            Controls.Add(picProducto);
            Name = "UserProduct";
            Size = new Size(549, 188);
            ((System.ComponentModel.ISupportInitialize)picProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picProducto;
        private Label lblTittle;
        private Label lblDescripcion;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton delete_iconButton;
    }
}

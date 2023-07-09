namespace aadea.userControls
{
    partial class UserMaterial
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
            label1 = new Label();
            lblCantidad = new Label();
            nametxt = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            lblCantidada = new Label();
            delete_iconButton = new FontAwesome.Sharp.IconButton();
            modify_iconButton = new FontAwesome.Sharp.IconButton();
            lblUnidad = new Label();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(134, 74);
            label1.Name = "label1";
            label1.Size = new Size(57, 18);
            label1.TabIndex = 2;
            label1.Text = "Stock:";
            // 
            // lblCantidad
            // 
            lblCantidad.Location = new Point(212, 120);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(100, 23);
            lblCantidad.TabIndex = 9;
            // 
            // nametxt
            // 
            nametxt.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            nametxt.ForeColor = Color.Black;
            nametxt.Location = new Point(3, 12);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(125, 31);
            nametxt.TabIndex = 7;
            nametxt.Text = "label2";
            nametxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 124;
            iconPictureBox1.Location = new Point(3, 46);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(125, 124);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            iconPictureBox1.TabIndex = 8;
            iconPictureBox1.TabStop = false;
            // 
            // lblCantidada
            // 
            lblCantidada.AutoSize = true;
            lblCantidada.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidada.Location = new Point(197, 74);
            lblCantidada.Name = "lblCantidada";
            lblCantidada.Size = new Size(46, 18);
            lblCantidada.TabIndex = 10;
            lblCantidada.Text = "label2";
            lblCantidada.TextAlign = ContentAlignment.MiddleLeft;
            lblCantidada.Click += lblCantidada_Click;
            // 
            // delete_iconButton
            // 
            delete_iconButton.BackColor = Color.Red;
            delete_iconButton.Cursor = Cursors.Hand;
            delete_iconButton.FlatAppearance.BorderColor = Color.FromArgb(204, 0, 0);
            delete_iconButton.FlatAppearance.BorderSize = 2;
            delete_iconButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(204, 0, 0);
            delete_iconButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 0, 0);
            delete_iconButton.FlatStyle = FlatStyle.Flat;
            delete_iconButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            delete_iconButton.ForeColor = SystemColors.Control;
            delete_iconButton.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            delete_iconButton.IconColor = SystemColors.Control;
            delete_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            delete_iconButton.IconSize = 28;
            delete_iconButton.Location = new Point(438, 111);
            delete_iconButton.Name = "delete_iconButton";
            delete_iconButton.Size = new Size(106, 33);
            delete_iconButton.TabIndex = 12;
            delete_iconButton.Text = "Eliminar";
            delete_iconButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            delete_iconButton.UseVisualStyleBackColor = false;
            delete_iconButton.Click += delete_iconButton_Click;
            // 
            // modify_iconButton
            // 
            modify_iconButton.BackColor = Color.FromArgb(53, 152, 220);
            modify_iconButton.FlatAppearance.BorderColor = Color.FromArgb(12, 98, 155);
            modify_iconButton.FlatAppearance.BorderSize = 2;
            modify_iconButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 98, 155);
            modify_iconButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 128, 185);
            modify_iconButton.FlatStyle = FlatStyle.Flat;
            modify_iconButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            modify_iconButton.ForeColor = SystemColors.Control;
            modify_iconButton.IconChar = FontAwesome.Sharp.IconChar.PaintBrush;
            modify_iconButton.IconColor = SystemColors.Control;
            modify_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            modify_iconButton.IconSize = 28;
            modify_iconButton.Location = new Point(438, 74);
            modify_iconButton.Name = "modify_iconButton";
            modify_iconButton.Size = new Size(106, 33);
            modify_iconButton.TabIndex = 11;
            modify_iconButton.Text = "Modificar";
            modify_iconButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            modify_iconButton.UseVisualStyleBackColor = false;
            modify_iconButton.Click += modify_iconButton_Click;
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnidad.Location = new Point(483, 12);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(46, 18);
            lblUnidad.TabIndex = 13;
            lblUnidad.Text = "label2";
            lblUnidad.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UserMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblUnidad);
            Controls.Add(delete_iconButton);
            Controls.Add(modify_iconButton);
            Controls.Add(lblCantidada);
            Controls.Add(iconPictureBox1);
            Controls.Add(nametxt);
            Controls.Add(lblCantidad);
            Controls.Add(label1);
            Name = "UserMaterial";
            Size = new Size(549, 188);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lblCantidad;
        private Label nametxt;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label lblCantidada;
        private FontAwesome.Sharp.IconButton delete_iconButton;
        private FontAwesome.Sharp.IconButton modify_iconButton;
        private Label lblUnidad;
    }
}

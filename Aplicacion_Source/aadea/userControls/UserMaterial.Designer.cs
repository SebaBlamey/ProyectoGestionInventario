using FontAwesome.Sharp;

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
            nametxt = new Label();
            lblCantidada = new Label();
            delete_iconButton = new IconButton();
            modify_iconButton = new IconButton();
            lblUnidad = new Label();
            iconPictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(143, 74);
            label1.Name = "label1";
            label1.Size = new Size(57, 18);
            label1.TabIndex = 2;
            label1.Text = "Stock:";
            // 
            // nametxt
            // 
            nametxt.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            nametxt.ForeColor = Color.Black;
            nametxt.Location = new Point(3, 12);
            nametxt.Name = "nametxt";
            nametxt.Size = new Size(546, 31);
            nametxt.TabIndex = 7;
            nametxt.Text = "label2";
            nametxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCantidada
            // 
            lblCantidada.AutoSize = true;
            lblCantidada.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidada.Location = new Point(206, 74);
            lblCantidada.Name = "lblCantidada";
            lblCantidada.Size = new Size(46, 18);
            lblCantidada.TabIndex = 10;
            lblCantidada.Text = "label2";
            lblCantidada.TextAlign = ContentAlignment.MiddleLeft;
            lblCantidada.Click += lblCantidada_Click;
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
            delete_iconButton.IconChar = IconChar.Eraser;
            delete_iconButton.IconColor = SystemColors.Control;
            delete_iconButton.IconFont = IconFont.Auto;
            delete_iconButton.IconSize = 28;
            delete_iconButton.Location = new Point(419, 111);
            delete_iconButton.Name = "delete_iconButton";
            delete_iconButton.Size = new Size(118, 33);
            delete_iconButton.TabIndex = 6;
            delete_iconButton.Text = "Eliminar";
            delete_iconButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            delete_iconButton.UseVisualStyleBackColor = false;
            delete_iconButton.Click += delete_iconButton_Click;
            // 
            // modify_iconButton
            // 
            modify_iconButton.BackColor = Color.FromArgb(121, 160, 191);
            modify_iconButton.Cursor = Cursors.Hand;
            modify_iconButton.FlatAppearance.BorderColor = Color.FromArgb(81, 120, 151);
            modify_iconButton.FlatAppearance.BorderSize = 2;
            modify_iconButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(81, 120, 151);
            modify_iconButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(101, 140, 171);
            modify_iconButton.FlatStyle = FlatStyle.Flat;
            modify_iconButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            modify_iconButton.ForeColor = SystemColors.Control;
            modify_iconButton.IconChar = IconChar.PaintBrush;
            modify_iconButton.IconColor = SystemColors.Control;
            modify_iconButton.IconFont = IconFont.Auto;
            modify_iconButton.IconSize = 28;
            modify_iconButton.Location = new Point(419, 74);
            modify_iconButton.Name = "modify_iconButton";
            modify_iconButton.Size = new Size(118, 33);
            modify_iconButton.TabIndex = 5;
            modify_iconButton.Text = "Modificar";
            modify_iconButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            modify_iconButton.UseVisualStyleBackColor = false;
            modify_iconButton.Click += modify_iconButton_Click;
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUnidad.Location = new Point(249, 74);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(46, 18);
            lblUnidad.TabIndex = 13;
            lblUnidad.Text = "label2";
            lblUnidad.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Location = new Point(12, 46);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(125, 124);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // UserMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(155, 164, 181);
            Controls.Add(iconPictureBox1);
            Controls.Add(lblUnidad);
            Controls.Add(delete_iconButton);
            Controls.Add(modify_iconButton);
            Controls.Add(lblCantidada);
            Controls.Add(nametxt);
            Controls.Add(label1);
            Name = "UserMaterial";
            Size = new Size(549, 188);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label nametxt;
        private Label lblCantidada;
        private FontAwesome.Sharp.IconButton delete_iconButton;
        private FontAwesome.Sharp.IconButton modify_iconButton;
        private Label lblUnidad;
        private PictureBox iconPictureBox1;
    }
}

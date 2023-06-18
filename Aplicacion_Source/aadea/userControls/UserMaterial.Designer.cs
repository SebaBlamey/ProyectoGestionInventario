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
            lblTittle = new Label();
            picMaterial = new FontAwesome.Sharp.IconPictureBox();
            label1 = new Label();
            lblUnidad = new Label();
            lblCantidad = new Label();
            btModify = new Button();
            btDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)picMaterial).BeginInit();
            SuspendLayout();
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.ForeColor = SystemColors.AppWorkspace;
            lblTittle.Location = new Point(177, 16);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(38, 15);
            lblTittle.TabIndex = 0;
            lblTittle.Text = "label1";
            // 
            // picMaterial
            // 
            picMaterial.BackColor = SystemColors.Control;
            picMaterial.ForeColor = SystemColors.ControlText;
            picMaterial.IconChar = FontAwesome.Sharp.IconChar.None;
            picMaterial.IconColor = SystemColors.ControlText;
            picMaterial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picMaterial.IconSize = 132;
            picMaterial.Location = new Point(17, 16);
            picMaterial.Name = "picMaterial";
            picMaterial.Size = new Size(137, 132);
            picMaterial.TabIndex = 1;
            picMaterial.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(177, 78);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Stock:";
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.ForeColor = SystemColors.ActiveCaption;
            lblUnidad.Location = new Point(306, 78);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(45, 15);
            lblUnidad.TabIndex = 3;
            lblUnidad.Text = "Unidad";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.ForeColor = SystemColors.ControlLight;
            lblCantidad.Location = new Point(244, 78);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(53, 15);
            lblCantidad.TabIndex = 4;
            lblCantidad.Text = "cantidad";
            // 
            // btModify
            // 
            btModify.Location = new Point(451, 46);
            btModify.Name = "btModify";
            btModify.Size = new Size(120, 23);
            btModify.TabIndex = 5;
            btModify.Text = "Modificar";
            btModify.UseVisualStyleBackColor = true;
            btModify.Click += btModify_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(451, 99);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(120, 23);
            btDelete.TabIndex = 6;
            btDelete.Text = "Eliminar material";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // UserMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btDelete);
            Controls.Add(btModify);
            Controls.Add(lblCantidad);
            Controls.Add(lblUnidad);
            Controls.Add(label1);
            Controls.Add(picMaterial);
            Controls.Add(lblTittle);
            Name = "UserMaterial";
            Size = new Size(615, 170);
            ((System.ComponentModel.ISupportInitialize)picMaterial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTittle;
        private FontAwesome.Sharp.IconPictureBox picMaterial;
        private Label label1;
        private Label lblUnidad;
        private Label lblCantidad;
        private Button btModify;
        private Button btDelete;
    }
}

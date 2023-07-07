namespace aadea.userControls
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
            btModifyProduct = new Button();
            btDeleteProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)picProducto).BeginInit();
            SuspendLayout();
            // 
            // picProducto
            // 
            picProducto.Location = new Point(22, 28);
            picProducto.Name = "picProducto";
            picProducto.Size = new Size(125, 124);
            picProducto.SizeMode = PictureBoxSizeMode.StretchImage;
            picProducto.TabIndex = 0;
            picProducto.TabStop = false;
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.Location = new Point(58, 10);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(38, 15);
            lblTittle.TabIndex = 1;
            lblTittle.Text = "label1";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(168, 28);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(38, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "label1";
            // 
            // btModifyProduct
            // 
            btModifyProduct.Location = new Point(371, 57);
            btModifyProduct.Name = "btModifyProduct";
            btModifyProduct.Size = new Size(75, 23);
            btModifyProduct.TabIndex = 3;
            btModifyProduct.Text = "Modificar";
            btModifyProduct.UseVisualStyleBackColor = true;
            btModifyProduct.Click += btModifyProduct_Click;
            // 
            // btDeleteProduct
            // 
            btDeleteProduct.Location = new Point(371, 111);
            btDeleteProduct.Name = "btDeleteProduct";
            btDeleteProduct.Size = new Size(75, 23);
            btDeleteProduct.TabIndex = 4;
            btDeleteProduct.Text = "Eliminar";
            btDeleteProduct.UseVisualStyleBackColor = true;
            btDeleteProduct.Click += btDeleteProduct_Click;
            // 
            // UserProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btDeleteProduct);
            Controls.Add(btModifyProduct);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTittle);
            Controls.Add(picProducto);
            Name = "UserProduct";
            Size = new Size(486, 175);
            ((System.ComponentModel.ISupportInitialize)picProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picProducto;
        private Label lblTittle;
        private Label lblDescripcion;
        private Button btModifyProduct;
        private Button btDeleteProduct;
    }
}

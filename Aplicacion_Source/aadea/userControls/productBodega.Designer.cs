namespace aadea.userControls
{
    partial class productBodega
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
            pictureBox1 = new PictureBox();
            nameProduct = new Label();
            dataGridViewInv = new DataGridView();
            addStock = new Button();
            deleteStock = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInv).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(30, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 162);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // nameProduct
            // 
            nameProduct.AutoSize = true;
            nameProduct.Location = new Point(58, 22);
            nameProduct.Name = "nameProduct";
            nameProduct.Size = new Size(122, 15);
            nameProduct.TabIndex = 1;
            nameProduct.Text = "Nombre del producto";
            // 
            // dataGridViewInv
            // 
            dataGridViewInv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInv.Location = new Point(278, 22);
            dataGridViewInv.Name = "dataGridViewInv";
            dataGridViewInv.RowTemplate.Height = 25;
            dataGridViewInv.Size = new Size(352, 191);
            dataGridViewInv.TabIndex = 2;
            // 
            // addStock
            // 
            addStock.Location = new Point(662, 76);
            addStock.Name = "addStock";
            addStock.Size = new Size(75, 23);
            addStock.TabIndex = 3;
            addStock.Text = "Agregar";
            addStock.UseVisualStyleBackColor = true;
            // 
            // deleteStock
            // 
            deleteStock.Location = new Point(662, 133);
            deleteStock.Name = "deleteStock";
            deleteStock.Size = new Size(75, 23);
            deleteStock.TabIndex = 4;
            deleteStock.Text = "Eliminar";
            deleteStock.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(nameProduct);
            panel1.Location = new Point(-8, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 229);
            panel1.TabIndex = 5;
            // 
            // productBodega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(deleteStock);
            Controls.Add(addStock);
            Controls.Add(dataGridViewInv);
            Controls.Add(panel1);
            Name = "productBodega";
            Size = new Size(759, 227);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInv).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label nameProduct;
        private DataGridView dataGridViewInv;
        private Button addStock;
        private Button deleteStock;
        private Panel panel1;
    }
}

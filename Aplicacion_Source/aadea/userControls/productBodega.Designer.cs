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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            nameProduct = new Label();
            dataGridViewInv = new DataGridView();
            addStock = new Button();
            deleteBtn = new Button();
            panel1 = new Panel();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInv).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(30, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // nameProduct
            // 
            nameProduct.AutoSize = true;
            nameProduct.Location = new Point(39, 43);
            nameProduct.Name = "nameProduct";
            nameProduct.Size = new Size(122, 15);
            nameProduct.TabIndex = 1;
            nameProduct.Text = "Nombre del producto";
            // 
            // dataGridViewInv
            // 
            dataGridViewInv.AllowUserToAddRows = false;
            dataGridViewInv.AllowUserToResizeColumns = false;
            dataGridViewInv.AllowUserToResizeRows = false;
            dataGridViewInv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewInv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInv.BackgroundColor = Color.White;
            dataGridViewInv.BorderStyle = BorderStyle.None;
            dataGridViewInv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewInv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewInv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewInv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewInv.EnableHeadersVisualStyles = false;
            dataGridViewInv.GridColor = Color.DarkBlue;
            dataGridViewInv.Location = new Point(199, 22);
            dataGridViewInv.Name = "dataGridViewInv";
            dataGridViewInv.ReadOnly = true;
            dataGridViewInv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewInv.RowHeadersVisible = false;
            dataGridViewInv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.Plum;
            dataGridViewInv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewInv.RowTemplate.Height = 25;
            dataGridViewInv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewInv.Size = new Size(281, 191);
            dataGridViewInv.TabIndex = 0;
            // 
            // addStock
            // 
            addStock.ForeColor = Color.Black;
            addStock.Location = new Point(525, 72);
            addStock.Name = "addStock";
            addStock.Size = new Size(75, 23);
            addStock.TabIndex = 3;
            addStock.Text = "Agregar";
            addStock.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.ForeColor = Color.Black;
            deleteBtn.Location = new Point(525, 101);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 4;
            deleteBtn.Text = "Eliminar";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 192, 192);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(nameProduct);
            panel1.Location = new Point(-8, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(201, 229);
            panel1.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(538, 35);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(62, 23);
            numericUpDown1.TabIndex = 6;
            // 
            // productBodega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(numericUpDown1);
            Controls.Add(deleteBtn);
            Controls.Add(addStock);
            Controls.Add(dataGridViewInv);
            Controls.Add(panel1);
            Name = "productBodega";
            Size = new Size(625, 227);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInv).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label nameProduct;
        private DataGridView dataGridViewInv;
        private Button addStock;
        private Button deleteBtn;
        private Panel panel1;
        private NumericUpDown numericUpDown1;
    }
}

namespace aadea.userControls
{
    partial class historyControl
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblProduct = new Label();
            DGV_Producto = new DataGridView();
            DGV_materiales = new DataGridView();
            lblFechaInicio = new Label();
            lblFechatermino = new Label();
            lblInsertInicio = new Label();
            lblInsertTermino = new Label();
            ((System.ComponentModel.ISupportInitialize)DGV_Producto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_materiales).BeginInit();
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.BackColor = SystemColors.Control;
            lblProduct.ForeColor = Color.Black;
            lblProduct.Location = new Point(13, 10);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(89, 15);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Produccion n°: ";
            // 
            // DGV_Producto
            // 
            DGV_Producto.BackgroundColor = SystemColors.Control;
            DGV_Producto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            DGV_Producto.DefaultCellStyle = dataGridViewCellStyle1;
            DGV_Producto.Location = new Point(14, 36);
            DGV_Producto.Name = "DGV_Producto";
            DGV_Producto.RowTemplate.Height = 25;
            DGV_Producto.Size = new Size(242, 101);
            DGV_Producto.TabIndex = 1;
            // 
            // DGV_materiales
            // 
            DGV_materiales.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGV_materiales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGV_materiales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DGV_materiales.DefaultCellStyle = dataGridViewCellStyle3;
            DGV_materiales.Location = new Point(285, 36);
            DGV_materiales.Name = "DGV_materiales";
            DGV_materiales.RowTemplate.Height = 25;
            DGV_materiales.Size = new Size(178, 101);
            DGV_materiales.TabIndex = 2;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.ForeColor = Color.Black;
            lblFechaInicio.Location = new Point(491, 10);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(86, 15);
            lblFechaInicio.TabIndex = 3;
            lblFechaInicio.Text = "Fecha de inicio";
            // 
            // lblFechatermino
            // 
            lblFechatermino.AutoSize = true;
            lblFechatermino.ForeColor = Color.Black;
            lblFechatermino.Location = new Point(491, 74);
            lblFechatermino.Name = "lblFechatermino";
            lblFechatermino.Size = new Size(99, 15);
            lblFechatermino.TabIndex = 4;
            lblFechatermino.Text = "Fecha de termino";
            // 
            // lblInsertInicio
            // 
            lblInsertInicio.AutoSize = true;
            lblInsertInicio.ForeColor = Color.Black;
            lblInsertInicio.Location = new Point(513, 36);
            lblInsertInicio.Name = "lblInsertInicio";
            lblInsertInicio.Size = new Size(38, 15);
            lblInsertInicio.TabIndex = 5;
            lblInsertInicio.Text = "label1";
            // 
            // lblInsertTermino
            // 
            lblInsertTermino.AutoSize = true;
            lblInsertTermino.ForeColor = Color.Black;
            lblInsertTermino.Location = new Point(513, 107);
            lblInsertTermino.Name = "lblInsertTermino";
            lblInsertTermino.Size = new Size(38, 15);
            lblInsertTermino.TabIndex = 6;
            lblInsertTermino.Text = "label2";
            // 
            // historyControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblInsertTermino);
            Controls.Add(lblInsertInicio);
            Controls.Add(lblFechatermino);
            Controls.Add(lblFechaInicio);
            Controls.Add(DGV_materiales);
            Controls.Add(DGV_Producto);
            Controls.Add(lblProduct);
            ForeColor = Color.Black;
            Name = "historyControl";
            Size = new Size(607, 151);
            ((System.ComponentModel.ISupportInitialize)DGV_Producto).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_materiales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduct;
        private DataGridView DGV_Producto;
        private DataGridView DGV_materiales;
        private Label lblFechaInicio;
        private Label lblFechatermino;
        private Label lblInsertInicio;
        private Label lblInsertTermino;
    }
}

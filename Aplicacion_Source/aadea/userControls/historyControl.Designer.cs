﻿namespace aadea.userControls
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            lblProduct.BackColor = Color.Transparent;
            lblProduct.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduct.ForeColor = Color.Black;
            lblProduct.Location = new Point(14, 5);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(449, 28);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Produccion n°: ";
            lblProduct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DGV_Producto
            // 
            DGV_Producto.BackgroundColor = Color.FromArgb(115, 124, 141);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(38, 43, 58);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(38, 43, 58);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGV_Producto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGV_Producto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGV_Producto.DefaultCellStyle = dataGridViewCellStyle2;
            DGV_Producto.Location = new Point(14, 36);
            DGV_Producto.Name = "DGV_Producto";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(155, 164, 181);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(57, 72, 103);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGV_Producto.RowsDefaultCellStyle = dataGridViewCellStyle3;
            DGV_Producto.RowTemplate.Height = 25;
            DGV_Producto.Size = new Size(242, 101);
            DGV_Producto.TabIndex = 1;
            // 
            // DGV_materiales
            // 
            DGV_materiales.BackgroundColor = Color.FromArgb(115, 124, 141);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGV_materiales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGV_materiales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            DGV_materiales.DefaultCellStyle = dataGridViewCellStyle5;
            DGV_materiales.Location = new Point(285, 36);
            DGV_materiales.Name = "DGV_materiales";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(155, 164, 181);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(57, 71, 103);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            DGV_materiales.RowsDefaultCellStyle = dataGridViewCellStyle6;
            DGV_materiales.RowTemplate.Height = 25;
            DGV_materiales.Size = new Size(178, 101);
            DGV_materiales.TabIndex = 2;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaInicio.ForeColor = Color.Black;
            lblFechaInicio.Location = new Point(469, 36);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(123, 18);
            lblFechaInicio.TabIndex = 3;
            lblFechaInicio.Text = "Fecha de inicio";
            // 
            // lblFechatermino
            // 
            lblFechatermino.AutoSize = true;
            lblFechatermino.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechatermino.ForeColor = Color.Black;
            lblFechatermino.Location = new Point(469, 99);
            lblFechatermino.Name = "lblFechatermino";
            lblFechatermino.Size = new Size(138, 18);
            lblFechatermino.TabIndex = 4;
            lblFechatermino.Text = "Fecha de termino";
            // 
            // lblInsertInicio
            // 
            lblInsertInicio.AutoSize = true;
            lblInsertInicio.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblInsertInicio.ForeColor = Color.Black;
            lblInsertInicio.Location = new Point(469, 54);
            lblInsertInicio.Name = "lblInsertInicio";
            lblInsertInicio.Size = new Size(53, 20);
            lblInsertInicio.TabIndex = 5;
            lblInsertInicio.Text = "label1";
            // 
            // lblInsertTermino
            // 
            lblInsertTermino.AutoSize = true;
            lblInsertTermino.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblInsertTermino.ForeColor = Color.Black;
            lblInsertTermino.Location = new Point(469, 117);
            lblInsertTermino.Name = "lblInsertTermino";
            lblInsertTermino.Size = new Size(53, 20);
            lblInsertTermino.TabIndex = 6;
            lblInsertTermino.Text = "label2";
            // 
            // historyControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(155, 164, 181);
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

namespace aadea.userControls
{
    partial class produccionActual
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            dateProduccion = new DateTimePicker();
            DGVmateriales = new DataGridView();
            lblProduccion = new Label();
            label1 = new Label();
            label2 = new Label();
            fecha_inicio = new Label();
            eliminarBodega = new FontAwesome.Sharp.IconButton();
            terminarProd = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)DGVmateriales).BeginInit();
            SuspendLayout();
            // 
            // dateProduccion
            // 
            dateProduccion.CalendarFont = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateProduccion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateProduccion.Format = DateTimePickerFormat.Custom;
            dateProduccion.Location = new Point(387, 162);
            dateProduccion.Name = "dateProduccion";
            dateProduccion.Size = new Size(118, 27);
            dateProduccion.TabIndex = 4;
            // 
            // DGVmateriales
            // 
            DGVmateriales.BackgroundColor = Color.FromArgb(115, 124, 141);
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(34, 43, 58);
            dataGridViewCellStyle9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(34, 43, 58);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            DGVmateriales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            DGVmateriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmateriales.Location = new Point(14, 42);
            DGVmateriales.Name = "DGVmateriales";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(155, 164, 181);
            dataGridViewCellStyle10.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(57, 72, 103);
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            DGVmateriales.RowsDefaultCellStyle = dataGridViewCellStyle10;
            DGVmateriales.RowTemplate.Height = 25;
            DGVmateriales.Size = new Size(348, 147);
            DGVmateriales.TabIndex = 5;
            // 
            // lblProduccion
            // 
            lblProduccion.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduccion.ForeColor = Color.Black;
            lblProduccion.Location = new Point(0, 9);
            lblProduccion.Name = "lblProduccion";
            lblProduccion.Size = new Size(362, 25);
            lblProduccion.TabIndex = 6;
            lblProduccion.Text = "Produccion: ";
            lblProduccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(387, 141);
            label1.Name = "label1";
            label1.Size = new Size(114, 18);
            label1.TabIndex = 7;
            label1.Text = "Fecha termino";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(387, 94);
            label2.Name = "label2";
            label2.Size = new Size(99, 18);
            label2.TabIndex = 8;
            label2.Text = "Fecha inicio";
            // 
            // fecha_inicio
            // 
            fecha_inicio.AutoSize = true;
            fecha_inicio.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            fecha_inicio.ForeColor = Color.Black;
            fecha_inicio.Location = new Point(387, 112);
            fecha_inicio.Name = "fecha_inicio";
            fecha_inicio.Size = new Size(53, 20);
            fecha_inicio.TabIndex = 9;
            fecha_inicio.Text = "label3";
            // 
            // eliminarBodega
            // 
            eliminarBodega.BackColor = Color.FromArgb(204, 102, 102);
            eliminarBodega.Cursor = Cursors.Hand;
            eliminarBodega.FlatAppearance.BorderColor = Color.FromArgb(154, 52, 52);
            eliminarBodega.FlatAppearance.BorderSize = 2;
            eliminarBodega.FlatAppearance.MouseDownBackColor = Color.FromArgb(154, 52, 52);
            eliminarBodega.FlatAppearance.MouseOverBackColor = Color.FromArgb(164, 62, 62);
            eliminarBodega.FlatStyle = FlatStyle.Flat;
            eliminarBodega.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            eliminarBodega.ForeColor = SystemColors.Control;
            eliminarBodega.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            eliminarBodega.IconColor = SystemColors.Control;
            eliminarBodega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            eliminarBodega.IconSize = 28;
            eliminarBodega.Location = new Point(387, 48);
            eliminarBodega.Name = "eliminarBodega";
            eliminarBodega.Size = new Size(118, 33);
            eliminarBodega.TabIndex = 11;
            eliminarBodega.Text = "Eliminar";
            eliminarBodega.TextImageRelation = TextImageRelation.ImageBeforeText;
            eliminarBodega.UseVisualStyleBackColor = false;
            eliminarBodega.Click += eliminarBodega_Click;
            // 
            // terminarProd
            // 
            terminarProd.BackColor = Color.FromArgb(40, 167, 69);
            terminarProd.Cursor = Cursors.Hand;
            terminarProd.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 29);
            terminarProd.FlatAppearance.BorderSize = 2;
            terminarProd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 127, 29);
            terminarProd.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 147, 49);
            terminarProd.FlatStyle = FlatStyle.Flat;
            terminarProd.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            terminarProd.ForeColor = SystemColors.Control;
            terminarProd.IconChar = FontAwesome.Sharp.IconChar.Check;
            terminarProd.IconColor = SystemColors.Control;
            terminarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            terminarProd.IconSize = 28;
            terminarProd.Location = new Point(387, 9);
            terminarProd.Name = "terminarProd";
            terminarProd.Size = new Size(118, 33);
            terminarProd.TabIndex = 10;
            terminarProd.Text = "Terminar";
            terminarProd.TextImageRelation = TextImageRelation.ImageBeforeText;
            terminarProd.UseVisualStyleBackColor = false;
            terminarProd.Click += terminarProd_Click;
            // 
            // produccionActual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(155, 164, 181);
            Controls.Add(eliminarBodega);
            Controls.Add(terminarProd);
            Controls.Add(fecha_inicio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblProduccion);
            Controls.Add(DGVmateriales);
            Controls.Add(dateProduccion);
            Name = "produccionActual";
            Size = new Size(543, 201);
            ((System.ComponentModel.ISupportInitialize)DGVmateriales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateProduccion;
        private DataGridView DGVmateriales;
        private Label lblProduccion;
        private Label label1;
        private Label label2;
        private Label fecha_inicio;
        private FontAwesome.Sharp.IconButton eliminarBodega;
        private FontAwesome.Sharp.IconButton terminarProd;
    }
}

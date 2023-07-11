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
            button1 = new Button();
            btDeleteProduccion = new Button();
            dateProduccion = new DateTimePicker();
            DGVmateriales = new DataGridView();
            lblProduccion = new Label();
            label1 = new Label();
            label2 = new Label();
            fecha_inicio = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVmateriales).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(364, 42);
            button1.Name = "button1";
            button1.Size = new Size(158, 23);
            button1.TabIndex = 1;
            button1.Text = "Terminar producción";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btEnd_Click;
            // 
            // btDeleteProduccion
            // 
            btDeleteProduccion.ForeColor = Color.Black;
            btDeleteProduccion.Location = new Point(364, 71);
            btDeleteProduccion.Name = "btDeleteProduccion";
            btDeleteProduccion.Size = new Size(158, 23);
            btDeleteProduccion.TabIndex = 3;
            btDeleteProduccion.Text = "Eliminar producción";
            btDeleteProduccion.UseVisualStyleBackColor = true;
            btDeleteProduccion.Click += btDelete_Click;
            // 
            // dateProduccion
            // 
            dateProduccion.CalendarFont = new Font("Tahoma", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateProduccion.Font = new Font("Tahoma", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateProduccion.Format = DateTimePickerFormat.Custom;
            dateProduccion.Location = new Point(368, 158);
            dateProduccion.Name = "dateProduccion";
            dateProduccion.Size = new Size(154, 22);
            dateProduccion.TabIndex = 4;
            // 
            // DGVmateriales
            // 
            DGVmateriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVmateriales.Location = new Point(14, 42);
            DGVmateriales.Name = "DGVmateriales";
            DGVmateriales.RowTemplate.Height = 25;
            DGVmateriales.Size = new Size(306, 138);
            DGVmateriales.TabIndex = 5;
            // 
            // lblProduccion
            // 
            lblProduccion.AutoSize = true;
            lblProduccion.ForeColor = Color.Black;
            lblProduccion.Location = new Point(14, 13);
            lblProduccion.Name = "lblProduccion";
            lblProduccion.Size = new Size(74, 15);
            lblProduccion.TabIndex = 6;
            lblProduccion.Text = "Produccion: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(368, 140);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 7;
            label1.Text = "Fecha termino";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(368, 97);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 8;
            label2.Text = "Fecha inicio";
            // 
            // fecha_inicio
            // 
            fecha_inicio.AutoSize = true;
            fecha_inicio.ForeColor = Color.Black;
            fecha_inicio.Location = new Point(368, 121);
            fecha_inicio.Name = "fecha_inicio";
            fecha_inicio.Size = new Size(38, 15);
            fecha_inicio.TabIndex = 9;
            fecha_inicio.Text = "label3";
            // 
            // produccionActual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(fecha_inicio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblProduccion);
            Controls.Add(DGVmateriales);
            Controls.Add(dateProduccion);
            Controls.Add(btDeleteProduccion);
            Controls.Add(button1);
            Name = "produccionActual";
            Size = new Size(543, 201);
            ((System.ComponentModel.ISupportInitialize)DGVmateriales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button btDeleteProduccion;
        private DateTimePicker dateProduccion;
        private DataGridView DGVmateriales;
        private Label lblProduccion;
        private Label label1;
        private Label label2;
        private Label fecha_inicio;
    }
}

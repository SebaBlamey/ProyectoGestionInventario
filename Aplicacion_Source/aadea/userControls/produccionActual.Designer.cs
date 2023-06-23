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
            btEditProduccion = new Button();
            btDeleteProduccion = new Button();
            dateProduccion = new DateTimePicker();
            DGVmateriales = new DataGridView();
            lblProduccion = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVmateriales).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(364, 31);
            button1.Name = "button1";
            button1.Size = new Size(158, 23);
            button1.TabIndex = 1;
            button1.Text = "Terminar producción";
            button1.UseVisualStyleBackColor = true;
            // 
            // btEditProduccion
            // 
            btEditProduccion.ForeColor = Color.Black;
            btEditProduccion.Location = new Point(364, 71);
            btEditProduccion.Name = "btEditProduccion";
            btEditProduccion.Size = new Size(158, 23);
            btEditProduccion.TabIndex = 2;
            btEditProduccion.Text = "Editar produccion";
            btEditProduccion.UseVisualStyleBackColor = true;
            // 
            // btDeleteProduccion
            // 
            btDeleteProduccion.ForeColor = Color.Black;
            btDeleteProduccion.Location = new Point(364, 116);
            btDeleteProduccion.Name = "btDeleteProduccion";
            btDeleteProduccion.Size = new Size(158, 23);
            btDeleteProduccion.TabIndex = 3;
            btDeleteProduccion.Text = "Eliminar producción";
            btDeleteProduccion.UseVisualStyleBackColor = true;
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
            lblProduccion.Size = new Size(84, 15);
            lblProduccion.TabIndex = 6;
            lblProduccion.Text = "Produccion n: ";
            // 
            // produccionActual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblProduccion);
            Controls.Add(DGVmateriales);
            Controls.Add(dateProduccion);
            Controls.Add(btDeleteProduccion);
            Controls.Add(btEditProduccion);
            Controls.Add(button1);
            Name = "produccionActual";
            Size = new Size(543, 201);
            ((System.ComponentModel.ISupportInitialize)DGVmateriales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button btEditProduccion;
        private Button btDeleteProduccion;
        private DateTimePicker dateProduccion;
        private DataGridView DGVmateriales;
        private Label lblProduccion;
    }
}

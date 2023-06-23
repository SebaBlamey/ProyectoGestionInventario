namespace aadea.Vistas
{
    partial class FormProduccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            tabControlProduccion = new TabControl();
            viewButtons = new TabPage();
            btIngresarProduccion = new Model.BT();
            btViewProduccion = new Model.BT();
            bt1 = new Model.BT();
            tabHistory = new TabPage();
            LayoutHistorial = new FlowLayoutPanel();
            bttExitHistory = new Model.BT();
            tabProduccionActual = new TabPage();
            btExitProduccionActual = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tabIngresarProduccion = new TabPage();
            DGVAddProduccion = new DataGridView();
            textBoxCantidad = new TextBox();
            label2 = new Label();
            btCancelAddproduccion = new Button();
            btAceptar = new Button();
            dateAddProduccion = new DateTimePicker();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            tabControlProduccion.SuspendLayout();
            viewButtons.SuspendLayout();
            tabHistory.SuspendLayout();
            tabProduccionActual.SuspendLayout();
            tabIngresarProduccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVAddProduccion).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControlProduccion);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 468);
            panel1.TabIndex = 0;
            // 
            // tabControlProduccion
            // 
            tabControlProduccion.Controls.Add(viewButtons);
            tabControlProduccion.Controls.Add(tabHistory);
            tabControlProduccion.Controls.Add(tabProduccionActual);
            tabControlProduccion.Controls.Add(tabIngresarProduccion);
            tabControlProduccion.Dock = DockStyle.Fill;
            tabControlProduccion.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlProduccion.Location = new Point(0, 0);
            tabControlProduccion.Name = "tabControlProduccion";
            tabControlProduccion.SelectedIndex = 0;
            tabControlProduccion.Size = new Size(802, 468);
            tabControlProduccion.TabIndex = 0;
            // 
            // viewButtons
            // 
            viewButtons.Controls.Add(btIngresarProduccion);
            viewButtons.Controls.Add(btViewProduccion);
            viewButtons.Controls.Add(bt1);
            viewButtons.Location = new Point(4, 26);
            viewButtons.Name = "viewButtons";
            viewButtons.Padding = new Padding(3);
            viewButtons.Size = new Size(794, 438);
            viewButtons.TabIndex = 0;
            viewButtons.Text = "Produccion";
            viewButtons.UseVisualStyleBackColor = true;
            // 
            // btIngresarProduccion
            // 
            btIngresarProduccion.BackColor = Color.MediumSlateBlue;
            btIngresarProduccion.BackgroundColor = Color.MediumSlateBlue;
            btIngresarProduccion.BorderColor = Color.PaleVioletRed;
            btIngresarProduccion.BorderRadius = 20;
            btIngresarProduccion.BorderSize = 0;
            btIngresarProduccion.FlatAppearance.BorderSize = 0;
            btIngresarProduccion.FlatStyle = FlatStyle.Flat;
            btIngresarProduccion.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btIngresarProduccion.ForeColor = Color.White;
            btIngresarProduccion.Location = new Point(237, 258);
            btIngresarProduccion.Name = "btIngresarProduccion";
            btIngresarProduccion.Size = new Size(270, 60);
            btIngresarProduccion.TabIndex = 2;
            btIngresarProduccion.Text = "Ingresar Produccion";
            btIngresarProduccion.TextColor = Color.White;
            btIngresarProduccion.UseVisualStyleBackColor = false;
            btIngresarProduccion.Click += btIngresarProduccion_Click;
            // 
            // btViewProduccion
            // 
            btViewProduccion.BackColor = Color.MediumSlateBlue;
            btViewProduccion.BackgroundColor = Color.MediumSlateBlue;
            btViewProduccion.BorderColor = Color.PaleVioletRed;
            btViewProduccion.BorderRadius = 20;
            btViewProduccion.BorderSize = 0;
            btViewProduccion.FlatAppearance.BorderSize = 0;
            btViewProduccion.FlatStyle = FlatStyle.Flat;
            btViewProduccion.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btViewProduccion.ForeColor = Color.White;
            btViewProduccion.Location = new Point(237, 172);
            btViewProduccion.Name = "btViewProduccion";
            btViewProduccion.Size = new Size(270, 60);
            btViewProduccion.TabIndex = 1;
            btViewProduccion.Text = "Ver producción actual";
            btViewProduccion.TextColor = Color.White;
            btViewProduccion.UseVisualStyleBackColor = false;
            btViewProduccion.Click += btViewProduccion_Click;
            // 
            // bt1
            // 
            bt1.BackColor = Color.MediumSlateBlue;
            bt1.BackgroundColor = Color.MediumSlateBlue;
            bt1.BorderColor = Color.PaleVioletRed;
            bt1.BorderRadius = 20;
            bt1.BorderSize = 0;
            bt1.FlatAppearance.BorderSize = 0;
            bt1.FlatStyle = FlatStyle.Flat;
            bt1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            bt1.ForeColor = Color.White;
            bt1.Location = new Point(237, 82);
            bt1.Name = "bt1";
            bt1.Size = new Size(270, 60);
            bt1.TabIndex = 0;
            bt1.Text = "Historial de producción";
            bt1.TextColor = Color.White;
            bt1.UseVisualStyleBackColor = false;
            bt1.Click += bt1_Click;
            // 
            // tabHistory
            // 
            tabHistory.Controls.Add(LayoutHistorial);
            tabHistory.Controls.Add(bttExitHistory);
            tabHistory.Location = new Point(4, 26);
            tabHistory.Name = "tabHistory";
            tabHistory.Padding = new Padding(3);
            tabHistory.RightToLeft = RightToLeft.No;
            tabHistory.Size = new Size(794, 438);
            tabHistory.TabIndex = 1;
            tabHistory.Text = "Historial de produccion";
            tabHistory.UseVisualStyleBackColor = true;
            // 
            // LayoutHistorial
            // 
            LayoutHistorial.AutoScroll = true;
            LayoutHistorial.Location = new Point(3, 6);
            LayoutHistorial.Name = "LayoutHistorial";
            LayoutHistorial.Size = new Size(783, 382);
            LayoutHistorial.TabIndex = 1;
            // 
            // bttExitHistory
            // 
            bttExitHistory.BackColor = Color.MediumSlateBlue;
            bttExitHistory.BackgroundColor = Color.MediumSlateBlue;
            bttExitHistory.BorderColor = Color.PaleVioletRed;
            bttExitHistory.BorderRadius = 20;
            bttExitHistory.BorderSize = 0;
            bttExitHistory.FlatAppearance.BorderSize = 0;
            bttExitHistory.FlatStyle = FlatStyle.Flat;
            bttExitHistory.ForeColor = Color.White;
            bttExitHistory.Location = new Point(638, 394);
            bttExitHistory.Name = "bttExitHistory";
            bttExitHistory.Size = new Size(150, 40);
            bttExitHistory.TabIndex = 0;
            bttExitHistory.Text = "Salir";
            bttExitHistory.TextColor = Color.White;
            bttExitHistory.UseVisualStyleBackColor = false;
            bttExitHistory.Click += bttExitHistory_Click;
            // 
            // tabProduccionActual
            // 
            tabProduccionActual.Controls.Add(btExitProduccionActual);
            tabProduccionActual.Controls.Add(flowLayoutPanel1);
            tabProduccionActual.Location = new Point(4, 26);
            tabProduccionActual.Name = "tabProduccionActual";
            tabProduccionActual.Padding = new Padding(3);
            tabProduccionActual.Size = new Size(794, 438);
            tabProduccionActual.TabIndex = 2;
            tabProduccionActual.Text = "Produccion Actual";
            tabProduccionActual.UseVisualStyleBackColor = true;
            // 
            // btExitProduccionActual
            // 
            btExitProduccionActual.Location = new Point(676, 407);
            btExitProduccionActual.Name = "btExitProduccionActual";
            btExitProduccionActual.Size = new Size(95, 23);
            btExitProduccionActual.TabIndex = 1;
            btExitProduccionActual.Text = "Salir";
            btExitProduccionActual.UseVisualStyleBackColor = true;
            btExitProduccionActual.Click += btExitProduccionActual_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(6, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(780, 383);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tabIngresarProduccion
            // 
            tabIngresarProduccion.Controls.Add(DGVAddProduccion);
            tabIngresarProduccion.Controls.Add(textBoxCantidad);
            tabIngresarProduccion.Controls.Add(label2);
            tabIngresarProduccion.Controls.Add(btCancelAddproduccion);
            tabIngresarProduccion.Controls.Add(btAceptar);
            tabIngresarProduccion.Controls.Add(dateAddProduccion);
            tabIngresarProduccion.Controls.Add(label1);
            tabIngresarProduccion.Location = new Point(4, 26);
            tabIngresarProduccion.Name = "tabIngresarProduccion";
            tabIngresarProduccion.Padding = new Padding(3);
            tabIngresarProduccion.Size = new Size(794, 438);
            tabIngresarProduccion.TabIndex = 3;
            tabIngresarProduccion.Text = "Ingresar produccion";
            tabIngresarProduccion.UseVisualStyleBackColor = true;
            // 
            // DGVAddProduccion
            // 
            DGVAddProduccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVAddProduccion.Location = new Point(29, 125);
            DGVAddProduccion.Name = "DGVAddProduccion";
            DGVAddProduccion.RowTemplate.Height = 25;
            DGVAddProduccion.Size = new Size(732, 251);
            DGVAddProduccion.TabIndex = 10;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.Location = new Point(194, 97);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(100, 22);
            textBoxCantidad.TabIndex = 9;
            textBoxCantidad.TextChanged += textBoxCantidad_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(29, 97);
            label2.Name = "label2";
            label2.Size = new Size(149, 17);
            label2.TabIndex = 8;
            label2.Text = "Cantidad de materiales";
            // 
            // btCancelAddproduccion
            // 
            btCancelAddproduccion.ForeColor = Color.Black;
            btCancelAddproduccion.Location = new Point(220, 382);
            btCancelAddproduccion.Name = "btCancelAddproduccion";
            btCancelAddproduccion.Size = new Size(122, 23);
            btCancelAddproduccion.TabIndex = 7;
            btCancelAddproduccion.Text = "Cancelar";
            btCancelAddproduccion.UseVisualStyleBackColor = true;
            // 
            // btAceptar
            // 
            btAceptar.ForeColor = Color.Black;
            btAceptar.Location = new Point(50, 382);
            btAceptar.Name = "btAceptar";
            btAceptar.Size = new Size(122, 23);
            btAceptar.TabIndex = 6;
            btAceptar.Text = "Aceptar";
            btAceptar.UseVisualStyleBackColor = true;
            // 
            // dateAddProduccion
            // 
            dateAddProduccion.CalendarFont = new Font("Tahoma", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateAddProduccion.Font = new Font("Tahoma", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateAddProduccion.Format = DateTimePickerFormat.Custom;
            dateAddProduccion.Location = new Point(352, 45);
            dateAddProduccion.Name = "dateAddProduccion";
            dateAddProduccion.Size = new Size(216, 22);
            dateAddProduccion.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(29, 45);
            label1.Name = "label1";
            label1.Size = new Size(196, 22);
            label1.TabIndex = 0;
            label1.Text = "Ingresar produccion";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FormProduccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 468);
            Controls.Add(panel1);
            Name = "FormProduccion";
            Text = "FormProduccion";
            panel1.ResumeLayout(false);
            tabControlProduccion.ResumeLayout(false);
            viewButtons.ResumeLayout(false);
            tabHistory.ResumeLayout(false);
            tabProduccionActual.ResumeLayout(false);
            tabIngresarProduccion.ResumeLayout(false);
            tabIngresarProduccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVAddProduccion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControlProduccion;
        private TabPage viewButtons;
        private TabPage tabHistory;
        private ContextMenuStrip contextMenuStrip1;
        private TabPage tabProduccionActual;
        private TabPage tabIngresarProduccion;
        private Model.BT btIngresarProduccion;
        private Model.BT btViewProduccion;
        private Model.BT bt1;
        private Model.BT bttExitHistory;
        private FlowLayoutPanel LayoutHistorial;
        private Button btExitProduccionActual;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Button btCancelAddproduccion;
        private Button btAceptar;
        private DateTimePicker dateAddProduccion;
        private TextBox textBoxCantidad;
        private Label label2;
        private DataGridView DGVAddProduccion;
    }
}
using aadea.Extras;

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
            tabControlProduccion = new TabControlEx();
            viewButtons = new TabPage();
            HelpBTHistory = new FontAwesome.Sharp.IconPictureBox();
            btIngresarProduccion = new Model.BT();
            btViewProduccion = new Model.BT();
            bt1 = new Model.BT();
            tabHistory = new TabPage();
            volverBtn = new FontAwesome.Sharp.IconButton();
            LayoutHistorial = new FlowLayoutPanel();
            tabProduccionActual = new TabPage();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            volerProdActual = new FontAwesome.Sharp.IconButton();
            layoutPanelActualProduccion = new FlowLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tabIngresarProduccion = new TabPage();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            cancelarIngresar = new FontAwesome.Sharp.IconButton();
            aceptarIngresar = new FontAwesome.Sharp.IconButton();
            textBoxCantidad = new TextBox();
            dateAddProduccion = new DateTimePicker();
            flowLayoutPanelBox = new FlowLayoutPanel();
            txtName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tabBodega = new TabPage();
            aceptarIngresarBodega = new FontAwesome.Sharp.IconButton();
            cancelarIngresarBodega = new FontAwesome.Sharp.IconButton();
            layoutPanelProducts = new FlowLayoutPanel();
            boxProductsCreate = new TextBox();
            label5 = new Label();
            label4 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            panel1.SuspendLayout();
            tabControlProduccion.SuspendLayout();
            viewButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HelpBTHistory).BeginInit();
            tabHistory.SuspendLayout();
            tabProduccionActual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            tabIngresarProduccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            tabBodega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControlProduccion);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(675, 477);
            panel1.TabIndex = 0;
            // 
            // tabControlProduccion
            // 
            tabControlProduccion.Controls.Add(viewButtons);
            tabControlProduccion.Controls.Add(tabHistory);
            tabControlProduccion.Controls.Add(tabProduccionActual);
            tabControlProduccion.Controls.Add(tabIngresarProduccion);
            tabControlProduccion.Controls.Add(tabBodega);
            tabControlProduccion.Dock = DockStyle.Fill;
            tabControlProduccion.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlProduccion.Location = new Point(0, 0);
            tabControlProduccion.Name = "tabControlProduccion";
            tabControlProduccion.SelectedIndex = 0;
            tabControlProduccion.Size = new Size(675, 477);
            tabControlProduccion.TabIndex = 0;
            // 
            // viewButtons
            // 
            viewButtons.BackColor = Color.FromArgb(115, 124, 141);
            viewButtons.Controls.Add(HelpBTHistory);
            viewButtons.Controls.Add(btIngresarProduccion);
            viewButtons.Controls.Add(btViewProduccion);
            viewButtons.Controls.Add(bt1);
            viewButtons.Location = new Point(-2, 20);
            viewButtons.Name = "viewButtons";
            viewButtons.Padding = new Padding(3);
            viewButtons.Size = new Size(679, 459);
            viewButtons.TabIndex = 0;
            viewButtons.Text = "Produccion";
            // 
            // HelpBTHistory
            // 
            HelpBTHistory.BackColor = Color.FromArgb(115, 124, 141);
            HelpBTHistory.ForeColor = Color.Black;
            HelpBTHistory.IconChar = FontAwesome.Sharp.IconChar.Question;
            HelpBTHistory.IconColor = Color.Black;
            HelpBTHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            HelpBTHistory.IconSize = 24;
            HelpBTHistory.Location = new Point(668, 430);
            HelpBTHistory.Name = "HelpBTHistory";
            HelpBTHistory.Size = new Size(24, 26);
            HelpBTHistory.TabIndex = 19;
            HelpBTHistory.TabStop = false;
            HelpBTHistory.Click += HelpBTHistory_Click;
            // 
            // btIngresarProduccion
            // 
            btIngresarProduccion.BackColor = Color.FromArgb(155, 164, 181);
            btIngresarProduccion.BackgroundColor = Color.FromArgb(155, 164, 181);
            btIngresarProduccion.BorderColor = Color.PaleVioletRed;
            btIngresarProduccion.BorderRadius = 20;
            btIngresarProduccion.BorderSize = 0;
            btIngresarProduccion.FlatAppearance.BorderSize = 0;
            btIngresarProduccion.FlatStyle = FlatStyle.Flat;
            btIngresarProduccion.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btIngresarProduccion.ForeColor = Color.White;
            btIngresarProduccion.Location = new Point(204, 133);
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
            btViewProduccion.BackColor = Color.FromArgb(155, 164, 181);
            btViewProduccion.BackgroundColor = Color.FromArgb(155, 164, 181);
            btViewProduccion.BorderColor = Color.PaleVioletRed;
            btViewProduccion.BorderRadius = 20;
            btViewProduccion.BorderSize = 0;
            btViewProduccion.FlatAppearance.BorderSize = 0;
            btViewProduccion.FlatStyle = FlatStyle.Flat;
            btViewProduccion.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btViewProduccion.ForeColor = Color.White;
            btViewProduccion.Location = new Point(204, 199);
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
            bt1.BackColor = Color.FromArgb(155, 164, 181);
            bt1.BackgroundColor = Color.FromArgb(155, 164, 181);
            bt1.BorderColor = Color.FromArgb(155, 164, 181);
            bt1.BorderRadius = 20;
            bt1.BorderSize = 0;
            bt1.FlatAppearance.BorderSize = 0;
            bt1.FlatStyle = FlatStyle.Flat;
            bt1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bt1.ForeColor = Color.White;
            bt1.Location = new Point(204, 265);
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
            tabHistory.BackColor = Color.FromArgb(115, 124, 141);
            tabHistory.Controls.Add(volverBtn);
            tabHistory.Controls.Add(LayoutHistorial);
            tabHistory.Location = new Point(-2, 20);
            tabHistory.Name = "tabHistory";
            tabHistory.Padding = new Padding(3);
            tabHistory.RightToLeft = RightToLeft.No;
            tabHistory.Size = new Size(679, 459);
            tabHistory.TabIndex = 1;
            tabHistory.Text = "Historial de produccion";
            // 
            // volverBtn
            // 
            volverBtn.BackColor = Color.FromArgb(204, 102, 102);
            volverBtn.Cursor = Cursors.Hand;
            volverBtn.FlatAppearance.BorderColor = Color.FromArgb(154, 52, 52);
            volverBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(154, 52, 52);
            volverBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(164, 62, 62);
            volverBtn.FlatStyle = FlatStyle.Flat;
            volverBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            volverBtn.ForeColor = SystemColors.Control;
            volverBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowLeftLong;
            volverBtn.IconColor = SystemColors.Control;
            volverBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            volverBtn.IconSize = 28;
            volverBtn.Location = new Point(12, 400);
            volverBtn.Name = "volverBtn";
            volverBtn.Size = new Size(118, 33);
            volverBtn.TabIndex = 13;
            volverBtn.Text = "Volver";
            volverBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            volverBtn.UseVisualStyleBackColor = false;
            volverBtn.Click += volverBtn_Click;
            // 
            // LayoutHistorial
            // 
            LayoutHistorial.AutoScroll = true;
            LayoutHistorial.BackColor = Color.Transparent;
            LayoutHistorial.Location = new Point(12, 6);
            LayoutHistorial.Name = "LayoutHistorial";
            LayoutHistorial.Size = new Size(653, 388);
            LayoutHistorial.TabIndex = 1;
            LayoutHistorial.Paint += LayoutHistorial_Paint;
            // 
            // tabProduccionActual
            // 
            tabProduccionActual.BackColor = Color.FromArgb(115, 124, 141);
            tabProduccionActual.Controls.Add(iconPictureBox2);
            tabProduccionActual.Controls.Add(volerProdActual);
            tabProduccionActual.Controls.Add(layoutPanelActualProduccion);
            tabProduccionActual.Controls.Add(flowLayoutPanel1);
            tabProduccionActual.Location = new Point(-2, 20);
            tabProduccionActual.Name = "tabProduccionActual";
            tabProduccionActual.Padding = new Padding(3);
            tabProduccionActual.Size = new Size(679, 459);
            tabProduccionActual.TabIndex = 2;
            tabProduccionActual.Text = "Produccion Actual";
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(115, 124, 141);
            iconPictureBox2.ForeColor = Color.Black;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Question;
            iconPictureBox2.IconColor = Color.Black;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 24;
            iconPictureBox2.Location = new Point(668, 430);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(24, 26);
            iconPictureBox2.TabIndex = 26;
            iconPictureBox2.TabStop = false;
            iconPictureBox2.Click += iconPictureBox2_Click;
            // 
            // volerProdActual
            // 
            volerProdActual.BackColor = Color.FromArgb(204, 102, 102);
            volerProdActual.Cursor = Cursors.Hand;
            volerProdActual.FlatAppearance.BorderColor = Color.FromArgb(154, 52, 52);
            volerProdActual.FlatAppearance.BorderSize = 2;
            volerProdActual.FlatAppearance.MouseDownBackColor = Color.FromArgb(154, 52, 52);
            volerProdActual.FlatAppearance.MouseOverBackColor = Color.FromArgb(164, 62, 62);
            volerProdActual.FlatStyle = FlatStyle.Flat;
            volerProdActual.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            volerProdActual.ForeColor = SystemColors.Control;
            volerProdActual.IconChar = FontAwesome.Sharp.IconChar.ArrowLeftLong;
            volerProdActual.IconColor = SystemColors.Control;
            volerProdActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            volerProdActual.IconSize = 28;
            volerProdActual.Location = new Point(12, 400);
            volerProdActual.Name = "volerProdActual";
            volerProdActual.Size = new Size(118, 33);
            volerProdActual.TabIndex = 14;
            volerProdActual.Text = "Volver";
            volerProdActual.TextImageRelation = TextImageRelation.ImageBeforeText;
            volerProdActual.UseVisualStyleBackColor = false;
            volerProdActual.Click += volerProdActual_Click;
            // 
            // layoutPanelActualProduccion
            // 
            layoutPanelActualProduccion.AutoScroll = true;
            layoutPanelActualProduccion.BackColor = Color.Transparent;
            layoutPanelActualProduccion.Location = new Point(12, 6);
            layoutPanelActualProduccion.Name = "layoutPanelActualProduccion";
            layoutPanelActualProduccion.Size = new Size(653, 388);
            layoutPanelActualProduccion.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(6, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(780, 0);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tabIngresarProduccion
            // 
            tabIngresarProduccion.AutoScroll = true;
            tabIngresarProduccion.BackColor = Color.FromArgb(115, 124, 141);
            tabIngresarProduccion.Controls.Add(iconPictureBox1);
            tabIngresarProduccion.Controls.Add(cancelarIngresar);
            tabIngresarProduccion.Controls.Add(aceptarIngresar);
            tabIngresarProduccion.Controls.Add(textBoxCantidad);
            tabIngresarProduccion.Controls.Add(dateAddProduccion);
            tabIngresarProduccion.Controls.Add(flowLayoutPanelBox);
            tabIngresarProduccion.Controls.Add(txtName);
            tabIngresarProduccion.Controls.Add(label2);
            tabIngresarProduccion.Controls.Add(label3);
            tabIngresarProduccion.Location = new Point(-2, 20);
            tabIngresarProduccion.Name = "tabIngresarProduccion";
            tabIngresarProduccion.Padding = new Padding(3);
            tabIngresarProduccion.Size = new Size(679, 459);
            tabIngresarProduccion.TabIndex = 3;
            tabIngresarProduccion.Text = "Ingresar produccion";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(115, 124, 141);
            iconPictureBox1.ForeColor = Color.Black;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Question;
            iconPictureBox1.IconColor = Color.Black;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 24;
            iconPictureBox1.Location = new Point(673, 410);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(24, 26);
            iconPictureBox1.TabIndex = 25;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // cancelarIngresar
            // 
            cancelarIngresar.BackColor = Color.FromArgb(204, 102, 102);
            cancelarIngresar.FlatAppearance.BorderColor = Color.FromArgb(154, 52, 52);
            cancelarIngresar.FlatAppearance.BorderSize = 2;
            cancelarIngresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(154, 52, 52);
            cancelarIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(164, 62, 62);
            cancelarIngresar.FlatStyle = FlatStyle.Flat;
            cancelarIngresar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancelarIngresar.ForeColor = SystemColors.Control;
            cancelarIngresar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            cancelarIngresar.IconColor = SystemColors.Control;
            cancelarIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cancelarIngresar.IconSize = 28;
            cancelarIngresar.Location = new Point(559, 161);
            cancelarIngresar.Name = "cancelarIngresar";
            cancelarIngresar.Size = new Size(118, 33);
            cancelarIngresar.TabIndex = 23;
            cancelarIngresar.Text = "Cancelar";
            cancelarIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            cancelarIngresar.UseVisualStyleBackColor = false;
            cancelarIngresar.Click += cancelarIngresar_Click;
            // 
            // aceptarIngresar
            // 
            aceptarIngresar.BackColor = Color.FromArgb(40, 167, 69);
            aceptarIngresar.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 29);
            aceptarIngresar.FlatAppearance.BorderSize = 2;
            aceptarIngresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 127, 29);
            aceptarIngresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 147, 49);
            aceptarIngresar.FlatStyle = FlatStyle.Flat;
            aceptarIngresar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            aceptarIngresar.ForeColor = SystemColors.Control;
            aceptarIngresar.IconChar = FontAwesome.Sharp.IconChar.Check;
            aceptarIngresar.IconColor = SystemColors.Control;
            aceptarIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            aceptarIngresar.IconSize = 28;
            aceptarIngresar.Location = new Point(559, 122);
            aceptarIngresar.Name = "aceptarIngresar";
            aceptarIngresar.Size = new Size(118, 33);
            aceptarIngresar.TabIndex = 24;
            aceptarIngresar.Text = "Aceptar";
            aceptarIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            aceptarIngresar.UseVisualStyleBackColor = false;
            aceptarIngresar.Click += aceptarIngresar_Click;
            // 
            // textBoxCantidad
            // 
            textBoxCantidad.BackColor = Color.FromArgb(155, 164, 181);
            textBoxCantidad.BorderStyle = BorderStyle.FixedSingle;
            textBoxCantidad.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCantidad.Location = new Point(14, 48);
            textBoxCantidad.Name = "textBoxCantidad";
            textBoxCantidad.Size = new Size(244, 27);
            textBoxCantidad.TabIndex = 9;
            textBoxCantidad.TextChanged += textBoxCantidad_TextChanged;
            // 
            // dateAddProduccion
            // 
            dateAddProduccion.CalendarFont = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateAddProduccion.CalendarMonthBackground = Color.FromArgb(155, 164, 181);
            dateAddProduccion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateAddProduccion.Format = DateTimePickerFormat.Custom;
            dateAddProduccion.Location = new Point(559, 48);
            dateAddProduccion.Name = "dateAddProduccion";
            dateAddProduccion.Size = new Size(127, 27);
            dateAddProduccion.TabIndex = 5;
            // 
            // flowLayoutPanelBox
            // 
            flowLayoutPanelBox.AutoScroll = true;
            flowLayoutPanelBox.BackColor = Color.FromArgb(155, 164, 181);
            flowLayoutPanelBox.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelBox.Location = new Point(14, 99);
            flowLayoutPanelBox.Name = "flowLayoutPanelBox";
            flowLayoutPanelBox.Size = new Size(523, 269);
            flowLayoutPanelBox.TabIndex = 10;
            flowLayoutPanelBox.WrapContents = false;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(155, 164, 181);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(287, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 22);
            label2.Name = "label2";
            label2.Size = new Size(232, 23);
            label2.TabIndex = 8;
            label2.Text = "Cantidad de materiales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(287, 22);
            label3.Name = "label3";
            label3.Size = new Size(250, 23);
            label3.TabIndex = 12;
            label3.Text = "Nombre de la produccion";
            // 
            // tabBodega
            // 
            tabBodega.BackColor = Color.FromArgb(115, 124, 141);
            tabBodega.Controls.Add(iconPictureBox3);
            tabBodega.Controls.Add(aceptarIngresarBodega);
            tabBodega.Controls.Add(cancelarIngresarBodega);
            tabBodega.Controls.Add(layoutPanelProducts);
            tabBodega.Controls.Add(boxProductsCreate);
            tabBodega.Controls.Add(label5);
            tabBodega.Controls.Add(label4);
            tabBodega.Location = new Point(-2, 20);
            tabBodega.Name = "tabBodega";
            tabBodega.Padding = new Padding(3);
            tabBodega.Size = new Size(679, 459);
            tabBodega.TabIndex = 4;
            tabBodega.Text = "Ingresar productos";
            // 
            // aceptarIngresarBodega
            // 
            aceptarIngresarBodega.BackColor = Color.FromArgb(40, 167, 69);
            aceptarIngresarBodega.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 29);
            aceptarIngresarBodega.FlatAppearance.BorderSize = 2;
            aceptarIngresarBodega.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 127, 29);
            aceptarIngresarBodega.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 147, 49);
            aceptarIngresarBodega.FlatStyle = FlatStyle.Flat;
            aceptarIngresarBodega.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            aceptarIngresarBodega.ForeColor = SystemColors.Control;
            aceptarIngresarBodega.IconChar = FontAwesome.Sharp.IconChar.Check;
            aceptarIngresarBodega.IconColor = SystemColors.Control;
            aceptarIngresarBodega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            aceptarIngresarBodega.IconSize = 28;
            aceptarIngresarBodega.Location = new Point(567, 129);
            aceptarIngresarBodega.Name = "aceptarIngresarBodega";
            aceptarIngresarBodega.Size = new Size(118, 33);
            aceptarIngresarBodega.TabIndex = 26;
            aceptarIngresarBodega.Text = "Aceptar";
            aceptarIngresarBodega.TextImageRelation = TextImageRelation.ImageBeforeText;
            aceptarIngresarBodega.UseVisualStyleBackColor = false;
            aceptarIngresarBodega.Click += aceptarIngresarBodega_Click;
            // 
            // cancelarIngresarBodega
            // 
            cancelarIngresarBodega.BackColor = Color.FromArgb(204, 102, 102);
            cancelarIngresarBodega.FlatAppearance.BorderColor = Color.FromArgb(154, 52, 52);
            cancelarIngresarBodega.FlatAppearance.BorderSize = 2;
            cancelarIngresarBodega.FlatAppearance.MouseDownBackColor = Color.FromArgb(154, 52, 52);
            cancelarIngresarBodega.FlatAppearance.MouseOverBackColor = Color.FromArgb(164, 62, 62);
            cancelarIngresarBodega.FlatStyle = FlatStyle.Flat;
            cancelarIngresarBodega.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancelarIngresarBodega.ForeColor = SystemColors.Control;
            cancelarIngresarBodega.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            cancelarIngresarBodega.IconColor = SystemColors.Control;
            cancelarIngresarBodega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cancelarIngresarBodega.IconSize = 28;
            cancelarIngresarBodega.Location = new Point(567, 168);
            cancelarIngresarBodega.Name = "cancelarIngresarBodega";
            cancelarIngresarBodega.Size = new Size(118, 33);
            cancelarIngresarBodega.TabIndex = 25;
            cancelarIngresarBodega.Text = "Cancelar";
            cancelarIngresarBodega.TextImageRelation = TextImageRelation.ImageBeforeText;
            cancelarIngresarBodega.UseVisualStyleBackColor = false;
            cancelarIngresarBodega.Click += cancelarIngresarBodega_Click;
            // 
            // layoutPanelProducts
            // 
            layoutPanelProducts.AutoScroll = true;
            layoutPanelProducts.BackColor = Color.FromArgb(155, 164, 181);
            layoutPanelProducts.FlowDirection = FlowDirection.TopDown;
            layoutPanelProducts.Location = new Point(27, 108);
            layoutPanelProducts.Name = "layoutPanelProducts";
            layoutPanelProducts.Size = new Size(523, 269);
            layoutPanelProducts.TabIndex = 3;
            layoutPanelProducts.WrapContents = false;
            // 
            // boxProductsCreate
            // 
            boxProductsCreate.BackColor = Color.FromArgb(155, 164, 181);
            boxProductsCreate.BorderStyle = BorderStyle.FixedSingle;
            boxProductsCreate.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            boxProductsCreate.Location = new Point(25, 60);
            boxProductsCreate.Name = "boxProductsCreate";
            boxProductsCreate.Size = new Size(343, 27);
            boxProductsCreate.TabIndex = 2;
            boxProductsCreate.TextChanged += boxProductsCreate_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(25, 34);
            label5.Name = "label5";
            label5.Size = new Size(308, 23);
            label5.TabIndex = 1;
            label5.Text = "Cantidad de productos creados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(196, 390);
            label4.Name = "label4";
            label4.Size = new Size(222, 24);
            label4.TabIndex = 0;
            label4.Text = "Productos a bodega";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // entityCommand1
            // 
            entityCommand1.CommandTimeout = 0;
            entityCommand1.CommandTree = null;
            entityCommand1.Connection = null;
            entityCommand1.EnablePlanCaching = true;
            entityCommand1.Transaction = null;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.FromArgb(115, 124, 141);
            iconPictureBox3.ForeColor = Color.Black;
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Question;
            iconPictureBox3.IconColor = Color.Black;
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 24;
            iconPictureBox3.Location = new Point(661, 433);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(24, 26);
            iconPictureBox3.TabIndex = 27;
            iconPictureBox3.TabStop = false;
            iconPictureBox3.Click += iconPictureBox3_Click;
            // 
            // FormProduccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 477);
            Controls.Add(panel1);
            Name = "FormProduccion";
            Text = "FormProduccion";
            panel1.ResumeLayout(false);
            tabControlProduccion.ResumeLayout(false);
            viewButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)HelpBTHistory).EndInit();
            tabHistory.ResumeLayout(false);
            tabProduccionActual.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            tabIngresarProduccion.ResumeLayout(false);
            tabIngresarProduccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            tabBodega.ResumeLayout(false);
            tabBodega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabPage viewButtons;
        private TabPage tabHistory;
        private ContextMenuStrip contextMenuStrip1;
        private TabPage tabProduccionActual;
        private TabPage tabIngresarProduccion;
        private Model.BT btIngresarProduccion;
        private Model.BT btViewProduccion;
        private Model.BT bt1;
        private FlowLayoutPanel LayoutHistorial;
        private FlowLayoutPanel flowLayoutPanel1;
        private DateTimePicker dateAddProduccion;
        private TextBox textBoxCantidad;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanelBox;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private Label label3;
        private TextBox txtName;
        private FlowLayoutPanel layoutPanelActualProduccion;
        private TabPage tabBodega;
        private FlowLayoutPanel layoutPanelProducts;
        private TextBox boxProductsCreate;
        private Label label5;
        private Label label4;
        private FontAwesome.Sharp.IconButton volverBtn;
        private TabControlEx tabControlProduccion;
        private FontAwesome.Sharp.IconButton volerProdActual;
        private FontAwesome.Sharp.IconButton aceptarIngresar;
        private FontAwesome.Sharp.IconButton cancelarIngresar;
        private FontAwesome.Sharp.IconButton aceptarIngresarBodega;
        private FontAwesome.Sharp.IconButton cancelarIngresarBodega;
        private FontAwesome.Sharp.IconPictureBox HelpBTHistory;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
    }
}
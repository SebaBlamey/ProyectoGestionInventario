namespace aadea.Vistas
{
    partial class FormMateriales
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
            tabControl1 = new TabControl();
            ListaMateriales = new TabPage();
            add_iconButton = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            AddMaterial = new TabPage();
            pictureBox1 = new PictureBox();
            labelResultado = new Label();
            opcionBox = new ComboBox();
            label5 = new Label();
            lblStock = new Label();
            label3 = new Label();
            btExaminar = new Button();
            btCancel = new Button();
            btSave = new Button();
            txtStock = new TextBox();
            txtNameInsert = new TextBox();
            EditMaterial = new TabPage();
            picImagenModify = new PictureBox();
            btExaminMod = new Button();
            boxMedidaActual = new ComboBox();
            txtStockActual = new TextBox();
            txtNameActual = new TextBox();
            btCancelMod = new Button();
            btSaveMod = new Button();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl1.SuspendLayout();
            ListaMateriales.SuspendLayout();
            AddMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            EditMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagenModify).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ListaMateriales);
            tabControl1.Controls.Add(AddMaterial);
            tabControl1.Controls.Add(EditMaterial);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.ShowToolTips = true;
            tabControl1.Size = new Size(691, 486);
            tabControl1.TabIndex = 0;
            // 
            // ListaMateriales
            // 
            ListaMateriales.Controls.Add(add_iconButton);
            ListaMateriales.Controls.Add(flowLayoutPanel1);
            ListaMateriales.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ListaMateriales.ForeColor = Color.Black;
            ListaMateriales.Location = new Point(4, 24);
            ListaMateriales.Name = "ListaMateriales";
            ListaMateriales.Padding = new Padding(3);
            ListaMateriales.Size = new Size(683, 458);
            ListaMateriales.TabIndex = 0;
            ListaMateriales.Text = "Materiales";
            ListaMateriales.UseVisualStyleBackColor = true;
            // 
            // add_iconButton
            // 
            add_iconButton.BackColor = Color.FromArgb(40, 167, 69);
            add_iconButton.Cursor = Cursors.Hand;
            add_iconButton.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 29);
            add_iconButton.FlatAppearance.BorderSize = 2;
            add_iconButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 127, 29);
            add_iconButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 147, 49);
            add_iconButton.FlatStyle = FlatStyle.Flat;
            add_iconButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            add_iconButton.ForeColor = SystemColors.Control;
            add_iconButton.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            add_iconButton.IconColor = SystemColors.Control;
            add_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            add_iconButton.IconSize = 28;
            add_iconButton.ImageAlign = ContentAlignment.TopCenter;
            add_iconButton.Location = new Point(564, 400);
            add_iconButton.Name = "add_iconButton";
            add_iconButton.Size = new Size(106, 33);
            add_iconButton.TabIndex = 17;
            add_iconButton.Text = "Agregar";
            add_iconButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            add_iconButton.UseVisualStyleBackColor = false;
            add_iconButton.Click += add_iconButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanel1.ForeColor = Color.Black;
            flowLayoutPanel1.Location = new Point(12, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(658, 388);
            flowLayoutPanel1.TabIndex = 16;
            // 
            // AddMaterial
            // 
            AddMaterial.BackColor = SystemColors.Control;
            AddMaterial.Controls.Add(pictureBox1);
            AddMaterial.Controls.Add(labelResultado);
            AddMaterial.Controls.Add(opcionBox);
            AddMaterial.Controls.Add(label5);
            AddMaterial.Controls.Add(lblStock);
            AddMaterial.Controls.Add(label3);
            AddMaterial.Controls.Add(btExaminar);
            AddMaterial.Controls.Add(btCancel);
            AddMaterial.Controls.Add(btSave);
            AddMaterial.Controls.Add(txtStock);
            AddMaterial.Controls.Add(txtNameInsert);
            AddMaterial.Location = new Point(4, 24);
            AddMaterial.Name = "AddMaterial";
            AddMaterial.Padding = new Padding(3);
            AddMaterial.Size = new Size(683, 458);
            AddMaterial.TabIndex = 1;
            AddMaterial.Text = "Agregar Material";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(345, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(39, 212);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 12;
            // 
            // opcionBox
            // 
            opcionBox.DropDownStyle = ComboBoxStyle.DropDownList;
            opcionBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            opcionBox.ForeColor = Color.Black;
            opcionBox.FormattingEnabled = true;
            opcionBox.Location = new Point(150, 172);
            opcionBox.Name = "opcionBox";
            opcionBox.Size = new Size(93, 23);
            opcionBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(150, 140);
            label5.Name = "label5";
            label5.Size = new Size(70, 24);
            label5.TabIndex = 10;
            label5.Text = "Unidad";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStock.ForeColor = Color.Black;
            lblStock.Location = new Point(36, 140);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(56, 24);
            lblStock.TabIndex = 9;
            lblStock.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(39, 53);
            label3.Name = "label3";
            label3.Size = new Size(79, 24);
            label3.TabIndex = 7;
            label3.Text = "Nombre";
            // 
            // btExaminar
            // 
            btExaminar.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btExaminar.ForeColor = Color.Black;
            btExaminar.Location = new Point(372, 233);
            btExaminar.Name = "btExaminar";
            btExaminar.Size = new Size(98, 23);
            btExaminar.TabIndex = 6;
            btExaminar.Text = "Examinar";
            btExaminar.UseVisualStyleBackColor = true;
            btExaminar.Click += btExaminar_Click;
            // 
            // btCancel
            // 
            btCancel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btCancel.ForeColor = Color.Black;
            btCancel.Location = new Point(145, 255);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(75, 23);
            btCancel.TabIndex = 5;
            btCancel.Text = "Cancelar";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // btSave
            // 
            btSave.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btSave.ForeColor = Color.Black;
            btSave.Location = new Point(36, 255);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 23);
            btSave.TabIndex = 4;
            btSave.Text = "Guardar";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.ForeColor = Color.Black;
            txtStock.Location = new Point(36, 175);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(72, 21);
            txtStock.TabIndex = 1;
            txtStock.KeyPress += txtStock_KeyPress;
            // 
            // txtNameInsert
            // 
            txtNameInsert.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNameInsert.ForeColor = Color.Black;
            txtNameInsert.Location = new Point(39, 81);
            txtNameInsert.Name = "txtNameInsert";
            txtNameInsert.Size = new Size(181, 21);
            txtNameInsert.TabIndex = 0;
            // 
            // EditMaterial
            // 
            EditMaterial.BackColor = SystemColors.Control;
            EditMaterial.Controls.Add(picImagenModify);
            EditMaterial.Controls.Add(btExaminMod);
            EditMaterial.Controls.Add(boxMedidaActual);
            EditMaterial.Controls.Add(txtStockActual);
            EditMaterial.Controls.Add(txtNameActual);
            EditMaterial.Controls.Add(btCancelMod);
            EditMaterial.Controls.Add(btSaveMod);
            EditMaterial.Controls.Add(label7);
            EditMaterial.Controls.Add(label6);
            EditMaterial.Controls.Add(label4);
            EditMaterial.Location = new Point(4, 24);
            EditMaterial.Name = "EditMaterial";
            EditMaterial.Size = new Size(683, 458);
            EditMaterial.TabIndex = 2;
            EditMaterial.Text = "Modificar Material";
            // 
            // picImagenModify
            // 
            picImagenModify.BorderStyle = BorderStyle.FixedSingle;
            picImagenModify.Location = new Point(379, 74);
            picImagenModify.Name = "picImagenModify";
            picImagenModify.Size = new Size(153, 158);
            picImagenModify.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagenModify.TabIndex = 13;
            picImagenModify.TabStop = false;
            // 
            // btExaminMod
            // 
            btExaminMod.Location = new Point(418, 238);
            btExaminMod.Name = "btExaminMod";
            btExaminMod.Size = new Size(75, 23);
            btExaminMod.TabIndex = 12;
            btExaminMod.Text = "Examinar";
            btExaminMod.UseVisualStyleBackColor = true;
            btExaminMod.Click += btExaminMod_Click;
            // 
            // boxMedidaActual
            // 
            boxMedidaActual.DropDownStyle = ComboBoxStyle.DropDownList;
            boxMedidaActual.ForeColor = Color.Black;
            boxMedidaActual.FormattingEnabled = true;
            boxMedidaActual.Location = new Point(186, 179);
            boxMedidaActual.Name = "boxMedidaActual";
            boxMedidaActual.Size = new Size(121, 23);
            boxMedidaActual.TabIndex = 10;
            // 
            // txtStockActual
            // 
            txtStockActual.ForeColor = Color.Black;
            txtStockActual.Location = new Point(41, 179);
            txtStockActual.Name = "txtStockActual";
            txtStockActual.Size = new Size(125, 23);
            txtStockActual.TabIndex = 9;
            txtStockActual.KeyPress += txtStockActual_KeyPress;
            // 
            // txtNameActual
            // 
            txtNameActual.ForeColor = Color.Black;
            txtNameActual.Location = new Point(41, 74);
            txtNameActual.Name = "txtNameActual";
            txtNameActual.Size = new Size(251, 23);
            txtNameActual.TabIndex = 8;
            // 
            // btCancelMod
            // 
            btCancelMod.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btCancelMod.ForeColor = Color.Black;
            btCancelMod.Location = new Point(186, 256);
            btCancelMod.Name = "btCancelMod";
            btCancelMod.Size = new Size(75, 23);
            btCancelMod.TabIndex = 6;
            btCancelMod.Text = "Cancelar";
            btCancelMod.UseVisualStyleBackColor = true;
            btCancelMod.Click += btCancelMod_Click;
            // 
            // btSaveMod
            // 
            btSaveMod.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btSaveMod.ForeColor = Color.Black;
            btSaveMod.Location = new Point(91, 256);
            btSaveMod.Name = "btSaveMod";
            btSaveMod.Size = new Size(75, 23);
            btSaveMod.TabIndex = 5;
            btSaveMod.Text = "Guardar";
            btSaveMod.UseVisualStyleBackColor = true;
            btSaveMod.Click += btSaveMod_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(186, 146);
            label7.Name = "label7";
            label7.Size = new Size(70, 24);
            label7.TabIndex = 2;
            label7.Text = "Unidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(41, 146);
            label6.Name = "label6";
            label6.Size = new Size(110, 24);
            label6.TabIndex = 1;
            label6.Text = "Stock actual";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(41, 33);
            label4.Name = "label4";
            label4.Size = new Size(133, 24);
            label4.TabIndex = 0;
            label4.Text = "Nombre actual";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FormMateriales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 486);
            Controls.Add(tabControl1);
            Name = "FormMateriales";
            Text = "FormMateriales";
            Load += FormMaterials_Load;
            tabControl1.ResumeLayout(false);
            ListaMateriales.ResumeLayout(false);
            AddMaterial.ResumeLayout(false);
            AddMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            EditMaterial.ResumeLayout(false);
            EditMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picImagenModify).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage ListaMateriales;
        private TabPage AddMaterial;
        private TabPage EditMaterial;
        private ContextMenuStrip contextMenuStrip1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private Button btExaminar;
        private Button btCancel;
        private Button btSave;
        private TextBox txtStock;
        private TextBox txtNameInsert;
        private Label label5;
        private Label lblStock;
        private ComboBox opcionBox;
        private Label labelResultado;
        private ComboBox boxMedidaActual;
        private TextBox txtStockActual;
        private TextBox txtNameActual;
        private Button btCancelMod;
        private Button btSaveMod;
        private Label label7;
        private Label label6;
        private Label label4;
        private Button btExaminMod;
        private FontAwesome.Sharp.IconButton add_iconButton;
        private PictureBox picImagenModify;
        private PictureBox pictureBox1;
    }
}
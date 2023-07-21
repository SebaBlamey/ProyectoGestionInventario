using aadea.Extras;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMateriales));
            tabControl1 = new TabControlEx();
            ListaMateriales = new TabPage();
            add_iconButton = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            AddMaterial = new TabPage();
            label8 = new Label();
            label2 = new Label();
            label1 = new Label();
            save_iconBtn = new FontAwesome.Sharp.IconButton();
            cancelAdd_btn = new FontAwesome.Sharp.IconButton();
            iconBtnExaminar = new FontAwesome.Sharp.IconButton();
            picAdd = new PictureBox();
            labelResultado = new Label();
            opcionBox = new ComboBox();
            label5 = new Label();
            lblStock = new Label();
            label3 = new Label();
            txtStock = new TextBox();
            txtNameInsert = new TextBox();
            EditMaterial = new TabPage();
            saveBtnEdit = new FontAwesome.Sharp.IconButton();
            deleteBtnEdit = new FontAwesome.Sharp.IconButton();
            searchBtnMod = new FontAwesome.Sharp.IconButton();
            picImagenModify = new PictureBox();
            boxMedidaActual = new ComboBox();
            txtStockActual = new TextBox();
            txtNameActual = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl1.SuspendLayout();
            ListaMateriales.SuspendLayout();
            AddMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAdd).BeginInit();
            EditMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagenModify).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(ListaMateriales);
            tabControl1.Controls.Add(AddMaterial);
            tabControl1.Controls.Add(EditMaterial);
            tabControl1.Dock = DockStyle.Top;
            tabControl1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.ImeMode = ImeMode.On;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(0);
            tabControl1.Name = "tabControl1";
            tabControl1.Padding = new Point(0, 0);
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(699, 474);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 2;
            // 
            // ListaMateriales
            // 
            ListaMateriales.BackColor = Color.FromArgb(115, 124, 141);
            ListaMateriales.BackgroundImageLayout = ImageLayout.None;
            ListaMateriales.Controls.Add(add_iconButton);
            ListaMateriales.Controls.Add(flowLayoutPanel1);
            ListaMateriales.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ListaMateriales.ForeColor = Color.Black;
            ListaMateriales.Location = new Point(-2, 26);
            ListaMateriales.Name = "ListaMateriales";
            ListaMateriales.Padding = new Padding(3);
            ListaMateriales.Size = new Size(703, 450);
            ListaMateriales.TabIndex = 0;
            ListaMateriales.Text = "Materiales";
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
            add_iconButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            add_iconButton.ForeColor = SystemColors.Control;
            add_iconButton.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            add_iconButton.IconColor = SystemColors.Control;
            add_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            add_iconButton.IconSize = 28;
            add_iconButton.ImageAlign = ContentAlignment.TopCenter;
            add_iconButton.Location = new Point(552, 400);
            add_iconButton.Name = "add_iconButton";
            add_iconButton.Size = new Size(118, 33);
            add_iconButton.TabIndex = 17;
            add_iconButton.Text = "Agregar";
            add_iconButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            add_iconButton.UseVisualStyleBackColor = false;
            add_iconButton.Click += add_iconButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanel1.ForeColor = Color.Black;
            flowLayoutPanel1.Location = new Point(12, 6);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(658, 388);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // AddMaterial
            // 
            AddMaterial.BackColor = Color.FromArgb(115, 124, 141);
            AddMaterial.Controls.Add(label8);
            AddMaterial.Controls.Add(label2);
            AddMaterial.Controls.Add(label1);
            AddMaterial.Controls.Add(save_iconBtn);
            AddMaterial.Controls.Add(cancelAdd_btn);
            AddMaterial.Controls.Add(iconBtnExaminar);
            AddMaterial.Controls.Add(picAdd);
            AddMaterial.Controls.Add(labelResultado);
            AddMaterial.Controls.Add(opcionBox);
            AddMaterial.Controls.Add(label5);
            AddMaterial.Controls.Add(lblStock);
            AddMaterial.Controls.Add(label3);
            AddMaterial.Controls.Add(txtStock);
            AddMaterial.Controls.Add(txtNameInsert);
            AddMaterial.Location = new Point(-2, 26);
            AddMaterial.Name = "AddMaterial";
            AddMaterial.Padding = new Padding(3);
            AddMaterial.Size = new Size(703, 450);
            AddMaterial.TabIndex = 1;
            AddMaterial.Text = "Agregar Material";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(256, 140);
            label8.Name = "label8";
            label8.Size = new Size(18, 23);
            label8.TabIndex = 19;
            label8.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(92, 140);
            label2.Name = "label2";
            label2.Size = new Size(18, 23);
            label2.TabIndex = 18;
            label2.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(125, 53);
            label1.Name = "label1";
            label1.Size = new Size(18, 23);
            label1.TabIndex = 17;
            label1.Text = "*";
            // 
            // save_iconBtn
            // 
            save_iconBtn.BackColor = Color.FromArgb(40, 167, 69);
            save_iconBtn.Cursor = Cursors.Hand;
            save_iconBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 29);
            save_iconBtn.FlatAppearance.BorderSize = 2;
            save_iconBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 127, 29);
            save_iconBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 147, 49);
            save_iconBtn.FlatStyle = FlatStyle.Flat;
            save_iconBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            save_iconBtn.ForeColor = SystemColors.Control;
            save_iconBtn.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            save_iconBtn.IconColor = SystemColors.Control;
            save_iconBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            save_iconBtn.IconSize = 28;
            save_iconBtn.Location = new Point(39, 247);
            save_iconBtn.Name = "save_iconBtn";
            save_iconBtn.Size = new Size(118, 33);
            save_iconBtn.TabIndex = 16;
            save_iconBtn.Text = "Guardar";
            save_iconBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            save_iconBtn.UseVisualStyleBackColor = false;
            save_iconBtn.Click += save_iconBtn_Click;
            // 
            // cancelAdd_btn
            // 
            cancelAdd_btn.BackColor = Color.FromArgb(204, 102, 102);
            cancelAdd_btn.Cursor = Cursors.Hand;
            cancelAdd_btn.FlatAppearance.BorderColor = Color.FromArgb(154, 52, 52);
            cancelAdd_btn.FlatAppearance.BorderSize = 2;
            cancelAdd_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(154, 52, 52);
            cancelAdd_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(164, 62, 62);
            cancelAdd_btn.FlatStyle = FlatStyle.Flat;
            cancelAdd_btn.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancelAdd_btn.ForeColor = SystemColors.Control;
            cancelAdd_btn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            cancelAdd_btn.IconColor = SystemColors.Control;
            cancelAdd_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cancelAdd_btn.IconSize = 28;
            cancelAdd_btn.Location = new Point(178, 247);
            cancelAdd_btn.Name = "cancelAdd_btn";
            cancelAdd_btn.Size = new Size(118, 33);
            cancelAdd_btn.TabIndex = 15;
            cancelAdd_btn.Text = "Cancelar";
            cancelAdd_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            cancelAdd_btn.UseVisualStyleBackColor = false;
            cancelAdd_btn.Click += cancelAdd_btn_Click;
            // 
            // iconBtnExaminar
            // 
            iconBtnExaminar.BackColor = Color.FromArgb(217, 145, 0);
            iconBtnExaminar.Cursor = Cursors.Hand;
            iconBtnExaminar.FlatAppearance.BorderColor = Color.FromArgb(177, 105, 0);
            iconBtnExaminar.FlatAppearance.BorderSize = 2;
            iconBtnExaminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(177, 105, 0);
            iconBtnExaminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(197, 125, 0);
            iconBtnExaminar.FlatStyle = FlatStyle.Flat;
            iconBtnExaminar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconBtnExaminar.ForeColor = SystemColors.Control;
            iconBtnExaminar.IconChar = FontAwesome.Sharp.IconChar.Images;
            iconBtnExaminar.IconColor = SystemColors.Control;
            iconBtnExaminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconBtnExaminar.IconSize = 28;
            iconBtnExaminar.Location = new Point(381, 201);
            iconBtnExaminar.Name = "iconBtnExaminar";
            iconBtnExaminar.Size = new Size(118, 33);
            iconBtnExaminar.TabIndex = 14;
            iconBtnExaminar.Text = "Examinar";
            iconBtnExaminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnExaminar.UseVisualStyleBackColor = false;
            iconBtnExaminar.Click += iconBtnExaminar_Click;
            // 
            // picAdd
            // 
            picAdd.BackColor = Color.FromArgb(155, 164, 181);
            picAdd.Location = new Point(364, 37);
            picAdd.Name = "picAdd";
            picAdd.Size = new Size(153, 158);
            picAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            picAdd.TabIndex = 13;
            picAdd.TabStop = false;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(39, 212);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 20);
            labelResultado.TabIndex = 12;
            // 
            // opcionBox
            // 
            opcionBox.BackColor = Color.FromArgb(155, 164, 181);
            opcionBox.DropDownStyle = ComboBoxStyle.DropDownList;
            opcionBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            opcionBox.ForeColor = Color.Black;
            opcionBox.FormattingEnabled = true;
            opcionBox.Location = new Point(184, 172);
            opcionBox.Name = "opcionBox";
            opcionBox.Size = new Size(112, 29);
            opcionBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(184, 140);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 10;
            label5.Text = "Unidad";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblStock.ForeColor = Color.White;
            lblStock.Location = new Point(36, 140);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(61, 23);
            lblStock.TabIndex = 9;
            lblStock.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(39, 53);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 7;
            label3.Text = "Nombre";
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.FromArgb(155, 164, 181);
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.ForeColor = Color.Black;
            txtStock.Location = new Point(39, 174);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(104, 27);
            txtStock.TabIndex = 1;
            txtStock.KeyPress += txtStock_KeyPress;
            // 
            // txtNameInsert
            // 
            txtNameInsert.BackColor = Color.FromArgb(155, 164, 181);
            txtNameInsert.BorderStyle = BorderStyle.FixedSingle;
            txtNameInsert.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNameInsert.ForeColor = Color.Black;
            txtNameInsert.Location = new Point(39, 81);
            txtNameInsert.Name = "txtNameInsert";
            txtNameInsert.Size = new Size(257, 27);
            txtNameInsert.TabIndex = 0;
            // 
            // EditMaterial
            // 
            EditMaterial.BackColor = Color.FromArgb(115, 124, 141);
            EditMaterial.Controls.Add(saveBtnEdit);
            EditMaterial.Controls.Add(deleteBtnEdit);
            EditMaterial.Controls.Add(searchBtnMod);
            EditMaterial.Controls.Add(picImagenModify);
            EditMaterial.Controls.Add(boxMedidaActual);
            EditMaterial.Controls.Add(txtStockActual);
            EditMaterial.Controls.Add(txtNameActual);
            EditMaterial.Controls.Add(label7);
            EditMaterial.Controls.Add(label6);
            EditMaterial.Controls.Add(label4);
            EditMaterial.Location = new Point(-2, 26);
            EditMaterial.Name = "EditMaterial";
            EditMaterial.Size = new Size(703, 450);
            EditMaterial.TabIndex = 2;
            EditMaterial.Text = "Modificar Material";
            // 
            // saveBtnEdit
            // 
            saveBtnEdit.BackColor = Color.FromArgb(40, 167, 69);
            saveBtnEdit.Cursor = Cursors.Hand;
            saveBtnEdit.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 29);
            saveBtnEdit.FlatAppearance.BorderSize = 2;
            saveBtnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 127, 29);
            saveBtnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 147, 49);
            saveBtnEdit.FlatStyle = FlatStyle.Flat;
            saveBtnEdit.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtnEdit.ForeColor = SystemColors.Control;
            saveBtnEdit.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            saveBtnEdit.IconColor = SystemColors.Control;
            saveBtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            saveBtnEdit.IconSize = 28;
            saveBtnEdit.Location = new Point(39, 247);
            saveBtnEdit.Name = "saveBtnEdit";
            saveBtnEdit.Size = new Size(118, 33);
            saveBtnEdit.TabIndex = 19;
            saveBtnEdit.Text = "Guardar";
            saveBtnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            saveBtnEdit.UseVisualStyleBackColor = false;
            saveBtnEdit.Click += saveBtnEdit_Click;
            // 
            // deleteBtnEdit
            // 
            deleteBtnEdit.BackColor = Color.FromArgb(204, 102, 102);
            deleteBtnEdit.Cursor = Cursors.Hand;
            deleteBtnEdit.FlatAppearance.BorderColor = Color.FromArgb(154, 52, 52);
            deleteBtnEdit.FlatAppearance.BorderSize = 2;
            deleteBtnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(154, 52, 52);
            deleteBtnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(164, 62, 62);
            deleteBtnEdit.FlatStyle = FlatStyle.Flat;
            deleteBtnEdit.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            deleteBtnEdit.ForeColor = SystemColors.Control;
            deleteBtnEdit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            deleteBtnEdit.IconColor = SystemColors.Control;
            deleteBtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            deleteBtnEdit.IconSize = 28;
            deleteBtnEdit.Location = new Point(178, 247);
            deleteBtnEdit.Name = "deleteBtnEdit";
            deleteBtnEdit.Size = new Size(118, 33);
            deleteBtnEdit.TabIndex = 18;
            deleteBtnEdit.Text = "Cancelar";
            deleteBtnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            deleteBtnEdit.UseVisualStyleBackColor = false;
            deleteBtnEdit.Click += deleteBtnEdit_Click;
            // 
            // searchBtnMod
            // 
            searchBtnMod.BackColor = Color.FromArgb(217, 145, 0);
            searchBtnMod.Cursor = Cursors.Hand;
            searchBtnMod.FlatAppearance.BorderColor = Color.FromArgb(177, 105, 0);
            searchBtnMod.FlatAppearance.BorderSize = 2;
            searchBtnMod.FlatAppearance.MouseDownBackColor = Color.FromArgb(177, 105, 0);
            searchBtnMod.FlatAppearance.MouseOverBackColor = Color.FromArgb(197, 125, 0);
            searchBtnMod.FlatStyle = FlatStyle.Flat;
            searchBtnMod.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            searchBtnMod.ForeColor = SystemColors.Control;
            searchBtnMod.IconChar = FontAwesome.Sharp.IconChar.Images;
            searchBtnMod.IconColor = SystemColors.Control;
            searchBtnMod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            searchBtnMod.IconSize = 28;
            searchBtnMod.Location = new Point(381, 201);
            searchBtnMod.Name = "searchBtnMod";
            searchBtnMod.Size = new Size(118, 33);
            searchBtnMod.TabIndex = 17;
            searchBtnMod.Text = "Examinar";
            searchBtnMod.TextImageRelation = TextImageRelation.ImageBeforeText;
            searchBtnMod.UseVisualStyleBackColor = false;
            searchBtnMod.Click += searchBtnMod_Click;
            // 
            // picImagenModify
            // 
            picImagenModify.BackColor = Color.Transparent;
            picImagenModify.BorderStyle = BorderStyle.FixedSingle;
            picImagenModify.Location = new Point(364, 37);
            picImagenModify.Name = "picImagenModify";
            picImagenModify.Size = new Size(153, 158);
            picImagenModify.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagenModify.TabIndex = 13;
            picImagenModify.TabStop = false;
            // 
            // boxMedidaActual
            // 
            boxMedidaActual.DropDownStyle = ComboBoxStyle.DropDownList;
            boxMedidaActual.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            boxMedidaActual.ForeColor = Color.Black;
            boxMedidaActual.FormattingEnabled = true;
            boxMedidaActual.Location = new Point(186, 172);
            boxMedidaActual.Name = "boxMedidaActual";
            boxMedidaActual.Size = new Size(121, 29);
            boxMedidaActual.TabIndex = 10;
            // 
            // txtStockActual
            // 
            txtStockActual.BackColor = Color.FromArgb(155, 164, 181);
            txtStockActual.BorderStyle = BorderStyle.FixedSingle;
            txtStockActual.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtStockActual.ForeColor = Color.Black;
            txtStockActual.Location = new Point(39, 174);
            txtStockActual.Name = "txtStockActual";
            txtStockActual.Size = new Size(104, 27);
            txtStockActual.TabIndex = 9;
            txtStockActual.KeyPress += txtStockActual_KeyPress;
            // 
            // txtNameActual
            // 
            txtNameActual.BackColor = Color.FromArgb(155, 164, 181);
            txtNameActual.BorderStyle = BorderStyle.FixedSingle;
            txtNameActual.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNameActual.ForeColor = Color.Black;
            txtNameActual.Location = new Point(39, 81);
            txtNameActual.Name = "txtNameActual";
            txtNameActual.Size = new Size(251, 27);
            txtNameActual.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(186, 140);
            label7.Name = "label7";
            label7.Size = new Size(78, 23);
            label7.TabIndex = 2;
            label7.Text = "Unidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(36, 140);
            label6.Name = "label6";
            label6.Size = new Size(126, 23);
            label6.TabIndex = 1;
            label6.Text = "Stock actual";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(39, 53);
            label4.Name = "label4";
            label4.Size = new Size(150, 23);
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
            BackColor = Color.FromArgb(155, 164, 181);
            ClientSize = new Size(699, 519);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMateriales";
            Text = "FormMateriales";
            Load += FormMaterials_Load;
            tabControl1.ResumeLayout(false);
            ListaMateriales.ResumeLayout(false);
            AddMaterial.ResumeLayout(false);
            AddMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAdd).EndInit();
            EditMaterial.ResumeLayout(false);
            EditMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picImagenModify).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabPage ListaMateriales;
        private TabPage AddMaterial;
        private TabPage EditMaterial;
        private ContextMenuStrip contextMenuStrip1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private TextBox txtStock;
        private TextBox txtNameInsert;
        private Label label5;
        private Label lblStock;
        private ComboBox opcionBox;
        private Label labelResultado;
        private ComboBox boxMedidaActual;
        private TextBox txtStockActual;
        private TextBox txtNameActual;
        private Label label7;
        private Label label6;
        private Label label4;
        private FontAwesome.Sharp.IconButton add_iconButton;
        private PictureBox picImagenModify;
        private PictureBox picAdd;
        private TabControlEx tabControl1;
        private FontAwesome.Sharp.IconButton save_iconBtn;
        private FontAwesome.Sharp.IconButton cancelAdd_btn;
        private FontAwesome.Sharp.IconButton iconBtnExaminar;
        private FontAwesome.Sharp.IconButton saveBtnEdit;
        private FontAwesome.Sharp.IconButton deleteBtnEdit;
        private FontAwesome.Sharp.IconButton searchBtnMod;
        private Label label2;
        private Label label1;
        private Label label8;
    }
}
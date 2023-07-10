namespace aadea.Vistas
{
    partial class FormTrabajadores
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DGV_T = new DataGridView();
            tabControlE = new TabControl();
            employeList = new TabPage();
            delete_iconButton = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            AddProduct = new FontAwesome.Sharp.IconButton();
            addE = new TabPage();
            CancelBtn = new Button();
            SaveBtn = new Button();
            textBoxPhNum = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxAddress = new TextBox();
            textBoxSurname = new TextBox();
            textBoxName = new TextBox();
            textBoxRut = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DGV_T).BeginInit();
            tabControlE.SuspendLayout();
            employeList.SuspendLayout();
            addE.SuspendLayout();
            SuspendLayout();
            // 
            // DGV_T
            // 
            DGV_T.AllowUserToAddRows = false;
            DGV_T.AllowUserToResizeColumns = false;
            DGV_T.AllowUserToResizeRows = false;
            DGV_T.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_T.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_T.BackgroundColor = SystemColors.Control;
            DGV_T.BorderStyle = BorderStyle.None;
            DGV_T.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV_T.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 36, 53);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(33, 36, 53);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGV_T.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGV_T.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGV_T.EnableHeadersVisualStyles = false;
            DGV_T.GridColor = Color.DarkBlue;
            DGV_T.Location = new Point(6, 6);
            DGV_T.Name = "DGV_T";
            DGV_T.ReadOnly = true;
            DGV_T.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGV_T.RowHeadersVisible = false;
            DGV_T.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.Plum;
            DGV_T.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DGV_T.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_T.Size = new Size(560, 375);
            DGV_T.TabIndex = 0;
            // 
            // tabControlE
            // 
            tabControlE.Controls.Add(employeList);
            tabControlE.Controls.Add(addE);
            tabControlE.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabControlE.Location = new Point(2, -1);
            tabControlE.Name = "tabControlE";
            tabControlE.SelectedIndex = 0;
            tabControlE.Size = new Size(689, 425);
            tabControlE.TabIndex = 1;
            // 
            // employeList
            // 
            employeList.BackColor = SystemColors.Control;
            employeList.Controls.Add(delete_iconButton);
            employeList.Controls.Add(iconButton1);
            employeList.Controls.Add(AddProduct);
            employeList.Controls.Add(DGV_T);
            employeList.Location = new Point(4, 29);
            employeList.Name = "employeList";
            employeList.Padding = new Padding(3);
            employeList.Size = new Size(681, 392);
            employeList.TabIndex = 0;
            employeList.Text = "Lista Trabajadores";
            employeList.Click += employeList_Click;
            // 
            // delete_iconButton
            // 
            delete_iconButton.BackColor = Color.Red;
            delete_iconButton.Cursor = Cursors.Hand;
            delete_iconButton.FlatAppearance.BorderColor = Color.FromArgb(204, 0, 0);
            delete_iconButton.FlatAppearance.BorderSize = 2;
            delete_iconButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(204, 0, 0);
            delete_iconButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(229, 0, 0);
            delete_iconButton.FlatStyle = FlatStyle.Flat;
            delete_iconButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            delete_iconButton.ForeColor = SystemColors.Control;
            delete_iconButton.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            delete_iconButton.IconColor = SystemColors.Control;
            delete_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            delete_iconButton.IconSize = 28;
            delete_iconButton.Location = new Point(572, 180);
            delete_iconButton.Name = "delete_iconButton";
            delete_iconButton.Size = new Size(106, 33);
            delete_iconButton.TabIndex = 13;
            delete_iconButton.Text = "Eliminar";
            delete_iconButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            delete_iconButton.UseVisualStyleBackColor = false;
            delete_iconButton.Click += delete_iconButton_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(53, 152, 220);
            iconButton1.FlatAppearance.BorderColor = Color.FromArgb(12, 98, 155);
            iconButton1.FlatAppearance.BorderSize = 2;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(12, 98, 155);
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 128, 185);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.ForeColor = SystemColors.Control;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PaintBrush;
            iconButton1.IconColor = SystemColors.Control;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 28;
            iconButton1.Location = new Point(572, 141);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(106, 33);
            iconButton1.TabIndex = 12;
            iconButton1.Text = "Modificar";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // AddProduct
            // 
            AddProduct.BackColor = Color.FromArgb(40, 167, 69);
            AddProduct.Cursor = Cursors.Hand;
            AddProduct.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 29);
            AddProduct.FlatAppearance.BorderSize = 2;
            AddProduct.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 127, 29);
            AddProduct.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 147, 49);
            AddProduct.FlatStyle = FlatStyle.Flat;
            AddProduct.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AddProduct.ForeColor = SystemColors.Control;
            AddProduct.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            AddProduct.IconColor = SystemColors.Control;
            AddProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddProduct.IconSize = 28;
            AddProduct.ImageAlign = ContentAlignment.TopCenter;
            AddProduct.Location = new Point(572, 102);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(106, 33);
            AddProduct.TabIndex = 11;
            AddProduct.Text = "Agregar";
            AddProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddProduct.UseVisualStyleBackColor = false;
            AddProduct.Click += AddProduct_Click;
            // 
            // addE
            // 
            addE.BackColor = Color.White;
            addE.Controls.Add(CancelBtn);
            addE.Controls.Add(SaveBtn);
            addE.Controls.Add(textBoxPhNum);
            addE.Controls.Add(label5);
            addE.Controls.Add(label4);
            addE.Controls.Add(label3);
            addE.Controls.Add(label2);
            addE.Controls.Add(label1);
            addE.Controls.Add(textBoxAddress);
            addE.Controls.Add(textBoxSurname);
            addE.Controls.Add(textBoxName);
            addE.Controls.Add(textBoxRut);
            addE.Location = new Point(4, 29);
            addE.Name = "addE";
            addE.Padding = new Padding(3);
            addE.Size = new Size(681, 392);
            addE.TabIndex = 1;
            addE.Text = "Agregar";
            addE.Click += addE_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CancelBtn.ForeColor = Color.Black;
            CancelBtn.Location = new Point(461, 247);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(89, 30);
            CancelBtn.TabIndex = 11;
            CancelBtn.Text = "Cancelar";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SaveBtn.ForeColor = Color.Black;
            SaveBtn.Location = new Point(461, 167);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(89, 30);
            SaveBtn.TabIndex = 10;
            SaveBtn.Text = "Guardar";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // textBoxPhNum
            // 
            textBoxPhNum.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhNum.ForeColor = Color.Black;
            textBoxPhNum.Location = new Point(280, 254);
            textBoxPhNum.Name = "textBoxPhNum";
            textBoxPhNum.Size = new Size(100, 21);
            textBoxPhNum.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(280, 231);
            label5.Name = "label5";
            label5.Size = new Size(85, 24);
            label5.TabIndex = 8;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(280, 144);
            label4.Name = "label4";
            label4.Size = new Size(90, 24);
            label4.TabIndex = 7;
            label4.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(74, 231);
            label3.Name = "label3";
            label3.Size = new Size(79, 24);
            label3.TabIndex = 6;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(74, 144);
            label2.Name = "label2";
            label2.Size = new Size(79, 24);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(74, 59);
            label1.Name = "label1";
            label1.Size = new Size(38, 24);
            label1.TabIndex = 4;
            label1.Text = "Rut";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.ForeColor = Color.Black;
            textBoxAddress.Location = new Point(280, 172);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(100, 21);
            textBoxAddress.TabIndex = 3;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSurname.ForeColor = Color.Black;
            textBoxSurname.Location = new Point(74, 254);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(100, 21);
            textBoxSurname.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.ForeColor = Color.Black;
            textBoxName.Location = new Point(74, 171);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 21);
            textBoxName.TabIndex = 1;
            // 
            // textBoxRut
            // 
            textBoxRut.BackColor = Color.White;
            textBoxRut.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRut.ForeColor = Color.Black;
            textBoxRut.Location = new Point(74, 82);
            textBoxRut.Name = "textBoxRut";
            textBoxRut.Size = new Size(100, 21);
            textBoxRut.TabIndex = 0;
            // 
            // FormTrabajadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 421);
            Controls.Add(tabControlE);
            Name = "FormTrabajadores";
            Text = "FormTrabajadores";
            Load += FormTrabajadores_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_T).EndInit();
            tabControlE.ResumeLayout(false);
            employeList.ResumeLayout(false);
            addE.ResumeLayout(false);
            addE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_T;
        private TabControl tabControlE;
        private TabPage employeList;
        private TabPage addE;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxAddress;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private TextBox textBoxRut;
        private Label label5;
        private TextBox textBoxPhNum;
        private Button CancelBtn;
        private Button SaveBtn;
        private FontAwesome.Sharp.IconButton AddProduct;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton delete_iconButton;
    }
}
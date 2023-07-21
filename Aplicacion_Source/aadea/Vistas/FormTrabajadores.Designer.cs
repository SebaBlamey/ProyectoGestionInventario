using aadea.Extras;

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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrabajadores));
            DGV_T = new DataGridView();
            tabControlE = new TabControlEx();
            employeList = new TabPage();
            delete_iconButton = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            AddProduct = new FontAwesome.Sharp.IconButton();
            addE = new TabPage();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            trabajadoresDelete = new FontAwesome.Sharp.IconButton();
            trabajadoresAdd = new FontAwesome.Sharp.IconButton();
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
            DGV_T.BackgroundColor = Color.FromArgb(155, 164, 181);
            DGV_T.BorderStyle = BorderStyle.None;
            DGV_T.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV_T.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            DGV_T.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 36, 53);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(33, 36, 53);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGV_T.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGV_T.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGV_T.DefaultCellStyle = dataGridViewCellStyle2;
            DGV_T.EnableHeadersVisualStyles = false;
            DGV_T.GridColor = Color.FromArgb(115, 124, 141);
            DGV_T.Location = new Point(12, 6);
            DGV_T.Name = "DGV_T";
            DGV_T.ReadOnly = true;
            DGV_T.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGV_T.RowHeadersVisible = false;
            DGV_T.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(155, 164, 181);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(57, 72, 103);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(57, 72, 103);
            DGV_T.RowsDefaultCellStyle = dataGridViewCellStyle3;
            DGV_T.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_T.Size = new Size(503, 388);
            DGV_T.TabIndex = 0;
            // 
            // tabControlE
            // 
            tabControlE.Appearance = TabAppearance.FlatButtons;
            tabControlE.Controls.Add(employeList);
            tabControlE.Controls.Add(addE);
            tabControlE.Dock = DockStyle.Fill;
            tabControlE.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabControlE.ImeMode = ImeMode.On;
            tabControlE.Location = new Point(0, 0);
            tabControlE.Margin = new Padding(0);
            tabControlE.Name = "tabControlE";
            tabControlE.SelectedIndex = 0;
            tabControlE.Size = new Size(675, 477);
            tabControlE.SizeMode = TabSizeMode.Fixed;
            tabControlE.TabIndex = 1;
            // 
            // employeList
            // 
            employeList.BackColor = Color.FromArgb(115, 124, 141);
            employeList.Controls.Add(delete_iconButton);
            employeList.Controls.Add(iconButton1);
            employeList.Controls.Add(AddProduct);
            employeList.Controls.Add(DGV_T);
            employeList.Location = new Point(-2, 26);
            employeList.Name = "employeList";
            employeList.Padding = new Padding(3);
            employeList.Size = new Size(679, 453);
            employeList.TabIndex = 0;
            employeList.Text = "Lista Trabajadores";
            employeList.Click += employeList_Click;
            // 
            // delete_iconButton
            // 
            delete_iconButton.BackColor = Color.FromArgb(204, 102, 102);
            delete_iconButton.Cursor = Cursors.Hand;
            delete_iconButton.FlatAppearance.BorderColor = Color.FromArgb(154, 52, 52);
            delete_iconButton.FlatAppearance.BorderSize = 2;
            delete_iconButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(154, 52, 52);
            delete_iconButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(164, 62, 62);
            delete_iconButton.FlatStyle = FlatStyle.Flat;
            delete_iconButton.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            delete_iconButton.ForeColor = SystemColors.Control;
            delete_iconButton.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            delete_iconButton.IconColor = SystemColors.Control;
            delete_iconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            delete_iconButton.IconSize = 28;
            delete_iconButton.Location = new Point(572, 197);
            delete_iconButton.Name = "delete_iconButton";
            delete_iconButton.Size = new Size(118, 33);
            delete_iconButton.TabIndex = 13;
            delete_iconButton.Text = "Eliminar";
            delete_iconButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            delete_iconButton.UseVisualStyleBackColor = false;
            delete_iconButton.Click += delete_iconButton_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(121, 160, 191);
            iconButton1.FlatAppearance.BorderColor = Color.FromArgb(81, 120, 151);
            iconButton1.FlatAppearance.BorderSize = 2;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(81, 120, 151);
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(101, 140, 171);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = SystemColors.Control;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PaintBrush;
            iconButton1.IconColor = SystemColors.Control;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 28;
            iconButton1.Location = new Point(572, 158);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(118, 33);
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
            AddProduct.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddProduct.ForeColor = SystemColors.Control;
            AddProduct.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            AddProduct.IconColor = SystemColors.Control;
            AddProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddProduct.IconSize = 28;
            AddProduct.ImageAlign = ContentAlignment.TopCenter;
            AddProduct.Location = new Point(572, 119);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(118, 33);
            AddProduct.TabIndex = 11;
            AddProduct.Text = "Agregar";
            AddProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddProduct.UseVisualStyleBackColor = false;
            AddProduct.Click += AddProduct_Click;
            // 
            // addE
            // 
            addE.BackColor = Color.FromArgb(115, 124, 141);
            addE.Controls.Add(label8);
            addE.Controls.Add(label7);
            addE.Controls.Add(label6);
            addE.Controls.Add(trabajadoresDelete);
            addE.Controls.Add(trabajadoresAdd);
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
            addE.Location = new Point(-2, 26);
            addE.Name = "addE";
            addE.Padding = new Padding(3);
            addE.Size = new Size(679, 453);
            addE.TabIndex = 1;
            addE.Text = "Agregar";
            addE.Click += addE_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(324, 122);
            label8.Name = "label8";
            label8.Size = new Size(18, 23);
            label8.TabIndex = 14;
            label8.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(123, 122);
            label7.Name = "label7";
            label7.Size = new Size(18, 23);
            label7.TabIndex = 13;
            label7.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(76, 37);
            label6.Name = "label6";
            label6.Size = new Size(18, 23);
            label6.TabIndex = 12;
            label6.Text = "*";
            // 
            // trabajadoresDelete
            // 
            trabajadoresDelete.BackColor = Color.FromArgb(204, 102, 102);
            trabajadoresDelete.FlatAppearance.BorderColor = Color.FromArgb(154, 52, 52);
            trabajadoresDelete.FlatAppearance.BorderSize = 2;
            trabajadoresDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(154, 52, 52);
            trabajadoresDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(164, 62, 62);
            trabajadoresDelete.FlatStyle = FlatStyle.Flat;
            trabajadoresDelete.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            trabajadoresDelete.ForeColor = SystemColors.Control;
            trabajadoresDelete.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            trabajadoresDelete.IconColor = SystemColors.Control;
            trabajadoresDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            trabajadoresDelete.IconSize = 28;
            trabajadoresDelete.Location = new Point(563, 350);
            trabajadoresDelete.Name = "trabajadoresDelete";
            trabajadoresDelete.Size = new Size(118, 33);
            trabajadoresDelete.TabIndex = 11;
            trabajadoresDelete.Text = "Cancelar";
            trabajadoresDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            trabajadoresDelete.UseVisualStyleBackColor = false;
            trabajadoresDelete.Click += trabajadoresDelete_Click;
            // 
            // trabajadoresAdd
            // 
            trabajadoresAdd.BackColor = Color.FromArgb(40, 167, 69);
            trabajadoresAdd.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 29);
            trabajadoresAdd.FlatAppearance.BorderSize = 2;
            trabajadoresAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 127, 29);
            trabajadoresAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 147, 49);
            trabajadoresAdd.FlatStyle = FlatStyle.Flat;
            trabajadoresAdd.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            trabajadoresAdd.ForeColor = SystemColors.Control;
            trabajadoresAdd.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            trabajadoresAdd.IconColor = SystemColors.Control;
            trabajadoresAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            trabajadoresAdd.IconSize = 28;
            trabajadoresAdd.Location = new Point(432, 350);
            trabajadoresAdd.Name = "trabajadoresAdd";
            trabajadoresAdd.Size = new Size(118, 33);
            trabajadoresAdd.TabIndex = 11;
            trabajadoresAdd.Text = "Guardar";
            trabajadoresAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            trabajadoresAdd.UseVisualStyleBackColor = false;
            trabajadoresAdd.Click += trabajadoresAdd_Click;
            // 
            // textBoxPhNum
            // 
            textBoxPhNum.BackColor = Color.FromArgb(155, 164, 181);
            textBoxPhNum.BorderStyle = BorderStyle.FixedSingle;
            textBoxPhNum.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhNum.ForeColor = Color.Black;
            textBoxPhNum.Location = new Point(241, 239);
            textBoxPhNum.Name = "textBoxPhNum";
            textBoxPhNum.Size = new Size(169, 27);
            textBoxPhNum.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(241, 213);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 8;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(43, 213);
            label4.Name = "label4";
            label4.Size = new Size(98, 23);
            label4.TabIndex = 7;
            label4.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(241, 122);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 6;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(43, 122);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 37);
            label1.Name = "label1";
            label1.Size = new Size(38, 23);
            label1.TabIndex = 4;
            label1.Text = "Rut";
            // 
            // textBoxAddress
            // 
            textBoxAddress.BackColor = Color.FromArgb(155, 164, 181);
            textBoxAddress.BorderStyle = BorderStyle.FixedSingle;
            textBoxAddress.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAddress.ForeColor = Color.Black;
            textBoxAddress.Location = new Point(43, 239);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(169, 27);
            textBoxAddress.TabIndex = 3;
            // 
            // textBoxSurname
            // 
            textBoxSurname.BackColor = Color.FromArgb(155, 164, 181);
            textBoxSurname.BorderStyle = BorderStyle.FixedSingle;
            textBoxSurname.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSurname.ForeColor = Color.Black;
            textBoxSurname.Location = new Point(241, 148);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(169, 27);
            textBoxSurname.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.FromArgb(155, 164, 181);
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.ForeColor = Color.Black;
            textBoxName.Location = new Point(43, 148);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(169, 27);
            textBoxName.TabIndex = 1;
            // 
            // textBoxRut
            // 
            textBoxRut.BackColor = Color.FromArgb(155, 164, 181);
            textBoxRut.BorderStyle = BorderStyle.FixedSingle;
            textBoxRut.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRut.ForeColor = Color.Black;
            textBoxRut.Location = new Point(43, 63);
            textBoxRut.Name = "textBoxRut";
            textBoxRut.Size = new Size(169, 27);
            textBoxRut.TabIndex = 0;
            // 
            // FormTrabajadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(155, 164, 181);
            ClientSize = new Size(675, 477);
            Controls.Add(tabControlE);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private FontAwesome.Sharp.IconButton AddProduct;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton delete_iconButton;
        private TabControlEx tabControlE;
        private FontAwesome.Sharp.IconButton trabajadoresDelete;
        private FontAwesome.Sharp.IconButton trabajadoresAdd;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}
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
            DeleteBtn = new Button();
            EditBtn = new Button();
            AddBtn = new Button();
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
            DGV_T.BackgroundColor = Color.White;
            DGV_T.BorderStyle = BorderStyle.None;
            DGV_T.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV_T.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGV_T.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGV_T.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGV_T.EnableHeadersVisualStyles = false;
            DGV_T.GridColor = Color.DarkBlue;
            DGV_T.Location = new Point(6, 6);
            DGV_T.Name = "DGV_T";
            DGV_T.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGV_T.RowHeadersVisible = false;
            DGV_T.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.Plum;
            DGV_T.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DGV_T.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_T.Size = new Size(571, 208);
            DGV_T.TabIndex = 0;
            // 
            // tabControlE
            // 
            tabControlE.Controls.Add(employeList);
            tabControlE.Controls.Add(addE);
            tabControlE.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabControlE.Location = new Point(2, -1);
            tabControlE.Name = "tabControlE";
            tabControlE.SelectedIndex = 0;
            tabControlE.Size = new Size(689, 425);
            tabControlE.TabIndex = 1;
            // 
            // employeList
            // 
            employeList.Controls.Add(DeleteBtn);
            employeList.Controls.Add(EditBtn);
            employeList.Controls.Add(AddBtn);
            employeList.Controls.Add(DGV_T);
            employeList.Location = new Point(4, 28);
            employeList.Name = "employeList";
            employeList.Padding = new Padding(3);
            employeList.Size = new Size(681, 393);
            employeList.TabIndex = 0;
            employeList.Text = "Lista Trabajadores";
            employeList.UseVisualStyleBackColor = true;
            employeList.Click += employeList_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBtn.ForeColor = SystemColors.ActiveCaptionText;
            DeleteBtn.Location = new Point(583, 190);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(90, 28);
            DeleteBtn.TabIndex = 3;
            DeleteBtn.Text = "Eliminar";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            EditBtn.ForeColor = SystemColors.ActiveCaptionText;
            EditBtn.Location = new Point(583, 141);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(90, 28);
            EditBtn.TabIndex = 2;
            EditBtn.Text = "Editar";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.Transparent;
            AddBtn.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.ForeColor = SystemColors.ActiveCaptionText;
            AddBtn.Location = new Point(583, 95);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(90, 28);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Agregar";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
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
            addE.Location = new Point(4, 28);
            addE.Name = "addE";
            addE.Padding = new Padding(3);
            addE.Size = new Size(681, 393);
            addE.TabIndex = 1;
            addE.Text = "Agregar";
            addE.Click += addE_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
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
            SaveBtn.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
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
            textBoxPhNum.Location = new Point(280, 254);
            textBoxPhNum.Name = "textBoxPhNum";
            textBoxPhNum.Size = new Size(100, 27);
            textBoxPhNum.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(280, 231);
            label5.Name = "label5";
            label5.Size = new Size(87, 22);
            label5.TabIndex = 8;
            label5.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(280, 144);
            label4.Name = "label4";
            label4.Size = new Size(96, 22);
            label4.TabIndex = 7;
            label4.Text = "Direccion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(74, 231);
            label3.Name = "label3";
            label3.Size = new Size(84, 22);
            label3.TabIndex = 6;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(74, 144);
            label2.Name = "label2";
            label2.Size = new Size(84, 22);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(74, 59);
            label1.Name = "label1";
            label1.Size = new Size(41, 22);
            label1.TabIndex = 4;
            label1.Text = "Rut";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(280, 167);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(100, 27);
            textBoxAddress.TabIndex = 3;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(74, 254);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(100, 27);
            textBoxSurname.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(74, 167);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 27);
            textBoxName.TabIndex = 1;
            // 
            // textBoxRut
            // 
            textBoxRut.Location = new Point(74, 82);
            textBoxRut.Name = "textBoxRut";
            textBoxRut.Size = new Size(100, 27);
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
        private Button DeleteBtn;
        private Button EditBtn;
        private Button AddBtn;
        private Label label5;
        private TextBox textBoxPhNum;
        private Button CancelBtn;
        private Button SaveBtn;
    }
}
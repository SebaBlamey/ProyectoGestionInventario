namespace aadea.Vistas
{
    partial class FormAsistencia
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
            Principal = new TabControl();
            History = new TabPage();
            DeleteButton = new Button();
            EditButton = new Button();
            addButton = new Button();
            DGV_Asist = new DataGridView();
            Add = new TabPage();
            Ejemplo2 = new Label();
            Ejemplo1 = new Label();
            TotalsHours = new Label();
            label4 = new Label();
            CheckOut = new TextBox();
            CheckIn = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dateTimePickerFecha = new DateTimePicker();
            label1 = new Label();
            AddSave = new Button();
            DGV_Trabajador = new DataGridView();
            Edit = new TabPage();
            Delete = new TabPage();
            Principal.SuspendLayout();
            History.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Asist).BeginInit();
            Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Trabajador).BeginInit();
            SuspendLayout();
            // 
            // Principal
            // 
            Principal.Controls.Add(History);
            Principal.Controls.Add(Add);
            Principal.Controls.Add(Edit);
            Principal.Controls.Add(Delete);
            Principal.Dock = DockStyle.Fill;
            Principal.Font = new Font("Tahoma", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            Principal.Location = new Point(0, 0);
            Principal.Name = "Principal";
            Principal.SelectedIndex = 0;
            Principal.Size = new Size(689, 421);
            Principal.TabIndex = 0;
            // 
            // History
            // 
            History.Controls.Add(DeleteButton);
            History.Controls.Add(EditButton);
            History.Controls.Add(addButton);
            History.Controls.Add(DGV_Asist);
            History.Font = new Font("Tahoma", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            History.ForeColor = Color.Black;
            History.Location = new Point(4, 26);
            History.Name = "History";
            History.Padding = new Padding(3);
            History.Size = new Size(681, 391);
            History.TabIndex = 0;
            History.Text = "Historial";
            History.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteButton.Location = new Point(585, 217);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(90, 23);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Eliminar";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EditButton.Location = new Point(585, 166);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(90, 23);
            EditButton.TabIndex = 2;
            EditButton.Text = "Editar";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addButton.Location = new Point(585, 118);
            addButton.Name = "addButton";
            addButton.Size = new Size(90, 27);
            addButton.TabIndex = 1;
            addButton.Text = "Agregar";
            addButton.UseVisualStyleBackColor = true;
            // 
            // DGV_Asist
            // 
            DGV_Asist.AllowUserToOrderColumns = true;
            DGV_Asist.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_Asist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Asist.BackgroundColor = Color.White;
            DGV_Asist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGV_Asist.EditMode = DataGridViewEditMode.EditOnF2;
            DGV_Asist.Location = new Point(8, 6);
            DGV_Asist.Name = "DGV_Asist";
            DGV_Asist.RowTemplate.Height = 25;
            DGV_Asist.Size = new Size(571, 377);
            DGV_Asist.TabIndex = 0;
            // 
            // Add
            // 
            Add.Controls.Add(Ejemplo2);
            Add.Controls.Add(Ejemplo1);
            Add.Controls.Add(TotalsHours);
            Add.Controls.Add(label4);
            Add.Controls.Add(CheckOut);
            Add.Controls.Add(CheckIn);
            Add.Controls.Add(label3);
            Add.Controls.Add(label2);
            Add.Controls.Add(dateTimePickerFecha);
            Add.Controls.Add(label1);
            Add.Controls.Add(AddSave);
            Add.Controls.Add(DGV_Trabajador);
            Add.ForeColor = Color.Black;
            Add.Location = new Point(4, 26);
            Add.Name = "Add";
            Add.Padding = new Padding(3);
            Add.Size = new Size(681, 391);
            Add.TabIndex = 1;
            Add.Text = " Añadir";
            Add.UseVisualStyleBackColor = true;
            // 
            // Ejemplo2
            // 
            Ejemplo2.AutoSize = true;
            Ejemplo2.Location = new Point(563, 231);
            Ejemplo2.Name = "Ejemplo2";
            Ejemplo2.Size = new Size(44, 18);
            Ejemplo2.TabIndex = 11;
            Ejemplo2.Text = "label5";
            // 
            // Ejemplo1
            // 
            Ejemplo1.AutoSize = true;
            Ejemplo1.Location = new Point(563, 206);
            Ejemplo1.Name = "Ejemplo1";
            Ejemplo1.Size = new Size(44, 18);
            Ejemplo1.TabIndex = 10;
            Ejemplo1.Text = "label5";
            // 
            // TotalsHours
            // 
            TotalsHours.AutoSize = true;
            TotalsHours.Location = new Point(598, 151);
            TotalsHours.Name = "TotalsHours";
            TotalsHours.Size = new Size(46, 18);
            TotalsHours.TabIndex = 9;
            TotalsHours.Text = "Horas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(561, 127);
            label4.Name = "label4";
            label4.Size = new Size(126, 18);
            label4.TabIndex = 8;
            label4.Text = "Horas calculadas: ";
            // 
            // CheckOut
            // 
            CheckOut.Location = new Point(423, 252);
            CheckOut.Name = "CheckOut";
            CheckOut.Size = new Size(100, 25);
            CheckOut.TabIndex = 7;
            // 
            // CheckIn
            // 
            CheckIn.Location = new Point(425, 148);
            CheckIn.Name = "CheckIn";
            CheckIn.Size = new Size(100, 25);
            CheckIn.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(425, 231);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 5;
            label3.Text = "Hora Salida";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(425, 127);
            label2.Name = "label2";
            label2.Size = new Size(98, 18);
            label2.TabIndex = 4;
            label2.Text = "Hora LLegada";
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.CalendarFont = new Font("Tahoma", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerFecha.Font = new Font("Tahoma", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerFecha.Format = DateTimePickerFormat.Custom;
            dateTimePickerFecha.Location = new Point(495, 75);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(112, 22);
            dateTimePickerFecha.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(507, 16);
            label1.Name = "label1";
            label1.Size = new Size(80, 18);
            label1.TabIndex = 2;
            label1.Text = "Trabajador";
            // 
            // AddSave
            // 
            AddSave.Location = new Point(561, 348);
            AddSave.Name = "AddSave";
            AddSave.Size = new Size(75, 23);
            AddSave.TabIndex = 1;
            AddSave.Text = "Añadir";
            AddSave.UseVisualStyleBackColor = true;
            AddSave.Click += AddSave_Click;
            // 
            // DGV_Trabajador
            // 
            DGV_Trabajador.AllowUserToAddRows = false;
            DGV_Trabajador.AllowUserToDeleteRows = false;
            DGV_Trabajador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Trabajador.BackgroundColor = Color.White;
            DGV_Trabajador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Trabajador.Location = new Point(8, 16);
            DGV_Trabajador.Name = "DGV_Trabajador";
            DGV_Trabajador.RowTemplate.Height = 25;
            DGV_Trabajador.Size = new Size(411, 355);
            DGV_Trabajador.TabIndex = 0;
            // 
            // Edit
            // 
            Edit.ForeColor = Color.Black;
            Edit.Location = new Point(4, 26);
            Edit.Name = "Edit";
            Edit.Size = new Size(681, 391);
            Edit.TabIndex = 2;
            Edit.Text = "Editar";
            Edit.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            Delete.ForeColor = Color.Black;
            Delete.Location = new Point(4, 26);
            Delete.Name = "Delete";
            Delete.Size = new Size(681, 391);
            Delete.TabIndex = 3;
            Delete.Text = "Eliminar";
            Delete.UseVisualStyleBackColor = true;
            // 
            // FormAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 421);
            Controls.Add(Principal);
            Name = "FormAsistencia";
            Text = "FormAsistencia";
            Load += FormAsist_Load;
            Principal.ResumeLayout(false);
            History.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Asist).EndInit();
            Add.ResumeLayout(false);
            Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Trabajador).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Principal;
        private TabPage History;
        private TabPage Add;
        private TabPage Edit;
        private TabPage Delete;
        private Button DeleteButton;
        private Button EditButton;
        private Button addButton;
        private DataGridView DGV_Asist;
        private DataGridView DGV_Trabajador;
        private Label label1;
        private Button AddSave;
        private DateTimePicker dateTimePickerFecha;
        private Label TotalsHours;
        private Label label4;
        private TextBox CheckOut;
        private TextBox CheckIn;
        private Label label3;
        private Label label2;
        private Label Ejemplo2;
        private Label Ejemplo1;
    }
}
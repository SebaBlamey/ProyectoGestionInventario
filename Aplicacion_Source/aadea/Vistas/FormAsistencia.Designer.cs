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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            TabPrincipal = new TabControl();
            History = new TabPage();
            DeleteButton = new Button();
            EditButton = new Button();
            addButton = new Button();
            DGV_Asist = new DataGridView();
            Add = new TabPage();
            CancelBT = new Button();
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
            Cancel = new Model.BT();
            Save = new Model.BT();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            lastName = new Label();
            nombre = new Label();
            leave = new Label();
            Arrival = new Label();
            date = new Label();
            rut = new Label();
            GeneralInfo = new Label();
            textBox2 = new TextBox();
            newArrival = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            Delete = new TabPage();
            TabPrincipal.SuspendLayout();
            History.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Asist).BeginInit();
            Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Trabajador).BeginInit();
            Edit.SuspendLayout();
            SuspendLayout();
            // 
            // TabPrincipal
            // 
            TabPrincipal.Controls.Add(History);
            TabPrincipal.Controls.Add(Add);
            TabPrincipal.Controls.Add(Edit);
            TabPrincipal.Controls.Add(Delete);
            TabPrincipal.Dock = DockStyle.Fill;
            TabPrincipal.Font = new Font("Tahoma", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            TabPrincipal.Location = new Point(0, 0);
            TabPrincipal.Name = "TabPrincipal";
            TabPrincipal.SelectedIndex = 0;
            TabPrincipal.Size = new Size(689, 421);
            TabPrincipal.TabIndex = 0;
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
            DeleteButton.Click += DeleteButton_Click;
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
            EditButton.Click += EditButton_Click;
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
            addButton.Click += addButton_Click;
            // 
            // DGV_Asist
            // 
            DGV_Asist.AllowUserToAddRows = false;
            DGV_Asist.AllowUserToDeleteRows = false;
            DGV_Asist.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_Asist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Asist.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGV_Asist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGV_Asist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGV_Asist.DefaultCellStyle = dataGridViewCellStyle2;
            DGV_Asist.EditMode = DataGridViewEditMode.EditOnF2;
            DGV_Asist.Location = new Point(8, 6);
            DGV_Asist.Name = "DGV_Asist";
            DGV_Asist.RowTemplate.Height = 25;
            DGV_Asist.Size = new Size(571, 377);
            DGV_Asist.TabIndex = 0;
            // 
            // Add
            // 
            Add.Controls.Add(CancelBT);
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
            // CancelBT
            // 
            CancelBT.Location = new Point(579, 348);
            CancelBT.Name = "CancelBT";
            CancelBT.Size = new Size(75, 23);
            CancelBT.TabIndex = 12;
            CancelBT.Text = "Cancelar";
            CancelBT.UseVisualStyleBackColor = true;
            CancelBT.Click += CancelBT_Click;
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
            AddSave.Location = new Point(450, 348);
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
            Edit.Controls.Add(Cancel);
            Edit.Controls.Add(Save);
            Edit.Controls.Add(label7);
            Edit.Controls.Add(label6);
            Edit.Controls.Add(label5);
            Edit.Controls.Add(lastName);
            Edit.Controls.Add(nombre);
            Edit.Controls.Add(leave);
            Edit.Controls.Add(Arrival);
            Edit.Controls.Add(date);
            Edit.Controls.Add(rut);
            Edit.Controls.Add(GeneralInfo);
            Edit.Controls.Add(textBox2);
            Edit.Controls.Add(newArrival);
            Edit.Controls.Add(dateTimePicker1);
            Edit.ForeColor = Color.Black;
            Edit.Location = new Point(4, 26);
            Edit.Name = "Edit";
            Edit.Size = new Size(681, 391);
            Edit.TabIndex = 2;
            Edit.Text = "Editar";
            Edit.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            Cancel.BackColor = Color.MediumSlateBlue;
            Cancel.BackgroundColor = Color.MediumSlateBlue;
            Cancel.BorderColor = Color.PaleVioletRed;
            Cancel.BorderRadius = 20;
            Cancel.BorderSize = 0;
            Cancel.FlatAppearance.BorderSize = 0;
            Cancel.FlatStyle = FlatStyle.Flat;
            Cancel.ForeColor = Color.White;
            Cancel.Location = new Point(209, 325);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(81, 27);
            Cancel.TabIndex = 16;
            Cancel.Text = "Cancelar";
            Cancel.TextColor = Color.White;
            Cancel.UseVisualStyleBackColor = false;
            Cancel.Click += Cancel_Click;
            // 
            // Save
            // 
            Save.BackColor = Color.MediumSlateBlue;
            Save.BackgroundColor = Color.MediumSlateBlue;
            Save.BorderColor = Color.PaleVioletRed;
            Save.BorderRadius = 20;
            Save.BorderSize = 0;
            Save.FlatAppearance.BorderSize = 0;
            Save.FlatStyle = FlatStyle.Flat;
            Save.ForeColor = Color.White;
            Save.Location = new Point(86, 325);
            Save.Name = "Save";
            Save.Size = new Size(81, 27);
            Save.TabIndex = 15;
            Save.Text = "Guardar";
            Save.TextColor = Color.White;
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 210);
            label7.Name = "label7";
            label7.Size = new Size(154, 18);
            label7.TabIndex = 14;
            label7.Text = "Editar hora de salida:  ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 123);
            label6.Name = "label6";
            label6.Size = new Size(163, 18);
            label6.TabIndex = 13;
            label6.Text = "Editar hora de llegada:  ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 31);
            label5.Name = "label5";
            label5.Size = new Size(98, 18);
            label5.TabIndex = 12;
            label5.Text = "Editar Fecha: ";
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.Location = new Point(391, 122);
            lastName.Name = "lastName";
            lastName.Size = new Size(65, 18);
            lastName.TabIndex = 11;
            lastName.Text = "Apellido: ";
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Location = new Point(391, 94);
            nombre.Name = "nombre";
            nombre.Size = new Size(70, 18);
            nombre.TabIndex = 10;
            nombre.Text = "Nombre: ";
            // 
            // leave
            // 
            leave.AutoSize = true;
            leave.Location = new Point(391, 220);
            leave.Name = "leave";
            leave.Size = new Size(111, 18);
            leave.TabIndex = 9;
            leave.Text = "Hora de Salida: ";
            // 
            // Arrival
            // 
            Arrival.AutoSize = true;
            Arrival.Location = new Point(391, 186);
            Arrival.Name = "Arrival";
            Arrival.Size = new Size(124, 18);
            Arrival.TabIndex = 8;
            Arrival.Text = "Hora de Llegada: ";
            // 
            // date
            // 
            date.AutoSize = true;
            date.Location = new Point(391, 151);
            date.Name = "date";
            date.Size = new Size(57, 18);
            date.TabIndex = 7;
            date.Text = "Fecha: ";
            // 
            // rut
            // 
            rut.AutoSize = true;
            rut.Location = new Point(391, 66);
            rut.Name = "rut";
            rut.Size = new Size(40, 18);
            rut.TabIndex = 4;
            rut.Text = "Rut: ";
            // 
            // GeneralInfo
            // 
            GeneralInfo.AutoSize = true;
            GeneralInfo.Location = new Point(391, 31);
            GeneralInfo.Name = "GeneralInfo";
            GeneralInfo.Size = new Size(140, 18);
            GeneralInfo.TabIndex = 3;
            GeneralInfo.Text = "Informacion General";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(41, 231);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 25);
            textBox2.TabIndex = 2;
            // 
            // newArrival
            // 
            newArrival.Location = new Point(41, 144);
            newArrival.Name = "newArrival";
            newArrival.Size = new Size(100, 25);
            newArrival.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(41, 59);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 25);
            dateTimePicker1.TabIndex = 0;
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
            Controls.Add(TabPrincipal);
            Name = "FormAsistencia";
            Text = "FormAsistencia";
            Load += FormAsist_Load;
            TabPrincipal.ResumeLayout(false);
            History.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Asist).EndInit();
            Add.ResumeLayout(false);
            Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Trabajador).EndInit();
            Edit.ResumeLayout(false);
            Edit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabPrincipal;
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
        private Label GeneralInfo;
        private TextBox textBox2;
        private TextBox newArrival;
        private DateTimePicker dateTimePicker1;
        private Label leave;
        private Label Arrival;
        private Label date;
        private Label rut;
        private Label lastName;
        private Label nombre;
        private Model.BT Cancel;
        private Model.BT Save;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button CancelBT;
    }
}
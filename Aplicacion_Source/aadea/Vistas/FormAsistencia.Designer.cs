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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            TabPrincipal = new TabControl();
            History = new TabPage();
            label3 = new Label();
            FinalHouBTAccept = new Button();
            FinalHourTB = new TextBox();
            DeleteButton = new Button();
            addButton = new Button();
            DGV_Asist = new DataGridView();
            Add = new TabPage();
            CancelBT = new Button();
            CheckIn = new TextBox();
            label2 = new Label();
            dateTimePickerFecha = new DateTimePicker();
            label1 = new Label();
            AddSave = new Button();
            DGV_Trabajador = new DataGridView();
            TabPrincipal.SuspendLayout();
            History.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Asist).BeginInit();
            Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Trabajador).BeginInit();
            SuspendLayout();
            // 
            // TabPrincipal
            // 
            TabPrincipal.Controls.Add(History);
            TabPrincipal.Controls.Add(Add);
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
            History.BackColor = SystemColors.Control;
            History.Controls.Add(label3);
            History.Controls.Add(FinalHouBTAccept);
            History.Controls.Add(FinalHourTB);
            History.Controls.Add(DeleteButton);
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
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 352);
            label3.Name = "label3";
            label3.Size = new Size(140, 18);
            label3.TabIndex = 6;
            label3.Text = "Ingresar Hora Salida";
            // 
            // FinalHouBTAccept
            // 
            FinalHouBTAccept.Location = new Point(360, 343);
            FinalHouBTAccept.Name = "FinalHouBTAccept";
            FinalHouBTAccept.Size = new Size(89, 34);
            FinalHouBTAccept.TabIndex = 5;
            FinalHouBTAccept.Text = "Confirmar";
            FinalHouBTAccept.UseVisualStyleBackColor = true;
            FinalHouBTAccept.Click += FinalHouBTAccept_Click;
            // 
            // FinalHourTB
            // 
            FinalHourTB.Location = new Point(254, 349);
            FinalHourTB.Name = "FinalHourTB";
            FinalHourTB.Size = new Size(100, 25);
            FinalHourTB.TabIndex = 4;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeleteButton.Location = new Point(585, 201);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(90, 27);
            DeleteButton.TabIndex = 3;
            DeleteButton.Text = "Eliminar";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addButton.Location = new Point(585, 168);
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
            DGV_Asist.AllowUserToResizeColumns = false;
            DGV_Asist.AllowUserToResizeRows = false;
            DGV_Asist.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_Asist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_Asist.BackgroundColor = SystemColors.Control;
            DGV_Asist.BorderStyle = BorderStyle.Fixed3D;
            DGV_Asist.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV_Asist.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 36, 53);
            dataGridViewCellStyle1.Font = new Font("Tahoma", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(33, 36, 53);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGV_Asist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGV_Asist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGV_Asist.EnableHeadersVisualStyles = false;
            DGV_Asist.GridColor = Color.DarkBlue;
            DGV_Asist.Location = new Point(6, 6);
            DGV_Asist.Name = "DGV_Asist";
            DGV_Asist.ReadOnly = true;
            DGV_Asist.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGV_Asist.RowHeadersVisible = false;
            DGV_Asist.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.Plum;
            DGV_Asist.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DGV_Asist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Asist.Size = new Size(573, 277);
            DGV_Asist.TabIndex = 0;
            // 
            // Add
            // 
            Add.BackColor = SystemColors.Control;
            Add.Controls.Add(CancelBT);
            Add.Controls.Add(CheckIn);
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
            // CheckIn
            // 
            CheckIn.Location = new Point(495, 151);
            CheckIn.Name = "CheckIn";
            CheckIn.Size = new Size(100, 25);
            CheckIn.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(495, 127);
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
            AddSave.Text = "Aceptar";
            AddSave.UseVisualStyleBackColor = true;
            AddSave.Click += AddSave_Click;
            // 
            // DGV_Trabajador
            // 
            DGV_Trabajador.AllowUserToAddRows = false;
            DGV_Trabajador.AllowUserToResizeColumns = false;
            DGV_Trabajador.AllowUserToResizeRows = false;
            DGV_Trabajador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_Trabajador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Trabajador.BackgroundColor = SystemColors.Control;
            DGV_Trabajador.BorderStyle = BorderStyle.None;
            DGV_Trabajador.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV_Trabajador.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(33, 36, 53);
            dataGridViewCellStyle3.Font = new Font("Tahoma", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(33, 36, 53);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGV_Trabajador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DGV_Trabajador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGV_Trabajador.EnableHeadersVisualStyles = false;
            DGV_Trabajador.GridColor = Color.DarkBlue;
            DGV_Trabajador.Location = new Point(6, 6);
            DGV_Trabajador.Name = "DGV_Trabajador";
            DGV_Trabajador.ReadOnly = true;
            DGV_Trabajador.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGV_Trabajador.RowHeadersVisible = false;
            DGV_Trabajador.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DGV_Trabajador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Trabajador.Size = new Size(380, 375);
            DGV_Trabajador.TabIndex = 0;
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
            History.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Asist).EndInit();
            Add.ResumeLayout(false);
            Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Trabajador).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabPrincipal;
        private TabPage History;
        private TabPage Add;
        private Button DeleteButton;
        private Button addButton;
        private DataGridView DGV_Asist;
        private DataGridView DGV_Trabajador;
        private Label label1;
        private Button AddSave;
        private DateTimePicker dateTimePickerFecha;
        private TextBox CheckIn;
        private Label label2;
        private Button CancelBT;
        private Button FinalHouBTAccept;
        private TextBox FinalHourTB;
        private Label label3;
    }
}
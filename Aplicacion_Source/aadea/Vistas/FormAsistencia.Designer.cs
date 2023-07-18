using aadea.Extras;

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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            TabPrincipal = new TabControlEx();
            History = new TabPage();
            HelpBTHistory = new FontAwesome.Sharp.IconPictureBox();
            ConfirmAsistencia = new FontAwesome.Sharp.IconButton();
            delete_iconButton = new FontAwesome.Sharp.IconButton();
            FilterAsistencia = new FontAwesome.Sharp.IconButton();
            AddAsistencia = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            FinalHourTB = new TextBox();
            DGV_Asist = new DataGridView();
            Add = new TabPage();
            iconPictureBoxBTAdd = new FontAwesome.Sharp.IconPictureBox();
            AceptarAdd = new FontAwesome.Sharp.IconButton();
            cancelAdd = new FontAwesome.Sharp.IconButton();
            CheckIn = new TextBox();
            label2 = new Label();
            dateTimePickerFecha = new DateTimePicker();
            DGV_Trabajador = new DataGridView();
            Filtrar = new TabPage();
            iconPictureBoxBTFilter = new FontAwesome.Sharp.IconPictureBox();
            DGV_Meses = new DataGridView();
            OpcionCB = new CheckBox();
            DGV_Filter = new DataGridView();
            TabPrincipal.SuspendLayout();
            History.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HelpBTHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Asist).BeginInit();
            Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBoxBTAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Trabajador).BeginInit();
            Filtrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBoxBTFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Meses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Filter).BeginInit();
            SuspendLayout();
            // 
            // TabPrincipal
            // 
            TabPrincipal.Controls.Add(History);
            TabPrincipal.Controls.Add(Add);
            TabPrincipal.Controls.Add(Filtrar);
            TabPrincipal.Dock = DockStyle.Fill;
            TabPrincipal.Font = new Font("Tahoma", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            TabPrincipal.Location = new Point(0, 0);
            TabPrincipal.Name = "TabPrincipal";
            TabPrincipal.SelectedIndex = 0;
            TabPrincipal.Size = new Size(675, 477);
            TabPrincipal.TabIndex = 0;
            // 
            // History
            // 
            History.BackColor = Color.FromArgb(115, 124, 141);
            History.Controls.Add(HelpBTHistory);
            History.Controls.Add(ConfirmAsistencia);
            History.Controls.Add(delete_iconButton);
            History.Controls.Add(FilterAsistencia);
            History.Controls.Add(AddAsistencia);
            History.Controls.Add(label3);
            History.Controls.Add(FinalHourTB);
            History.Controls.Add(DGV_Asist);
            History.Font = new Font("Tahoma", 10.75F, FontStyle.Regular, GraphicsUnit.Point);
            History.ForeColor = Color.Black;
            History.Location = new Point(-2, 20);
            History.Name = "History";
            History.Padding = new Padding(3);
            History.Size = new Size(679, 459);
            History.TabIndex = 0;
            History.Text = "Historial";
            // 
            // HelpBTHistory
            // 
            HelpBTHistory.BackColor = Color.FromArgb(115, 124, 141);
            HelpBTHistory.ForeColor = Color.Black;
            HelpBTHistory.IconChar = FontAwesome.Sharp.IconChar.Question;
            HelpBTHistory.IconColor = Color.Black;
            HelpBTHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            HelpBTHistory.IconSize = 24;
            HelpBTHistory.Location = new Point(666, 430);
            HelpBTHistory.Name = "HelpBTHistory";
            HelpBTHistory.Size = new Size(24, 26);
            HelpBTHistory.TabIndex = 18;
            HelpBTHistory.TabStop = false;
            HelpBTHistory.Click += iconPictureBox1_Click;
            HelpBTHistory.MouseEnter += HelpBTHistory_MouseEnter;
            // 
            // ConfirmAsistencia
            // 
            ConfirmAsistencia.BackColor = Color.FromArgb(40, 167, 69);
            ConfirmAsistencia.Cursor = Cursors.Hand;
            ConfirmAsistencia.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 29);
            ConfirmAsistencia.FlatAppearance.BorderSize = 2;
            ConfirmAsistencia.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 127, 29);
            ConfirmAsistencia.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 147, 49);
            ConfirmAsistencia.FlatStyle = FlatStyle.Flat;
            ConfirmAsistencia.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ConfirmAsistencia.ForeColor = SystemColors.Control;
            ConfirmAsistencia.IconChar = FontAwesome.Sharp.IconChar.Check;
            ConfirmAsistencia.IconColor = SystemColors.Control;
            ConfirmAsistencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ConfirmAsistencia.IconSize = 28;
            ConfirmAsistencia.ImageAlign = ContentAlignment.TopCenter;
            ConfirmAsistencia.Location = new Point(397, 412);
            ConfirmAsistencia.Name = "ConfirmAsistencia";
            ConfirmAsistencia.Size = new Size(118, 33);
            ConfirmAsistencia.TabIndex = 17;
            ConfirmAsistencia.Text = "Confirmar";
            ConfirmAsistencia.TextImageRelation = TextImageRelation.ImageBeforeText;
            ConfirmAsistencia.UseVisualStyleBackColor = false;
            ConfirmAsistencia.Click += ConfirmAsistencia_Click;
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
            delete_iconButton.TabIndex = 16;
            delete_iconButton.Text = "Eliminar";
            delete_iconButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            delete_iconButton.UseVisualStyleBackColor = false;
            delete_iconButton.Click += delete_iconButton_Click;
            // 
            // FilterAsistencia
            // 
            FilterAsistencia.BackColor = Color.FromArgb(217, 145, 0);
            FilterAsistencia.FlatAppearance.BorderColor = Color.FromArgb(177, 105, 0);
            FilterAsistencia.FlatAppearance.BorderSize = 2;
            FilterAsistencia.FlatAppearance.MouseDownBackColor = Color.FromArgb(177, 105, 0);
            FilterAsistencia.FlatAppearance.MouseOverBackColor = Color.FromArgb(197, 125, 0);
            FilterAsistencia.FlatStyle = FlatStyle.Flat;
            FilterAsistencia.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            FilterAsistencia.ForeColor = SystemColors.Control;
            FilterAsistencia.IconChar = FontAwesome.Sharp.IconChar.Filter;
            FilterAsistencia.IconColor = SystemColors.Control;
            FilterAsistencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            FilterAsistencia.IconSize = 28;
            FilterAsistencia.Location = new Point(572, 158);
            FilterAsistencia.Name = "FilterAsistencia";
            FilterAsistencia.Size = new Size(118, 33);
            FilterAsistencia.TabIndex = 15;
            FilterAsistencia.Text = "Filtrar";
            FilterAsistencia.TextImageRelation = TextImageRelation.ImageBeforeText;
            FilterAsistencia.UseVisualStyleBackColor = false;
            FilterAsistencia.Click += FilterAsistencia_Click;
            // 
            // AddAsistencia
            // 
            AddAsistencia.BackColor = Color.FromArgb(40, 167, 69);
            AddAsistencia.Cursor = Cursors.Hand;
            AddAsistencia.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 29);
            AddAsistencia.FlatAppearance.BorderSize = 2;
            AddAsistencia.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 127, 29);
            AddAsistencia.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 147, 49);
            AddAsistencia.FlatStyle = FlatStyle.Flat;
            AddAsistencia.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AddAsistencia.ForeColor = SystemColors.Control;
            AddAsistencia.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            AddAsistencia.IconColor = SystemColors.Control;
            AddAsistencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AddAsistencia.IconSize = 28;
            AddAsistencia.ImageAlign = ContentAlignment.TopCenter;
            AddAsistencia.Location = new Point(572, 119);
            AddAsistencia.Name = "AddAsistencia";
            AddAsistencia.Size = new Size(118, 33);
            AddAsistencia.TabIndex = 14;
            AddAsistencia.Text = "Agregar";
            AddAsistencia.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddAsistencia.UseVisualStyleBackColor = false;
            AddAsistencia.Click += AddProduct_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 419);
            label3.Name = "label3";
            label3.Size = new Size(197, 23);
            label3.TabIndex = 6;
            label3.Text = "Ingresar Hora Salida";
            // 
            // FinalHourTB
            // 
            FinalHourTB.BackColor = Color.FromArgb(155, 164, 181);
            FinalHourTB.BorderStyle = BorderStyle.FixedSingle;
            FinalHourTB.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FinalHourTB.Location = new Point(217, 415);
            FinalHourTB.Name = "FinalHourTB";
            FinalHourTB.Size = new Size(174, 27);
            FinalHourTB.TabIndex = 4;
            // 
            // DGV_Asist
            // 
            DGV_Asist.AllowUserToAddRows = false;
            DGV_Asist.AllowUserToResizeColumns = false;
            DGV_Asist.AllowUserToResizeRows = false;
            DGV_Asist.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_Asist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_Asist.BackgroundColor = Color.FromArgb(155, 164, 181);
            DGV_Asist.BorderStyle = BorderStyle.None;
            DGV_Asist.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV_Asist.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            DGV_Asist.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 36, 53);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(33, 36, 53);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGV_Asist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGV_Asist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGV_Asist.DefaultCellStyle = dataGridViewCellStyle2;
            DGV_Asist.EnableHeadersVisualStyles = false;
            DGV_Asist.GridColor = Color.FromArgb(115, 124, 141);
            DGV_Asist.Location = new Point(12, 6);
            DGV_Asist.Name = "DGV_Asist";
            DGV_Asist.ReadOnly = true;
            DGV_Asist.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGV_Asist.RowHeadersVisible = false;
            DGV_Asist.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(155, 164, 181);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(57, 72, 103);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGV_Asist.RowsDefaultCellStyle = dataGridViewCellStyle3;
            DGV_Asist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Asist.Size = new Size(503, 388);
            DGV_Asist.TabIndex = 0;
            DGV_Asist.CellFormatting += DGV_Asist_CellFormatting;
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(115, 124, 141);
            Add.Controls.Add(iconPictureBoxBTAdd);
            Add.Controls.Add(AceptarAdd);
            Add.Controls.Add(cancelAdd);
            Add.Controls.Add(CheckIn);
            Add.Controls.Add(label2);
            Add.Controls.Add(dateTimePickerFecha);
            Add.Controls.Add(DGV_Trabajador);
            Add.ForeColor = Color.Black;
            Add.Location = new Point(-2, 20);
            Add.Name = "Add";
            Add.Padding = new Padding(3);
            Add.Size = new Size(679, 459);
            Add.TabIndex = 1;
            Add.Text = " Añadir";
            // 
            // iconPictureBoxBTAdd
            // 
            iconPictureBoxBTAdd.BackColor = Color.FromArgb(115, 124, 141);
            iconPictureBoxBTAdd.ForeColor = Color.Black;
            iconPictureBoxBTAdd.IconChar = FontAwesome.Sharp.IconChar.Question;
            iconPictureBoxBTAdd.IconColor = Color.Black;
            iconPictureBoxBTAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBoxBTAdd.IconSize = 24;
            iconPictureBoxBTAdd.Location = new Point(670, 431);
            iconPictureBoxBTAdd.Name = "iconPictureBoxBTAdd";
            iconPictureBoxBTAdd.Size = new Size(24, 26);
            iconPictureBoxBTAdd.TabIndex = 22;
            iconPictureBoxBTAdd.TabStop = false;
            iconPictureBoxBTAdd.Click += iconPictureBoxBTAdd_Click;
            // 
            // AceptarAdd
            // 
            AceptarAdd.BackColor = Color.FromArgb(40, 167, 69);
            AceptarAdd.Cursor = Cursors.Hand;
            AceptarAdd.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 29);
            AceptarAdd.FlatAppearance.BorderSize = 2;
            AceptarAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 127, 29);
            AceptarAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 147, 49);
            AceptarAdd.FlatStyle = FlatStyle.Flat;
            AceptarAdd.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AceptarAdd.ForeColor = SystemColors.Control;
            AceptarAdd.IconChar = FontAwesome.Sharp.IconChar.Check;
            AceptarAdd.IconColor = SystemColors.Control;
            AceptarAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AceptarAdd.IconSize = 28;
            AceptarAdd.Location = new Point(262, 412);
            AceptarAdd.Name = "AceptarAdd";
            AceptarAdd.Size = new Size(118, 33);
            AceptarAdd.TabIndex = 21;
            AceptarAdd.Text = "Guardar";
            AceptarAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            AceptarAdd.UseVisualStyleBackColor = false;
            AceptarAdd.Click += AceptarAdd_Click;
            // 
            // cancelAdd
            // 
            cancelAdd.BackColor = Color.FromArgb(204, 102, 102);
            cancelAdd.Cursor = Cursors.Hand;
            cancelAdd.FlatAppearance.BorderColor = Color.FromArgb(154, 52, 52);
            cancelAdd.FlatAppearance.BorderSize = 2;
            cancelAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(154, 52, 52);
            cancelAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(164, 62, 62);
            cancelAdd.FlatStyle = FlatStyle.Flat;
            cancelAdd.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancelAdd.ForeColor = SystemColors.Control;
            cancelAdd.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            cancelAdd.IconColor = SystemColors.Control;
            cancelAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cancelAdd.IconSize = 28;
            cancelAdd.Location = new Point(386, 412);
            cancelAdd.Name = "cancelAdd";
            cancelAdd.Size = new Size(118, 33);
            cancelAdd.TabIndex = 20;
            cancelAdd.Text = "Cancelar";
            cancelAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            cancelAdd.UseVisualStyleBackColor = false;
            cancelAdd.Click += cancelAdd_Click;
            // 
            // CheckIn
            // 
            CheckIn.BackColor = Color.FromArgb(155, 164, 181);
            CheckIn.BorderStyle = BorderStyle.FixedSingle;
            CheckIn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CheckIn.Location = new Point(546, 149);
            CheckIn.Name = "CheckIn";
            CheckIn.Size = new Size(137, 27);
            CheckIn.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(546, 123);
            label2.Name = "label2";
            label2.Size = new Size(139, 23);
            label2.TabIndex = 4;
            label2.Text = "Hora LLegada";
            // 
            // dateTimePickerFecha
            // 
            dateTimePickerFecha.CalendarFont = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerFecha.CalendarMonthBackground = Color.FromArgb(155, 164, 181);
            dateTimePickerFecha.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerFecha.Format = DateTimePickerFormat.Custom;
            dateTimePickerFecha.Location = new Point(546, 67);
            dateTimePickerFecha.Name = "dateTimePickerFecha";
            dateTimePickerFecha.Size = new Size(127, 27);
            dateTimePickerFecha.TabIndex = 3;
            // 
            // DGV_Trabajador
            // 
            DGV_Trabajador.AllowUserToAddRows = false;
            DGV_Trabajador.AllowUserToResizeColumns = false;
            DGV_Trabajador.AllowUserToResizeRows = false;
            DGV_Trabajador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_Trabajador.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Trabajador.BackgroundColor = Color.FromArgb(155, 164, 181);
            DGV_Trabajador.BorderStyle = BorderStyle.None;
            DGV_Trabajador.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV_Trabajador.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            DGV_Trabajador.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGV_Trabajador.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGV_Trabajador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGV_Trabajador.DefaultCellStyle = dataGridViewCellStyle3;
            DGV_Trabajador.EnableHeadersVisualStyles = false;
            DGV_Trabajador.GridColor = Color.FromArgb(115, 124, 141);
            DGV_Trabajador.ImeMode = ImeMode.On;
            DGV_Trabajador.Location = new Point(12, 6);
            DGV_Trabajador.MultiSelect = false;
            DGV_Trabajador.Name = "DGV_Trabajador";
            DGV_Trabajador.ReadOnly = true;
            DGV_Trabajador.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGV_Trabajador.RowHeadersVisible = false;
            DGV_Trabajador.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(155, 164, 181);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(57, 72, 103);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGV_Trabajador.RowsDefaultCellStyle = dataGridViewCellStyle4;
            DGV_Trabajador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Trabajador.Size = new Size(478, 388);
            DGV_Trabajador.TabIndex = 0;
            // 
            // Filtrar
            // 
            Filtrar.BackColor = Color.FromArgb(115, 124, 141);
            Filtrar.Controls.Add(iconPictureBoxBTFilter);
            Filtrar.Controls.Add(DGV_Meses);
            Filtrar.Controls.Add(OpcionCB);
            Filtrar.Controls.Add(DGV_Filter);
            Filtrar.Location = new Point(-2, 20);
            Filtrar.Name = "Filtrar";
            Filtrar.Size = new Size(679, 459);
            Filtrar.TabIndex = 2;
            Filtrar.Text = "Filtrar...";
            // 
            // iconPictureBoxBTFilter
            // 
            iconPictureBoxBTFilter.BackColor = Color.FromArgb(115, 124, 141);
            iconPictureBoxBTFilter.ForeColor = Color.Black;
            iconPictureBoxBTFilter.IconChar = FontAwesome.Sharp.IconChar.Question;
            iconPictureBoxBTFilter.IconColor = Color.Black;
            iconPictureBoxBTFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBoxBTFilter.IconSize = 24;
            iconPictureBoxBTFilter.Location = new Point(671, 431);
            iconPictureBoxBTFilter.Name = "iconPictureBoxBTFilter";
            iconPictureBoxBTFilter.Size = new Size(24, 26);
            iconPictureBoxBTFilter.TabIndex = 23;
            iconPictureBoxBTFilter.TabStop = false;
            iconPictureBoxBTFilter.Click += iconPictureBoxBTFilter_Click;
            // 
            // DGV_Meses
            // 
            DGV_Meses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Meses.BackgroundColor = Color.FromArgb(155, 164, 181);
            DGV_Meses.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(33, 36, 53);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(33, 36, 53);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DGV_Meses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DGV_Meses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Meses.ColumnHeadersVisible = false;
            DGV_Meses.GridColor = Color.White;
            DGV_Meses.ImeMode = ImeMode.On;
            DGV_Meses.Location = new Point(549, 6);
            DGV_Meses.MultiSelect = false;
            DGV_Meses.Name = "DGV_Meses";
            DGV_Meses.ReadOnly = true;
            DGV_Meses.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Tahoma", 8.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            DGV_Meses.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            DGV_Meses.RowHeadersVisible = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(155, 164, 181);
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(57, 72, 103);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(57, 72, 103);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            DGV_Meses.RowsDefaultCellStyle = dataGridViewCellStyle7;
            DGV_Meses.RowTemplate.Height = 25;
            DGV_Meses.Size = new Size(116, 318);
            DGV_Meses.TabIndex = 5;
            DGV_Meses.CellClick += DGV_Meses_CellClick;
            // 
            // OpcionCB
            // 
            OpcionCB.AutoSize = true;
            OpcionCB.FlatStyle = FlatStyle.Flat;
            OpcionCB.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            OpcionCB.ForeColor = Color.White;
            OpcionCB.Location = new Point(124, 345);
            OpcionCB.Name = "OpcionCB";
            OpcionCB.Size = new Size(237, 27);
            OpcionCB.TabIndex = 4;
            OpcionCB.Text = "Filtrar por trabajadores";
            OpcionCB.UseVisualStyleBackColor = true;
            OpcionCB.CheckedChanged += OpcionCB_CheckedChanged_1;
            // 
            // DGV_Filter
            // 
            DGV_Filter.AllowUserToAddRows = false;
            DGV_Filter.AllowUserToResizeColumns = false;
            DGV_Filter.AllowUserToResizeRows = false;
            DGV_Filter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_Filter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_Filter.BackgroundColor = Color.FromArgb(155, 164, 181);
            DGV_Filter.BorderStyle = BorderStyle.None;
            DGV_Filter.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV_Filter.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            DGV_Filter.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(33, 36, 53);
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(33, 36, 53);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            DGV_Filter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            DGV_Filter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGV_Filter.EnableHeadersVisualStyles = false;
            DGV_Filter.GridColor = Color.FromArgb(115, 124, 141);
            DGV_Filter.Location = new Point(12, 6);
            DGV_Filter.Name = "DGV_Filter";
            DGV_Filter.ReadOnly = true;
            DGV_Filter.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGV_Filter.RowHeadersVisible = false;
            DGV_Filter.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(155, 164, 181);
            dataGridViewCellStyle9.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(57, 72, 103);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            DGV_Filter.RowsDefaultCellStyle = dataGridViewCellStyle9;
            DGV_Filter.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Filter.Size = new Size(492, 318);
            DGV_Filter.TabIndex = 0;
            // 
            // FormAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 477);
            Controls.Add(TabPrincipal);
            Name = "FormAsistencia";
            Text = "FormAsistencia";
            Load += FormAsist_Load;
            TabPrincipal.ResumeLayout(false);
            History.ResumeLayout(false);
            History.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HelpBTHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Asist).EndInit();
            Add.ResumeLayout(false);
            Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBoxBTAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Trabajador).EndInit();
            Filtrar.ResumeLayout(false);
            Filtrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBoxBTFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Meses).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Filter).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabPage History;
        private TabPage Add;
        private DataGridView DGV_Asist;
        private DataGridView DGV_Trabajador;
        private DateTimePicker dateTimePickerFecha;
        private TextBox CheckIn;
        private Label label2;
        private TextBox FinalHourTB;
        private Label label3;
        private TabPage Filtrar;
        private DataGridView DGV_Filter;
        private DataGridView DGV_Meses;
        private CheckBox OpcionCB;
        private TabControlEx TabPrincipal;
        private FontAwesome.Sharp.IconButton delete_iconButton;
        private FontAwesome.Sharp.IconButton FilterAsistencia;
        private FontAwesome.Sharp.IconButton AddAsistencia;
        private FontAwesome.Sharp.IconButton ConfirmAsistencia;
        private FontAwesome.Sharp.IconButton AceptarAdd;
        private FontAwesome.Sharp.IconButton cancelAdd;
        private FontAwesome.Sharp.IconPictureBox HelpBTHistory;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxBTAdd;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxBTFilter;
    }
}
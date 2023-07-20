using aadea.Extras;

namespace aadea.Vistas
{
    partial class FormInventario
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            tabControl1 = new TabControlEx();
            tabView = new TabPage();
            verTamano = new FontAwesome.Sharp.IconButton();
            addProdutcto = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            addProdTab = new TabPage();
            label4 = new Label();
            label1 = new Label();
            label6 = new Label();
            volverBtn = new FontAwesome.Sharp.IconButton();
            agregarInv = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            addProdLbl3 = new Label();
            addProdLbl2 = new Label();
            addProdLbl1 = new Label();
            DGV_Size_AddT = new DataGridView();
            DGV_P_AddT = new DataGridView();
            tabSizes = new TabPage();
            label5 = new Label();
            label3 = new Label();
            quitarInventario = new FontAwesome.Sharp.IconButton();
            agregarInventario = new FontAwesome.Sharp.IconButton();
            backInventario = new FontAwesome.Sharp.IconButton();
            sizesAddTB = new TextBox();
            DGV_Sizes = new DataGridView();
            ModStock = new TabPage();
            minu = new FontAwesome.Sharp.IconButton();
            plus = new FontAwesome.Sharp.IconButton();
            volverModStock = new FontAwesome.Sharp.IconButton();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            DGV_Stock = new DataGridView();
            tabControl1.SuspendLayout();
            tabView.SuspendLayout();
            addProdTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Size_AddT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_P_AddT).BeginInit();
            tabSizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Sizes).BeginInit();
            ModStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Stock).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabView);
            tabControl1.Controls.Add(addProdTab);
            tabControl1.Controls.Add(tabSizes);
            tabControl1.Controls.Add(ModStock);
            tabControl1.Dock = DockStyle.Top;
            tabControl1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(826, 460);
            tabControl1.TabIndex = 0;
            // 
            // tabView
            // 
            tabView.BackColor = Color.FromArgb(115, 124, 141);
            tabView.Controls.Add(verTamano);
            tabView.Controls.Add(addProdutcto);
            tabView.Controls.Add(flowLayoutPanel1);
            tabView.Controls.Add(panel1);
            tabView.ForeColor = Color.Black;
            tabView.Location = new Point(-2, 20);
            tabView.Name = "tabView";
            tabView.Padding = new Padding(3);
            tabView.Size = new Size(830, 442);
            tabView.TabIndex = 0;
            tabView.Text = "Stock";
            // 
            // verTamano
            // 
            verTamano.BackColor = Color.FromArgb(217, 145, 0);
            verTamano.FlatAppearance.BorderColor = Color.FromArgb(177, 105, 0);
            verTamano.FlatAppearance.BorderSize = 2;
            verTamano.FlatAppearance.MouseDownBackColor = Color.FromArgb(177, 105, 0);
            verTamano.FlatAppearance.MouseOverBackColor = Color.FromArgb(197, 125, 0);
            verTamano.FlatStyle = FlatStyle.Flat;
            verTamano.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            verTamano.ForeColor = SystemColors.Control;
            verTamano.IconChar = FontAwesome.Sharp.IconChar.Eye;
            verTamano.IconColor = SystemColors.Control;
            verTamano.IconFont = FontAwesome.Sharp.IconFont.Auto;
            verTamano.IconSize = 28;
            verTamano.Location = new Point(566, 383);
            verTamano.Name = "verTamano";
            verTamano.Size = new Size(118, 33);
            verTamano.TabIndex = 11;
            verTamano.Text = "Tamaño";
            verTamano.TextImageRelation = TextImageRelation.ImageBeforeText;
            verTamano.UseVisualStyleBackColor = false;
            verTamano.Click += verTamano_Click;
            // 
            // addProdutcto
            // 
            addProdutcto.BackColor = Color.FromArgb(40, 167, 69);
            addProdutcto.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 29);
            addProdutcto.FlatAppearance.BorderSize = 2;
            addProdutcto.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 127, 29);
            addProdutcto.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 147, 49);
            addProdutcto.FlatStyle = FlatStyle.Flat;
            addProdutcto.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            addProdutcto.ForeColor = SystemColors.Control;
            addProdutcto.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            addProdutcto.IconColor = SystemColors.Control;
            addProdutcto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            addProdutcto.IconSize = 28;
            addProdutcto.ImageAlign = ContentAlignment.TopCenter;
            addProdutcto.Location = new Point(8, 383);
            addProdutcto.Name = "addProdutcto";
            addProdutcto.Size = new Size(118, 33);
            addProdutcto.TabIndex = 11;
            addProdutcto.Text = "Agregar";
            addProdutcto.TextImageRelation = TextImageRelation.ImageBeforeText;
            addProdutcto.UseVisualStyleBackColor = false;
            addProdutcto.Click += addProdutcto_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.ForeColor = Color.Black;
            flowLayoutPanel1.Location = new Point(8, 9);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(793, 368);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 0);
            panel1.TabIndex = 0;
            // 
            // addProdTab
            // 
            addProdTab.BackColor = Color.FromArgb(115, 124, 141);
            addProdTab.Controls.Add(label4);
            addProdTab.Controls.Add(label1);
            addProdTab.Controls.Add(label6);
            addProdTab.Controls.Add(volverBtn);
            addProdTab.Controls.Add(agregarInv);
            addProdTab.Controls.Add(textBox1);
            addProdTab.Controls.Add(addProdLbl3);
            addProdTab.Controls.Add(addProdLbl2);
            addProdTab.Controls.Add(addProdLbl1);
            addProdTab.Controls.Add(DGV_Size_AddT);
            addProdTab.Controls.Add(DGV_P_AddT);
            addProdTab.Location = new Point(-2, 20);
            addProdTab.Name = "addProdTab";
            addProdTab.Padding = new Padding(3);
            addProdTab.Size = new Size(830, 442);
            addProdTab.TabIndex = 1;
            addProdTab.Text = "AddProd";
            addProdTab.Click += addProdTab_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(282, 216);
            label4.Name = "label4";
            label4.Size = new Size(18, 23);
            label4.TabIndex = 15;
            label4.Text = "*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(642, 24);
            label1.Name = "label1";
            label1.Size = new Size(18, 23);
            label1.TabIndex = 14;
            label1.Text = "*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(293, 24);
            label6.Name = "label6";
            label6.Size = new Size(18, 23);
            label6.TabIndex = 13;
            label6.Text = "*";
            // 
            // volverBtn
            // 
            volverBtn.BackColor = Color.FromArgb(204, 102, 102);
            volverBtn.Cursor = Cursors.Hand;
            volverBtn.FlatAppearance.BorderColor = Color.FromArgb(154, 52, 52);
            volverBtn.FlatAppearance.BorderSize = 2;
            volverBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(154, 52, 52);
            volverBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(164, 62, 62);
            volverBtn.FlatStyle = FlatStyle.Flat;
            volverBtn.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            volverBtn.ForeColor = SystemColors.Control;
            volverBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowLeftLong;
            volverBtn.IconColor = SystemColors.Control;
            volverBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            volverBtn.IconSize = 28;
            volverBtn.Location = new Point(14, 394);
            volverBtn.Name = "volverBtn";
            volverBtn.Size = new Size(118, 33);
            volverBtn.TabIndex = 12;
            volverBtn.Text = "Volver";
            volverBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            volverBtn.UseVisualStyleBackColor = false;
            volverBtn.Click += volverBtn_Click;
            // 
            // agregarInv
            // 
            agregarInv.BackColor = Color.FromArgb(40, 167, 69);
            agregarInv.Cursor = Cursors.Hand;
            agregarInv.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 29);
            agregarInv.FlatAppearance.BorderSize = 2;
            agregarInv.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 127, 29);
            agregarInv.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 147, 49);
            agregarInv.FlatStyle = FlatStyle.Flat;
            agregarInv.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            agregarInv.ForeColor = SystemColors.Control;
            agregarInv.IconChar = FontAwesome.Sharp.IconChar.Check;
            agregarInv.IconColor = SystemColors.Control;
            agregarInv.IconFont = FontAwesome.Sharp.IconFont.Auto;
            agregarInv.IconSize = 28;
            agregarInv.Location = new Point(356, 303);
            agregarInv.Name = "agregarInv";
            agregarInv.Size = new Size(118, 33);
            agregarInv.TabIndex = 11;
            agregarInv.Text = "Agregar";
            agregarInv.TextImageRelation = TextImageRelation.ImageBeforeText;
            agregarInv.UseVisualStyleBackColor = false;
            agregarInv.Click += agregarInv_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(155, 164, 181);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(62, 242);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 20);
            textBox1.TabIndex = 6;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // addProdLbl3
            // 
            addProdLbl3.AutoSize = true;
            addProdLbl3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            addProdLbl3.ForeColor = Color.White;
            addProdLbl3.Location = new Point(62, 216);
            addProdLbl3.Name = "addProdLbl3";
            addProdLbl3.Size = new Size(214, 23);
            addProdLbl3.TabIndex = 5;
            addProdLbl3.Text = "Ingrese el stock inicial";
            // 
            // addProdLbl2
            // 
            addProdLbl2.AutoSize = true;
            addProdLbl2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            addProdLbl2.ForeColor = Color.White;
            addProdLbl2.Location = new Point(423, 24);
            addProdLbl2.Name = "addProdLbl2";
            addProdLbl2.Size = new Size(213, 23);
            addProdLbl2.TabIndex = 4;
            addProdLbl2.Text = "Seleccione el tamaño";
            // 
            // addProdLbl1
            // 
            addProdLbl1.AutoSize = true;
            addProdLbl1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            addProdLbl1.ForeColor = Color.White;
            addProdLbl1.Location = new Point(62, 24);
            addProdLbl1.Name = "addProdLbl1";
            addProdLbl1.Size = new Size(225, 23);
            addProdLbl1.TabIndex = 3;
            addProdLbl1.Text = "Seleccione el producto";
            // 
            // DGV_Size_AddT
            // 
            DGV_Size_AddT.AllowUserToAddRows = false;
            DGV_Size_AddT.AllowUserToResizeColumns = false;
            DGV_Size_AddT.AllowUserToResizeRows = false;
            DGV_Size_AddT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_Size_AddT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Size_AddT.BackgroundColor = Color.FromArgb(155, 164, 181);
            DGV_Size_AddT.BorderStyle = BorderStyle.None;
            DGV_Size_AddT.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV_Size_AddT.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 36, 53);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(33, 36, 53);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGV_Size_AddT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGV_Size_AddT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(155, 164, 181);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(57, 72, 103);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(57, 72, 103);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGV_Size_AddT.DefaultCellStyle = dataGridViewCellStyle2;
            DGV_Size_AddT.EnableHeadersVisualStyles = false;
            DGV_Size_AddT.GridColor = Color.FromArgb(115, 124, 141);
            DGV_Size_AddT.Location = new Point(423, 62);
            DGV_Size_AddT.MultiSelect = false;
            DGV_Size_AddT.Name = "DGV_Size_AddT";
            DGV_Size_AddT.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = Color.Plum;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DGV_Size_AddT.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DGV_Size_AddT.RowHeadersVisible = false;
            DGV_Size_AddT.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(155, 164, 181);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(57, 72, 103);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(57, 72, 103);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGV_Size_AddT.RowsDefaultCellStyle = dataGridViewCellStyle4;
            DGV_Size_AddT.RowTemplate.Height = 25;
            DGV_Size_AddT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Size_AddT.Size = new Size(321, 132);
            DGV_Size_AddT.TabIndex = 1;
            // 
            // DGV_P_AddT
            // 
            DGV_P_AddT.AllowUserToAddRows = false;
            DGV_P_AddT.AllowUserToDeleteRows = false;
            DGV_P_AddT.AllowUserToResizeColumns = false;
            DGV_P_AddT.AllowUserToResizeRows = false;
            DGV_P_AddT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_P_AddT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_P_AddT.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            DGV_P_AddT.BackgroundColor = Color.FromArgb(155, 164, 181);
            DGV_P_AddT.BorderStyle = BorderStyle.None;
            DGV_P_AddT.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV_P_AddT.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(33, 36, 53);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(33, 36, 53);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DGV_P_AddT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DGV_P_AddT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(155, 164, 181);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(57, 72, 103);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(57, 72, 103);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DGV_P_AddT.DefaultCellStyle = dataGridViewCellStyle6;
            DGV_P_AddT.EnableHeadersVisualStyles = false;
            DGV_P_AddT.GridColor = Color.FromArgb(115, 124, 141);
            DGV_P_AddT.ImeMode = ImeMode.NoControl;
            DGV_P_AddT.Location = new Point(62, 62);
            DGV_P_AddT.MultiSelect = false;
            DGV_P_AddT.Name = "DGV_P_AddT";
            DGV_P_AddT.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.DimGray;
            dataGridViewCellStyle7.SelectionBackColor = Color.Plum;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            DGV_P_AddT.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            DGV_P_AddT.RowHeadersVisible = false;
            DGV_P_AddT.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(155, 164, 181);
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(57, 72, 103);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            DGV_P_AddT.RowsDefaultCellStyle = dataGridViewCellStyle8;
            DGV_P_AddT.RowTemplate.Height = 25;
            DGV_P_AddT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_P_AddT.Size = new Size(321, 132);
            DGV_P_AddT.TabIndex = 0;
            DGV_P_AddT.CellContentClick += DGV_P_AddT_CellContentClick;
            // 
            // tabSizes
            // 
            tabSizes.BackColor = Color.FromArgb(115, 124, 141);
            tabSizes.Controls.Add(label5);
            tabSizes.Controls.Add(label3);
            tabSizes.Controls.Add(quitarInventario);
            tabSizes.Controls.Add(agregarInventario);
            tabSizes.Controls.Add(backInventario);
            tabSizes.Controls.Add(sizesAddTB);
            tabSizes.Controls.Add(DGV_Sizes);
            tabSizes.Location = new Point(-2, 20);
            tabSizes.Name = "tabSizes";
            tabSizes.Padding = new Padding(3);
            tabSizes.Size = new Size(830, 442);
            tabSizes.TabIndex = 2;
            tabSizes.Text = "Tamaños";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(664, 137);
            label5.Name = "label5";
            label5.Size = new Size(18, 23);
            label5.TabIndex = 17;
            label5.Text = "*";
            // 
            // label3
            // 
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(394, 132);
            label3.Name = "label3";
            label3.Size = new Size(279, 33);
            label3.TabIndex = 16;
            label3.Text = "Ingrese el tamaño del frasco";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // quitarInventario
            // 
            quitarInventario.BackColor = Color.FromArgb(217, 145, 0);
            quitarInventario.FlatAppearance.BorderColor = Color.FromArgb(177, 105, 0);
            quitarInventario.FlatAppearance.BorderSize = 2;
            quitarInventario.FlatAppearance.MouseDownBackColor = Color.FromArgb(177, 105, 0);
            quitarInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(197, 125, 0);
            quitarInventario.FlatStyle = FlatStyle.Flat;
            quitarInventario.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            quitarInventario.ForeColor = SystemColors.Control;
            quitarInventario.IconChar = FontAwesome.Sharp.IconChar.Minus;
            quitarInventario.IconColor = SystemColors.Control;
            quitarInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            quitarInventario.IconSize = 28;
            quitarInventario.Location = new Point(555, 207);
            quitarInventario.Name = "quitarInventario";
            quitarInventario.Size = new Size(118, 33);
            quitarInventario.TabIndex = 15;
            quitarInventario.Text = "Quitar";
            quitarInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            quitarInventario.UseVisualStyleBackColor = false;
            quitarInventario.Click += quitarInventario_Click;
            // 
            // agregarInventario
            // 
            agregarInventario.BackColor = Color.FromArgb(40, 167, 69);
            agregarInventario.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 29);
            agregarInventario.FlatAppearance.BorderSize = 2;
            agregarInventario.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 127, 29);
            agregarInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 147, 49);
            agregarInventario.FlatStyle = FlatStyle.Flat;
            agregarInventario.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            agregarInventario.ForeColor = SystemColors.Control;
            agregarInventario.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            agregarInventario.IconColor = SystemColors.Control;
            agregarInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            agregarInventario.IconSize = 28;
            agregarInventario.ImageAlign = ContentAlignment.TopCenter;
            agregarInventario.Location = new Point(394, 207);
            agregarInventario.Name = "agregarInventario";
            agregarInventario.Size = new Size(118, 33);
            agregarInventario.TabIndex = 14;
            agregarInventario.Text = "Agregar";
            agregarInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            agregarInventario.UseVisualStyleBackColor = false;
            agregarInventario.Click += agregarInventario_Click;
            // 
            // backInventario
            // 
            backInventario.BackColor = Color.FromArgb(204, 102, 102);
            backInventario.Cursor = Cursors.Hand;
            backInventario.FlatAppearance.BorderColor = Color.FromArgb(154, 52, 52);
            backInventario.FlatAppearance.BorderSize = 2;
            backInventario.FlatAppearance.MouseDownBackColor = Color.FromArgb(154, 52, 52);
            backInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(164, 62, 62);
            backInventario.FlatStyle = FlatStyle.Flat;
            backInventario.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            backInventario.ForeColor = SystemColors.Control;
            backInventario.IconChar = FontAwesome.Sharp.IconChar.ArrowLeftLong;
            backInventario.IconColor = SystemColors.Control;
            backInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            backInventario.IconSize = 28;
            backInventario.Location = new Point(14, 394);
            backInventario.Name = "backInventario";
            backInventario.Size = new Size(118, 33);
            backInventario.TabIndex = 13;
            backInventario.Text = "Volver";
            backInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            backInventario.UseVisualStyleBackColor = false;
            backInventario.Click += backInventario_Click;
            // 
            // sizesAddTB
            // 
            sizesAddTB.BackColor = Color.FromArgb(155, 164, 181);
            sizesAddTB.BorderStyle = BorderStyle.None;
            sizesAddTB.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sizesAddTB.Location = new Point(394, 168);
            sizesAddTB.Name = "sizesAddTB";
            sizesAddTB.Size = new Size(279, 20);
            sizesAddTB.TabIndex = 5;
            sizesAddTB.KeyPress += textBox1_KeyPress;
            // 
            // DGV_Sizes
            // 
            DGV_Sizes.AllowUserToAddRows = false;
            DGV_Sizes.AllowUserToDeleteRows = false;
            DGV_Sizes.AllowUserToResizeColumns = false;
            DGV_Sizes.AllowUserToResizeRows = false;
            DGV_Sizes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Sizes.BackgroundColor = Color.FromArgb(155, 164, 181);
            DGV_Sizes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV_Sizes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(33, 36, 53);
            dataGridViewCellStyle9.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(33, 36, 53);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            DGV_Sizes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            DGV_Sizes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Sizes.EnableHeadersVisualStyles = false;
            DGV_Sizes.GridColor = Color.FromArgb(115, 124, 141);
            DGV_Sizes.Location = new Point(53, 54);
            DGV_Sizes.MultiSelect = false;
            DGV_Sizes.Name = "DGV_Sizes";
            DGV_Sizes.ReadOnly = true;
            DGV_Sizes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle10.SelectionBackColor = Color.Plum;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            DGV_Sizes.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            DGV_Sizes.RowHeadersVisible = false;
            DGV_Sizes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(155, 164, 181);
            dataGridViewCellStyle11.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(57, 72, 103);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(57, 72, 103);
            DGV_Sizes.RowsDefaultCellStyle = dataGridViewCellStyle11;
            DGV_Sizes.RowTemplate.Height = 25;
            DGV_Sizes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Sizes.Size = new Size(289, 304);
            DGV_Sizes.TabIndex = 0;
            // 
            // ModStock
            // 
            ModStock.BackColor = Color.FromArgb(115, 124, 141);
            ModStock.Controls.Add(minu);
            ModStock.Controls.Add(plus);
            ModStock.Controls.Add(volverModStock);
            ModStock.Controls.Add(textBox2);
            ModStock.Controls.Add(pictureBox1);
            ModStock.Controls.Add(label2);
            ModStock.Controls.Add(DGV_Stock);
            ModStock.Location = new Point(-2, 20);
            ModStock.Name = "ModStock";
            ModStock.Size = new Size(830, 442);
            ModStock.TabIndex = 3;
            ModStock.Text = "ModStock";
            // 
            // minu
            // 
            minu.BackColor = Color.FromArgb(217, 145, 0);
            minu.FlatAppearance.BorderColor = Color.FromArgb(177, 105, 0);
            minu.FlatAppearance.BorderSize = 2;
            minu.FlatAppearance.MouseDownBackColor = Color.FromArgb(177, 105, 0);
            minu.FlatAppearance.MouseOverBackColor = Color.FromArgb(197, 125, 0);
            minu.FlatStyle = FlatStyle.Flat;
            minu.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            minu.ForeColor = SystemColors.Control;
            minu.IconChar = FontAwesome.Sharp.IconChar.Minus;
            minu.IconColor = SystemColors.Control;
            minu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            minu.IconSize = 28;
            minu.Location = new Point(490, 231);
            minu.Name = "minu";
            minu.Size = new Size(83, 33);
            minu.TabIndex = 12;
            minu.TextImageRelation = TextImageRelation.ImageBeforeText;
            minu.UseVisualStyleBackColor = false;
            minu.Click += minu_Click;
            // 
            // plus
            // 
            plus.BackColor = Color.FromArgb(40, 167, 69);
            plus.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 29);
            plus.FlatAppearance.BorderSize = 2;
            plus.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 127, 29);
            plus.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 147, 49);
            plus.FlatStyle = FlatStyle.Flat;
            plus.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            plus.ForeColor = SystemColors.Control;
            plus.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            plus.IconColor = SystemColors.Control;
            plus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            plus.IconSize = 28;
            plus.Location = new Point(404, 231);
            plus.Name = "plus";
            plus.Size = new Size(80, 33);
            plus.TabIndex = 15;
            plus.TextImageRelation = TextImageRelation.ImageBeforeText;
            plus.UseVisualStyleBackColor = false;
            plus.Click += plus_Click;
            // 
            // volverModStock
            // 
            volverModStock.BackColor = Color.FromArgb(204, 102, 102);
            volverModStock.Cursor = Cursors.Hand;
            volverModStock.FlatAppearance.BorderColor = Color.FromArgb(154, 52, 52);
            volverModStock.FlatAppearance.BorderSize = 2;
            volverModStock.FlatAppearance.MouseDownBackColor = Color.FromArgb(154, 52, 52);
            volverModStock.FlatAppearance.MouseOverBackColor = Color.FromArgb(164, 62, 62);
            volverModStock.FlatStyle = FlatStyle.Flat;
            volverModStock.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            volverModStock.ForeColor = SystemColors.Control;
            volverModStock.IconChar = FontAwesome.Sharp.IconChar.ArrowLeftLong;
            volverModStock.IconColor = SystemColors.Control;
            volverModStock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            volverModStock.IconSize = 28;
            volverModStock.Location = new Point(14, 394);
            volverModStock.Name = "volverModStock";
            volverModStock.Size = new Size(118, 33);
            volverModStock.TabIndex = 14;
            volverModStock.Text = "Volver";
            volverModStock.TextImageRelation = TextImageRelation.ImageBeforeText;
            volverModStock.UseVisualStyleBackColor = false;
            volverModStock.Click += volverModStock_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(155, 164, 181);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(404, 198);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 27);
            textBox2.TabIndex = 10;
            textBox2.KeyPress += textBox1_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(62, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(367, 163);
            label2.Name = "label2";
            label2.Size = new Size(277, 32);
            label2.TabIndex = 8;
            label2.Text = "Actualizar stock existente";
            // 
            // DGV_Stock
            // 
            DGV_Stock.AllowUserToAddRows = false;
            DGV_Stock.AllowUserToDeleteRows = false;
            DGV_Stock.AllowUserToResizeColumns = false;
            DGV_Stock.AllowUserToResizeRows = false;
            DGV_Stock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Stock.BackgroundColor = Color.FromArgb(155, 164, 181);
            DGV_Stock.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV_Stock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(33, 36, 53);
            dataGridViewCellStyle12.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(33, 36, 53);
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            DGV_Stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            DGV_Stock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Stock.EnableHeadersVisualStyles = false;
            DGV_Stock.GridColor = Color.FromArgb(115, 124, 141);
            DGV_Stock.Location = new Point(62, 201);
            DGV_Stock.MultiSelect = false;
            DGV_Stock.Name = "DGV_Stock";
            DGV_Stock.ReadOnly = true;
            DGV_Stock.RowHeadersVisible = false;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(155, 164, 181);
            dataGridViewCellStyle13.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.FromArgb(57, 72, 103);
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(57, 72, 103);
            DGV_Stock.RowsDefaultCellStyle = dataGridViewCellStyle13;
            DGV_Stock.RowTemplate.Height = 25;
            DGV_Stock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Stock.Size = new Size(240, 150);
            DGV_Stock.TabIndex = 0;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 459);
            Controls.Add(tabControl1);
            Name = "FormInventario";
            Text = "FormInventario";
            Load += FormProduccion_Load;
            tabControl1.ResumeLayout(false);
            tabView.ResumeLayout(false);
            tabView.PerformLayout();
            addProdTab.ResumeLayout(false);
            addProdTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Size_AddT).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_P_AddT).EndInit();
            tabSizes.ResumeLayout(false);
            tabSizes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Sizes).EndInit();
            ModStock.ResumeLayout(false);
            ModStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_Stock).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabView;
        private TabPage addProdTab;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TabPage tabSizes;
        private DataGridView DGV_Size_AddT;
        private DataGridView DGV_P_AddT;
        private TextBox textBox1;
        private Label addProdLbl3;
        private Label addProdLbl2;
        private Label addProdLbl1;
        private DataGridView DGV_Sizes;
        private TextBox sizesAddTB;
        private TabPage ModStock;
        private DataGridView DGV_Stock;
        private Label label2;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private FontAwesome.Sharp.IconButton addProdutcto;
        private TabControlEx tabControl1;
        private FontAwesome.Sharp.IconButton verTamano;
        private FontAwesome.Sharp.IconButton agregarInv;
        private FontAwesome.Sharp.IconButton volverBtn;
        private FontAwesome.Sharp.IconButton backInventario;
        private FontAwesome.Sharp.IconButton quitarInventario;
        private FontAwesome.Sharp.IconButton agregarInventario;
        private Label label3;
        private FontAwesome.Sharp.IconButton volverModStock;
        private FontAwesome.Sharp.IconButton plus;
        private FontAwesome.Sharp.IconButton minu;
        private Label label4;
        private Label label1;
        private Label label6;
        private Label label5;
    }
}
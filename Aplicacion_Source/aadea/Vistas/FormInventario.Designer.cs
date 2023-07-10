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
            tabControl1 = new TabControl();
            tabView = new TabPage();
            sizesBtn = new Button();
            addProd = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            addProdTab = new TabPage();
            addProd_AddBtn = new Button();
            textBox1 = new TextBox();
            addProdLbl3 = new Label();
            addProdLbl2 = new Label();
            addProdLbl1 = new Label();
            addProd_Back = new Button();
            DGV_Size_AddT = new DataGridView();
            DGV_P_AddT = new DataGridView();
            tabSizes = new TabPage();
            sizesAddTB = new TextBox();
            sizesDelBtn = new Button();
            sizesAddBtn = new Button();
            sizesBackBtn = new Button();
            label1 = new Label();
            DGV_Sizes = new DataGridView();
            ModStock = new TabPage();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            stockBackBtn = new Button();
            decStockBtn = new Button();
            incStockBtn = new Button();
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
            tabView.Controls.Add(sizesBtn);
            tabView.Controls.Add(addProd);
            tabView.Controls.Add(flowLayoutPanel1);
            tabView.Controls.Add(panel1);
            tabView.ForeColor = Color.Black;
            tabView.Location = new Point(4, 26);
            tabView.Name = "tabView";
            tabView.Padding = new Padding(3);
            tabView.Size = new Size(818, 430);
            tabView.TabIndex = 0;
            tabView.Text = "Stock";
            tabView.UseVisualStyleBackColor = true;
            // 
            // sizesBtn
            // 
            sizesBtn.AccessibleRole = AccessibleRole.None;
            sizesBtn.Location = new Point(484, 381);
            sizesBtn.Name = "sizesBtn";
            sizesBtn.Size = new Size(97, 23);
            sizesBtn.TabIndex = 3;
            sizesBtn.Text = "Ver Tamaños";
            sizesBtn.UseVisualStyleBackColor = true;
            sizesBtn.Click += sizesBtn_Click;
            // 
            // addProd
            // 
            addProd.Location = new Point(129, 381);
            addProd.Name = "addProd";
            addProd.Size = new Size(153, 23);
            addProd.TabIndex = 2;
            addProd.Text = "Agregar Producto";
            addProd.UseVisualStyleBackColor = true;
            addProd.Click += addProd_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.ForeColor = Color.Black;
            flowLayoutPanel1.Location = new Point(8, 9);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(793, 349);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(812, 0);
            panel1.TabIndex = 0;
            // 
            // addProdTab
            // 
            addProdTab.Controls.Add(addProd_AddBtn);
            addProdTab.Controls.Add(textBox1);
            addProdTab.Controls.Add(addProdLbl3);
            addProdTab.Controls.Add(addProdLbl2);
            addProdTab.Controls.Add(addProdLbl1);
            addProdTab.Controls.Add(addProd_Back);
            addProdTab.Controls.Add(DGV_Size_AddT);
            addProdTab.Controls.Add(DGV_P_AddT);
            addProdTab.Location = new Point(4, 26);
            addProdTab.Name = "addProdTab";
            addProdTab.Padding = new Padding(3);
            addProdTab.Size = new Size(818, 430);
            addProdTab.TabIndex = 1;
            addProdTab.Text = "AddProd";
            addProdTab.UseVisualStyleBackColor = true;
            addProdTab.Click += addProdTab_Click;
            // 
            // addProd_AddBtn
            // 
            addProd_AddBtn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addProd_AddBtn.ForeColor = Color.FromArgb(64, 64, 64);
            addProd_AddBtn.Location = new Point(344, 290);
            addProd_AddBtn.Name = "addProd_AddBtn";
            addProd_AddBtn.Size = new Size(106, 33);
            addProd_AddBtn.TabIndex = 7;
            addProd_AddBtn.Text = "Agregar";
            addProd_AddBtn.UseVisualStyleBackColor = true;
            addProd_AddBtn.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(225, 243);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 22);
            textBox1.TabIndex = 6;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // addProdLbl3
            // 
            addProdLbl3.AutoSize = true;
            addProdLbl3.ForeColor = Color.FromArgb(64, 64, 64);
            addProdLbl3.Location = new Point(81, 246);
            addProdLbl3.Name = "addProdLbl3";
            addProdLbl3.Size = new Size(138, 17);
            addProdLbl3.TabIndex = 5;
            addProdLbl3.Text = "Ingrese el stock inicial";
            // 
            // addProdLbl2
            // 
            addProdLbl2.AutoSize = true;
            addProdLbl2.ForeColor = Color.FromArgb(64, 64, 64);
            addProdLbl2.Location = new Point(469, 24);
            addProdLbl2.Name = "addProdLbl2";
            addProdLbl2.Size = new Size(140, 17);
            addProdLbl2.TabIndex = 4;
            addProdLbl2.Text = "Seleccione el tamaño";
            // 
            // addProdLbl1
            // 
            addProdLbl1.AutoSize = true;
            addProdLbl1.ForeColor = Color.FromArgb(64, 64, 64);
            addProdLbl1.Location = new Point(96, 24);
            addProdLbl1.Name = "addProdLbl1";
            addProdLbl1.Size = new Size(149, 17);
            addProdLbl1.TabIndex = 3;
            addProdLbl1.Text = "Seleccione el producto";
            // 
            // addProd_Back
            // 
            addProd_Back.ForeColor = Color.FromArgb(64, 64, 64);
            addProd_Back.Location = new Point(21, 388);
            addProd_Back.Name = "addProd_Back";
            addProd_Back.Size = new Size(75, 23);
            addProd_Back.TabIndex = 2;
            addProd_Back.Text = "Volver";
            addProd_Back.UseVisualStyleBackColor = true;
            addProd_Back.Click += addProd_Back_Click;
            // 
            // DGV_Size_AddT
            // 
            DGV_Size_AddT.AllowUserToAddRows = false;
            DGV_Size_AddT.AllowUserToResizeColumns = false;
            DGV_Size_AddT.AllowUserToResizeRows = false;
            DGV_Size_AddT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_Size_AddT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Size_AddT.BackgroundColor = Color.White;
            DGV_Size_AddT.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV_Size_AddT.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGV_Size_AddT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGV_Size_AddT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGV_Size_AddT.EnableHeadersVisualStyles = false;
            DGV_Size_AddT.GridColor = Color.DarkBlue;
            DGV_Size_AddT.Location = new Point(423, 62);
            DGV_Size_AddT.Name = "DGV_Size_AddT";
            DGV_Size_AddT.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.Plum;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGV_Size_AddT.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGV_Size_AddT.RowHeadersVisible = false;
            DGV_Size_AddT.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.Plum;
            DGV_Size_AddT.RowsDefaultCellStyle = dataGridViewCellStyle3;
            DGV_Size_AddT.RowTemplate.Height = 25;
            DGV_Size_AddT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Size_AddT.Size = new Size(320, 132);
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
            DGV_P_AddT.BackgroundColor = Color.White;
            DGV_P_AddT.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV_P_AddT.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DGV_P_AddT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DGV_P_AddT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGV_P_AddT.EnableHeadersVisualStyles = false;
            DGV_P_AddT.GridColor = Color.DarkBlue;
            DGV_P_AddT.ImeMode = ImeMode.NoControl;
            DGV_P_AddT.Location = new Point(62, 62);
            DGV_P_AddT.Name = "DGV_P_AddT";
            DGV_P_AddT.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = Color.Plum;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DGV_P_AddT.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DGV_P_AddT.RowHeadersVisible = false;
            DGV_P_AddT.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.SelectionBackColor = Color.Plum;
            DGV_P_AddT.RowsDefaultCellStyle = dataGridViewCellStyle6;
            DGV_P_AddT.RowTemplate.Height = 25;
            DGV_P_AddT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_P_AddT.Size = new Size(321, 132);
            DGV_P_AddT.TabIndex = 0;
            // 
            // tabSizes
            // 
            tabSizes.Controls.Add(sizesAddTB);
            tabSizes.Controls.Add(sizesDelBtn);
            tabSizes.Controls.Add(sizesAddBtn);
            tabSizes.Controls.Add(sizesBackBtn);
            tabSizes.Controls.Add(label1);
            tabSizes.Controls.Add(DGV_Sizes);
            tabSizes.Location = new Point(4, 26);
            tabSizes.Name = "tabSizes";
            tabSizes.Padding = new Padding(3);
            tabSizes.Size = new Size(818, 430);
            tabSizes.TabIndex = 2;
            tabSizes.Text = "Tamaños";
            tabSizes.UseVisualStyleBackColor = true;
            // 
            // sizesAddTB
            // 
            sizesAddTB.Location = new Point(404, 111);
            sizesAddTB.Name = "sizesAddTB";
            sizesAddTB.Size = new Size(100, 22);
            sizesAddTB.TabIndex = 5;
            sizesAddTB.KeyPress += textBox1_KeyPress;
            // 
            // sizesDelBtn
            // 
            sizesDelBtn.ForeColor = Color.Black;
            sizesDelBtn.Location = new Point(404, 208);
            sizesDelBtn.Name = "sizesDelBtn";
            sizesDelBtn.Size = new Size(84, 43);
            sizesDelBtn.TabIndex = 4;
            sizesDelBtn.Text = "Eliminar Tamaño";
            sizesDelBtn.UseVisualStyleBackColor = true;
            sizesDelBtn.Click += sizesDelBtn_Click;
            // 
            // sizesAddBtn
            // 
            sizesAddBtn.ForeColor = Color.Black;
            sizesAddBtn.Location = new Point(510, 101);
            sizesAddBtn.Name = "sizesAddBtn";
            sizesAddBtn.Size = new Size(84, 43);
            sizesAddBtn.TabIndex = 3;
            sizesAddBtn.Text = "Agregar Tamaño";
            sizesAddBtn.UseVisualStyleBackColor = true;
            sizesAddBtn.Click += sizesAddBtn_Click;
            // 
            // sizesBackBtn
            // 
            sizesBackBtn.Location = new Point(50, 380);
            sizesBackBtn.Name = "sizesBackBtn";
            sizesBackBtn.Size = new Size(75, 23);
            sizesBackBtn.TabIndex = 2;
            sizesBackBtn.Text = "Volver";
            sizesBackBtn.UseVisualStyleBackColor = true;
            sizesBackBtn.Click += sizesBackBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(168, 34);
            label1.Name = "label1";
            label1.Size = new Size(60, 17);
            label1.TabIndex = 1;
            label1.Text = "Tamaños";
            // 
            // DGV_Sizes
            // 
            DGV_Sizes.AllowUserToAddRows = false;
            DGV_Sizes.AllowUserToDeleteRows = false;
            DGV_Sizes.AllowUserToResizeColumns = false;
            DGV_Sizes.AllowUserToResizeRows = false;
            DGV_Sizes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Sizes.BackgroundColor = Color.White;
            DGV_Sizes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV_Sizes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            DGV_Sizes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            DGV_Sizes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Sizes.EnableHeadersVisualStyles = false;
            DGV_Sizes.GridColor = Color.DarkSlateBlue;
            DGV_Sizes.Location = new Point(72, 71);
            DGV_Sizes.MultiSelect = false;
            DGV_Sizes.Name = "DGV_Sizes";
            DGV_Sizes.ReadOnly = true;
            DGV_Sizes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle8.SelectionBackColor = Color.Plum;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            DGV_Sizes.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            DGV_Sizes.RowHeadersVisible = false;
            DGV_Sizes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle9.SelectionBackColor = Color.Plum;
            DGV_Sizes.RowsDefaultCellStyle = dataGridViewCellStyle9;
            DGV_Sizes.RowTemplate.Height = 25;
            DGV_Sizes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Sizes.Size = new Size(240, 265);
            DGV_Sizes.TabIndex = 0;
            // 
            // ModStock
            // 
            ModStock.Controls.Add(textBox2);
            ModStock.Controls.Add(pictureBox1);
            ModStock.Controls.Add(label2);
            ModStock.Controls.Add(stockBackBtn);
            ModStock.Controls.Add(decStockBtn);
            ModStock.Controls.Add(incStockBtn);
            ModStock.Controls.Add(DGV_Stock);
            ModStock.Location = new Point(4, 26);
            ModStock.Name = "ModStock";
            ModStock.Size = new Size(818, 430);
            ModStock.TabIndex = 3;
            ModStock.Text = "ModStock";
            ModStock.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(382, 273);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 22);
            textBox2.TabIndex = 10;
            textBox2.KeyPress += textBox1_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(62, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 141);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(353, 253);
            label2.Name = "label2";
            label2.Size = new Size(161, 17);
            label2.TabIndex = 8;
            label2.Text = "Actualizar stock existente";
            // 
            // stockBackBtn
            // 
            stockBackBtn.ForeColor = Color.Black;
            stockBackBtn.Location = new Point(8, 390);
            stockBackBtn.Name = "stockBackBtn";
            stockBackBtn.Size = new Size(75, 23);
            stockBackBtn.TabIndex = 5;
            stockBackBtn.Text = "Volver";
            stockBackBtn.UseVisualStyleBackColor = true;
            stockBackBtn.Click += stockBackBtn_Click;
            // 
            // decStockBtn
            // 
            decStockBtn.ForeColor = Color.Black;
            decStockBtn.Location = new Point(438, 301);
            decStockBtn.Name = "decStockBtn";
            decStockBtn.Size = new Size(44, 28);
            decStockBtn.TabIndex = 3;
            decStockBtn.Text = "-";
            decStockBtn.UseVisualStyleBackColor = true;
            decStockBtn.Click += decStockBtn_Click;
            // 
            // incStockBtn
            // 
            incStockBtn.ForeColor = Color.Black;
            incStockBtn.Location = new Point(388, 301);
            incStockBtn.Name = "incStockBtn";
            incStockBtn.Size = new Size(44, 28);
            incStockBtn.TabIndex = 2;
            incStockBtn.Text = "+";
            incStockBtn.UseVisualStyleBackColor = true;
            incStockBtn.Click += incStockBtn_Click;
            // 
            // DGV_Stock
            // 
            DGV_Stock.AllowUserToAddRows = false;
            DGV_Stock.AllowUserToDeleteRows = false;
            DGV_Stock.AllowUserToResizeColumns = false;
            DGV_Stock.AllowUserToResizeRows = false;
            DGV_Stock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Stock.BackgroundColor = Color.White;
            DGV_Stock.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV_Stock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle10.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            DGV_Stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            DGV_Stock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Stock.EnableHeadersVisualStyles = false;
            DGV_Stock.GridColor = Color.DarkBlue;
            DGV_Stock.Location = new Point(62, 201);
            DGV_Stock.MultiSelect = false;
            DGV_Stock.Name = "DGV_Stock";
            DGV_Stock.ReadOnly = true;
            DGV_Stock.RowHeadersVisible = false;
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle11.SelectionBackColor = Color.Plum;
            DGV_Stock.RowsDefaultCellStyle = dataGridViewCellStyle11;
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

        private TabControl tabControl1;
        private TabPage tabView;
        private TabPage addProdTab;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TabPage tabSizes;
        private Button addProd;
        private DataGridView DGV_Size_AddT;
        private DataGridView DGV_P_AddT;
        private Button addProd_Back;
        private TextBox textBox1;
        private Label addProdLbl3;
        private Label addProdLbl2;
        private Label addProdLbl1;
        private Button addProd_AddBtn;
        private Button sizesBtn;
        private DataGridView DGV_Sizes;
        private Button sizesDelBtn;
        private Button sizesAddBtn;
        private Button sizesBackBtn;
        private Label label1;
        private TextBox sizesAddTB;
        private TabPage ModStock;
        private Button decStockBtn;
        private Button incStockBtn;
        private DataGridView DGV_Stock;
        private Label label2;
        private Button stockBackBtn;
        private PictureBox pictureBox1;
        private TextBox textBox2;
    }
}
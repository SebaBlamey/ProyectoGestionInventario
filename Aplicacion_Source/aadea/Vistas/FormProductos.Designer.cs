using aadea.Extras;
using aadea.Properties;

namespace aadea.Vistas
{
    partial class FormProductos
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
            EditP = new TabPage();
            search_BtnEdit = new FontAwesome.Sharp.IconButton();
            save_BtnEdit = new FontAwesome.Sharp.IconButton();
            cancel_BtnEdit = new FontAwesome.Sharp.IconButton();
            cambiarBox = new PictureBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            AddP = new TabPage();
            save_iconBtn = new FontAwesome.Sharp.IconButton();
            cancelAdd_btn = new FontAwesome.Sharp.IconButton();
            iconBtnExaminar = new FontAwesome.Sharp.IconButton();
            examinarPic = new PictureBox();
            txtDesc = new TextBox();
            txtProduct = new TextBox();
            lbdesc = new Label();
            label1 = new Label();
            productList = new TabPage();
            AddProduct = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tabControl = new TabControlEx();
            EditP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cambiarBox).BeginInit();
            AddP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)examinarPic).BeginInit();
            productList.SuspendLayout();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // EditP
            // 
            EditP.BackColor = Color.FromArgb(115, 124, 141);
            EditP.Controls.Add(search_BtnEdit);
            EditP.Controls.Add(save_BtnEdit);
            EditP.Controls.Add(cancel_BtnEdit);
            EditP.Controls.Add(cambiarBox);
            EditP.Controls.Add(textBox2);
            EditP.Controls.Add(textBox1);
            EditP.Controls.Add(label3);
            EditP.Controls.Add(label2);
            EditP.Location = new Point(-2, 26);
            EditP.Name = "EditP";
            EditP.Padding = new Padding(3);
            EditP.Size = new Size(679, 450);
            EditP.TabIndex = 2;
            EditP.Text = "EditP";
            // 
            // search_BtnEdit
            // 
            search_BtnEdit.BackColor = Color.FromArgb(217, 145, 0);
            search_BtnEdit.Cursor = Cursors.Hand;
            search_BtnEdit.FlatAppearance.BorderColor = Color.FromArgb(177, 105, 0);
            search_BtnEdit.FlatAppearance.BorderSize = 2;
            search_BtnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(177, 105, 0);
            search_BtnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(197, 125, 0);
            search_BtnEdit.FlatStyle = FlatStyle.Flat;
            search_BtnEdit.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            search_BtnEdit.ForeColor = SystemColors.Control;
            search_BtnEdit.IconChar = FontAwesome.Sharp.IconChar.Images;
            search_BtnEdit.IconColor = SystemColors.Control;
            search_BtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            search_BtnEdit.IconSize = 28;
            search_BtnEdit.Location = new Point(379, 201);
            search_BtnEdit.Name = "search_BtnEdit";
            search_BtnEdit.Size = new Size(118, 33);
            search_BtnEdit.TabIndex = 12;
            search_BtnEdit.Text = "Examinar";
            search_BtnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            search_BtnEdit.UseVisualStyleBackColor = false;
            search_BtnEdit.Click += search_BtnEdit_Click;
            // 
            // save_BtnEdit
            // 
            save_BtnEdit.BackColor = Color.FromArgb(40, 167, 69);
            save_BtnEdit.Cursor = Cursors.Hand;
            save_BtnEdit.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 29);
            save_BtnEdit.FlatAppearance.BorderSize = 2;
            save_BtnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 127, 29);
            save_BtnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 147, 49);
            save_BtnEdit.FlatStyle = FlatStyle.Flat;
            save_BtnEdit.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            save_BtnEdit.ForeColor = SystemColors.Control;
            save_BtnEdit.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            save_BtnEdit.IconColor = SystemColors.Control;
            save_BtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            save_BtnEdit.IconSize = 28;
            save_BtnEdit.Location = new Point(43, 247);
            save_BtnEdit.Name = "save_BtnEdit";
            save_BtnEdit.Size = new Size(118, 33);
            save_BtnEdit.TabIndex = 11;
            save_BtnEdit.Text = "Guardar";
            save_BtnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            save_BtnEdit.UseVisualStyleBackColor = false;
            save_BtnEdit.Click += save_BtnEdit_Click;
            // 
            // cancel_BtnEdit
            // 
            cancel_BtnEdit.BackColor = Color.FromArgb(204, 102, 102);
            cancel_BtnEdit.Cursor = Cursors.Hand;
            cancel_BtnEdit.FlatAppearance.BorderColor = Color.FromArgb(154, 52, 52);
            cancel_BtnEdit.FlatAppearance.BorderSize = 2;
            cancel_BtnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(154, 52, 52);
            cancel_BtnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(164, 62, 62);
            cancel_BtnEdit.FlatStyle = FlatStyle.Flat;
            cancel_BtnEdit.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cancel_BtnEdit.ForeColor = SystemColors.Control;
            cancel_BtnEdit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            cancel_BtnEdit.IconColor = SystemColors.Control;
            cancel_BtnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            cancel_BtnEdit.IconSize = 28;
            cancel_BtnEdit.Location = new Point(182, 247);
            cancel_BtnEdit.Name = "cancel_BtnEdit";
            cancel_BtnEdit.Size = new Size(118, 33);
            cancel_BtnEdit.TabIndex = 10;
            cancel_BtnEdit.Text = "Cancelar";
            cancel_BtnEdit.TextImageRelation = TextImageRelation.ImageBeforeText;
            cancel_BtnEdit.UseVisualStyleBackColor = false;
            cancel_BtnEdit.Click += cancel_BtnEdit_Click;
            // 
            // cambiarBox
            // 
            cambiarBox.Location = new Point(364, 37);
            cambiarBox.Name = "cambiarBox";
            cambiarBox.Size = new Size(153, 158);
            cambiarBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cambiarBox.TabIndex = 4;
            cambiarBox.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(155, 164, 181);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(43, 162);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(257, 67);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(155, 164, 181);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(43, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 27);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 136);
            label3.Name = "label3";
            label3.Size = new Size(177, 23);
            label3.TabIndex = 2;
            label3.Text = "Editar descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(40, 37);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 0;
            label2.Text = "Editar nombre";
            // 
            // AddP
            // 
            AddP.BackColor = Color.FromArgb(115, 124, 141);
            AddP.Controls.Add(save_iconBtn);
            AddP.Controls.Add(cancelAdd_btn);
            AddP.Controls.Add(iconBtnExaminar);
            AddP.Controls.Add(examinarPic);
            AddP.Controls.Add(txtDesc);
            AddP.Controls.Add(txtProduct);
            AddP.Controls.Add(lbdesc);
            AddP.Controls.Add(label1);
            AddP.Location = new Point(-2, 26);
            AddP.Name = "AddP";
            AddP.Padding = new Padding(3);
            AddP.Size = new Size(679, 450);
            AddP.TabIndex = 1;
            AddP.Text = "AgregarProductos";
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
            save_iconBtn.Location = new Point(43, 247);
            save_iconBtn.Name = "save_iconBtn";
            save_iconBtn.Size = new Size(118, 33);
            save_iconBtn.TabIndex = 10;
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
            cancelAdd_btn.Location = new Point(182, 247);
            cancelAdd_btn.Name = "cancelAdd_btn";
            cancelAdd_btn.Size = new Size(118, 33);
            cancelAdd_btn.TabIndex = 9;
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
            iconBtnExaminar.Location = new Point(379, 201);
            iconBtnExaminar.Name = "iconBtnExaminar";
            iconBtnExaminar.Size = new Size(118, 33);
            iconBtnExaminar.TabIndex = 8;
            iconBtnExaminar.Text = "Examinar";
            iconBtnExaminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnExaminar.UseVisualStyleBackColor = false;
            iconBtnExaminar.Click += iconBtnExaminar_Click;
            // 
            // examinarPic
            // 
            examinarPic.BackColor = Color.FromArgb(155, 164, 181);
            examinarPic.BackgroundImage = Resource.defaultImage;
            examinarPic.InitialImage = Resource.defaultImage;
            examinarPic.Location = new Point(364, 37);
            examinarPic.Name = "examinarPic";
            examinarPic.Size = new Size(153, 158);
            examinarPic.SizeMode = PictureBoxSizeMode.StretchImage;
            examinarPic.TabIndex = 4;
            examinarPic.TabStop = false;
            // 
            // txtDesc
            // 
            txtDesc.BackColor = Color.FromArgb(155, 164, 181);
            txtDesc.BorderStyle = BorderStyle.FixedSingle;
            txtDesc.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDesc.ForeColor = Color.Black;
            txtDesc.Location = new Point(43, 162);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(257, 67);
            txtDesc.TabIndex = 3;
            // 
            // txtProduct
            // 
            txtProduct.BackColor = Color.FromArgb(155, 164, 181);
            txtProduct.BorderStyle = BorderStyle.FixedSingle;
            txtProduct.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtProduct.ForeColor = Color.Black;
            txtProduct.Location = new Point(43, 63);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(257, 27);
            txtProduct.TabIndex = 2;
            txtProduct.TextChanged += txtProduct_TextChanged;
            // 
            // lbdesc
            // 
            lbdesc.AutoSize = true;
            lbdesc.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbdesc.ForeColor = Color.White;
            lbdesc.Location = new Point(40, 136);
            lbdesc.Name = "lbdesc";
            lbdesc.Size = new Size(119, 23);
            lbdesc.TabIndex = 1;
            lbdesc.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 37);
            label1.Name = "label1";
            label1.Size = new Size(175, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre producto";
            // 
            // productList
            // 
            productList.BackColor = Color.FromArgb(115, 124, 141);
            productList.BackgroundImageLayout = ImageLayout.None;
            productList.Controls.Add(AddProduct);
            productList.Controls.Add(flowLayoutPanel1);
            productList.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            productList.ForeColor = Color.Black;
            productList.Location = new Point(-2, 26);
            productList.Name = "productList";
            productList.Padding = new Padding(3);
            productList.Size = new Size(679, 450);
            productList.TabIndex = 0;
            productList.Text = "ListaProductos";
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
            AddProduct.Location = new Point(564, 400);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(106, 33);
            AddProduct.TabIndex = 10;
            AddProduct.Text = "Agregar";
            AddProduct.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddProduct.UseVisualStyleBackColor = false;
            AddProduct.Click += AddProduct_Click_1;
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
            // tabControl
            // 
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.Controls.Add(productList);
            tabControl.Controls.Add(AddP);
            tabControl.Controls.Add(EditP);
            tabControl.Dock = DockStyle.Top;
            tabControl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl.ImeMode = ImeMode.On;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(0);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(0, 0);
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(675, 474);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabIndex = 2;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(155, 164, 181);
            ClientSize = new Size(675, 477);
            Controls.Add(tabControl);
            Name = "FormProductos";
            Text = "FormProductis";
            Load += FormProductos_Load;
            EditP.ResumeLayout(false);
            EditP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cambiarBox).EndInit();
            AddP.ResumeLayout(false);
            AddP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)examinarPic).EndInit();
            productList.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage EditP;
        private PictureBox cambiarBox;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private TabPage AddP;
        private PictureBox examinarPic;
        private TextBox txtDesc;
        private TextBox txtProduct;
        private Label lbdesc;
        private Label label1;
        private TabPage productList;
        private FontAwesome.Sharp.IconButton AddProduct;
        private FlowLayoutPanel flowLayoutPanel1;
        private TabControlEx tabControl;
        private FontAwesome.Sharp.IconButton iconBtnExaminar;
        private FontAwesome.Sharp.IconButton save_iconBtn;
        private FontAwesome.Sharp.IconButton cancelAdd_btn;
        private FontAwesome.Sharp.IconButton search_BtnEdit;
        private FontAwesome.Sharp.IconButton save_BtnEdit;
        private FontAwesome.Sharp.IconButton cancel_BtnEdit;
    }
}
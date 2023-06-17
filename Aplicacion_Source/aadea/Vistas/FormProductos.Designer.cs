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
            tabControl = new TabControl();
            productList = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btDelete = new Button();
            EdtiProduct = new Button();
            AddProduct = new Button();
            labeltitle = new Label();
            AddP = new TabPage();
            btCancelAdd = new Button();
            btSaveAdd = new Button();
            btExaminar = new Button();
            examinarPic = new PictureBox();
            txtDesc = new TextBox();
            txtProduct = new TextBox();
            lbdesc = new Label();
            label1 = new Label();
            EditP = new TabPage();
            btCancelEdit = new Button();
            btSaveEdit = new Button();
            btexam = new Button();
            cambiarBox = new PictureBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            tabControl.SuspendLayout();
            productList.SuspendLayout();
            AddP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)examinarPic).BeginInit();
            EditP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cambiarBox).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(productList);
            tabControl.Controls.Add(AddP);
            tabControl.Controls.Add(EditP);
            tabControl.Dock = DockStyle.Top;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(691, 423);
            tabControl.TabIndex = 2;
            // 
            // productList
            // 
            productList.Controls.Add(flowLayoutPanel1);
            productList.Controls.Add(btDelete);
            productList.Controls.Add(EdtiProduct);
            productList.Controls.Add(AddProduct);
            productList.Controls.Add(labeltitle);
            productList.Location = new Point(4, 24);
            productList.Name = "productList";
            productList.Padding = new Padding(3);
            productList.Size = new Size(683, 395);
            productList.TabIndex = 0;
            productList.Text = "ListaProductos";
            productList.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(17, 68);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(658, 317);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(488, 13);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(121, 23);
            btDelete.TabIndex = 8;
            btDelete.Text = "Eliminar";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // EdtiProduct
            // 
            EdtiProduct.Location = new Point(332, 13);
            EdtiProduct.Name = "EdtiProduct";
            EdtiProduct.Size = new Size(121, 23);
            EdtiProduct.TabIndex = 7;
            EdtiProduct.Text = "Editar";
            EdtiProduct.UseVisualStyleBackColor = true;
            EdtiProduct.Click += EdtiProduct_Click;
            // 
            // AddProduct
            // 
            AddProduct.Location = new Point(184, 13);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(121, 23);
            AddProduct.TabIndex = 6;
            AddProduct.Text = "Agregar";
            AddProduct.UseVisualStyleBackColor = true;
            AddProduct.Click += AddProduct_Click;
            // 
            // labeltitle
            // 
            labeltitle.AutoSize = true;
            labeltitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labeltitle.Location = new Point(17, 12);
            labeltitle.Name = "labeltitle";
            labeltitle.Size = new Size(80, 21);
            labeltitle.TabIndex = 1;
            labeltitle.Text = "Productos";
            // 
            // AddP
            // 
            AddP.Controls.Add(btCancelAdd);
            AddP.Controls.Add(btSaveAdd);
            AddP.Controls.Add(btExaminar);
            AddP.Controls.Add(examinarPic);
            AddP.Controls.Add(txtDesc);
            AddP.Controls.Add(txtProduct);
            AddP.Controls.Add(lbdesc);
            AddP.Controls.Add(label1);
            AddP.Location = new Point(4, 24);
            AddP.Name = "AddP";
            AddP.Padding = new Padding(3);
            AddP.Size = new Size(683, 395);
            AddP.TabIndex = 1;
            AddP.Text = "AgregarProductos";
            AddP.UseVisualStyleBackColor = true;
            // 
            // btCancelAdd
            // 
            btCancelAdd.Location = new Point(184, 276);
            btCancelAdd.Name = "btCancelAdd";
            btCancelAdd.Size = new Size(75, 23);
            btCancelAdd.TabIndex = 7;
            btCancelAdd.Text = "Cancelar";
            btCancelAdd.UseVisualStyleBackColor = true;
            btCancelAdd.Click += btCancelAdd_Click;
            // 
            // btSaveAdd
            // 
            btSaveAdd.Location = new Point(43, 276);
            btSaveAdd.Name = "btSaveAdd";
            btSaveAdd.Size = new Size(75, 23);
            btSaveAdd.TabIndex = 6;
            btSaveAdd.Text = "Guardar";
            btSaveAdd.UseVisualStyleBackColor = true;
            btSaveAdd.Click += button1_Click;
            // 
            // btExaminar
            // 
            btExaminar.Location = new Point(405, 201);
            btExaminar.Name = "btExaminar";
            btExaminar.Size = new Size(75, 23);
            btExaminar.TabIndex = 5;
            btExaminar.Text = "Examinar";
            btExaminar.UseVisualStyleBackColor = true;
            btExaminar.Click += btExaminar_Click;
            // 
            // examinarPic
            // 
            examinarPic.Location = new Point(364, 37);
            examinarPic.Name = "examinarPic";
            examinarPic.Size = new Size(153, 158);
            examinarPic.SizeMode = PictureBoxSizeMode.Zoom;
            examinarPic.TabIndex = 4;
            examinarPic.TabStop = false;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(43, 179);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(216, 55);
            txtDesc.TabIndex = 3;
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(43, 74);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(206, 23);
            txtProduct.TabIndex = 2;
            // 
            // lbdesc
            // 
            lbdesc.AutoSize = true;
            lbdesc.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbdesc.Location = new Point(40, 136);
            lbdesc.Name = "lbdesc";
            lbdesc.Size = new Size(87, 20);
            lbdesc.TabIndex = 1;
            lbdesc.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 37);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre producto";
            // 
            // EditP
            // 
            EditP.Controls.Add(btCancelEdit);
            EditP.Controls.Add(btSaveEdit);
            EditP.Controls.Add(btexam);
            EditP.Controls.Add(cambiarBox);
            EditP.Controls.Add(textBox2);
            EditP.Controls.Add(label3);
            EditP.Controls.Add(textBox1);
            EditP.Controls.Add(label2);
            EditP.Location = new Point(4, 24);
            EditP.Name = "EditP";
            EditP.Padding = new Padding(3);
            EditP.Size = new Size(683, 395);
            EditP.TabIndex = 2;
            EditP.Text = "EditP";
            EditP.UseVisualStyleBackColor = true;
            // 
            // btCancelEdit
            // 
            btCancelEdit.Location = new Point(183, 297);
            btCancelEdit.Name = "btCancelEdit";
            btCancelEdit.Size = new Size(75, 23);
            btCancelEdit.TabIndex = 7;
            btCancelEdit.Text = "Cancelar";
            btCancelEdit.UseVisualStyleBackColor = true;
            btCancelEdit.Click += btCancelEdit_Click;
            // 
            // btSaveEdit
            // 
            btSaveEdit.Location = new Point(40, 297);
            btSaveEdit.Name = "btSaveEdit";
            btSaveEdit.Size = new Size(75, 23);
            btSaveEdit.TabIndex = 6;
            btSaveEdit.Text = "Guardar";
            btSaveEdit.UseVisualStyleBackColor = true;
            // 
            // btexam
            // 
            btexam.Location = new Point(353, 218);
            btexam.Name = "btexam";
            btexam.Size = new Size(117, 23);
            btexam.TabIndex = 5;
            btexam.Text = "Examinar";
            btexam.UseVisualStyleBackColor = true;
            // 
            // cambiarBox
            // 
            cambiarBox.Location = new Point(353, 47);
            cambiarBox.Name = "cambiarBox";
            cambiarBox.Size = new Size(160, 154);
            cambiarBox.TabIndex = 4;
            cambiarBox.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(40, 174);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 67);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(40, 141);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 2;
            label3.Text = "Editar descripcion";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 47);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 0;
            label2.Text = "Editar nombre";
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 421);
            Controls.Add(tabControl);
            Name = "FormProductos";
            Text = "FormProductis";
            Load += FormProductos_Load;
            tabControl.ResumeLayout(false);
            productList.ResumeLayout(false);
            productList.PerformLayout();
            AddP.ResumeLayout(false);
            AddP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)examinarPic).EndInit();
            EditP.ResumeLayout(false);
            EditP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cambiarBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl;
        private TabPage productList;
        private TabPage AddP;
        private Label labeltitle;
        private Button btDelete;
        private Button EdtiProduct;
        private TextBox txtProduct;
        private Label lbdesc;
        private Label label1;
        private PictureBox examinarPic;
        private TextBox txtDesc;
        private Button btExaminar;
        private TabPage EditP;
        private Label label2;
        private TextBox textBox1;
        private Button btexam;
        private PictureBox cambiarBox;
        private TextBox textBox2;
        private Label label3;
        private Button AddProduct;
        private Button btCancelAdd;
        private Button btSaveAdd;
        private Button btCancelEdit;
        private Button btSaveEdit;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
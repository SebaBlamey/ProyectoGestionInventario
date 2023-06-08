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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tabControl = new TabControl();
            productList = new TabPage();
            GVProduct = new DataGridView();
            btDelete = new Button();
            EdtiProduct = new Button();
            AddProduct = new Button();
            lbImagen = new Label();
            pictureBox1 = new PictureBox();
            btsearch = new Button();
            txtSearch = new TextBox();
            labeltitle = new Label();
            AddP = new TabPage();
            btExaminar = new Button();
            examinarPic = new PictureBox();
            txtDesc = new TextBox();
            txtProduct = new TextBox();
            lbdesc = new Label();
            label1 = new Label();
            EditP = new TabPage();
            btexam = new Button();
            cambiarBox = new PictureBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            tabControl.SuspendLayout();
            productList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GVProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            productList.Controls.Add(GVProduct);
            productList.Controls.Add(btDelete);
            productList.Controls.Add(EdtiProduct);
            productList.Controls.Add(AddProduct);
            productList.Controls.Add(lbImagen);
            productList.Controls.Add(pictureBox1);
            productList.Controls.Add(btsearch);
            productList.Controls.Add(txtSearch);
            productList.Controls.Add(labeltitle);
            productList.Location = new Point(4, 24);
            productList.Name = "productList";
            productList.Padding = new Padding(3);
            productList.Size = new Size(683, 395);
            productList.TabIndex = 0;
            productList.Text = "ListaProductos";
            productList.UseVisualStyleBackColor = true;
            productList.Click += productList_Click;
            // 
            // GVProduct
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GVProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GVProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GVProduct.EnableHeadersVisualStyles = false;
            GVProduct.Location = new Point(17, 80);
            GVProduct.Name = "GVProduct";
            GVProduct.RowTemplate.Height = 25;
            GVProduct.Size = new Size(456, 289);
            GVProduct.TabIndex = 9;
            GVProduct.CellFormatting += GVProduct_CellFormatting;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(502, 338);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(121, 23);
            btDelete.TabIndex = 8;
            btDelete.Text = "Eliminar";
            btDelete.UseVisualStyleBackColor = true;
            // 
            // EdtiProduct
            // 
            EdtiProduct.Location = new Point(502, 309);
            EdtiProduct.Name = "EdtiProduct";
            EdtiProduct.Size = new Size(121, 23);
            EdtiProduct.TabIndex = 7;
            EdtiProduct.Text = "Editar";
            EdtiProduct.UseVisualStyleBackColor = true;
            EdtiProduct.Click += EdtiProduct_Click;
            // 
            // AddProduct
            // 
            AddProduct.Location = new Point(502, 280);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(121, 23);
            AddProduct.TabIndex = 6;
            AddProduct.Text = "Agregar";
            AddProduct.UseVisualStyleBackColor = true;
            AddProduct.Click += AddProduct_Click;
            // 
            // lbImagen
            // 
            lbImagen.AutoSize = true;
            lbImagen.Location = new Point(548, 96);
            lbImagen.Name = "lbImagen";
            lbImagen.Size = new Size(47, 15);
            lbImagen.TabIndex = 5;
            lbImagen.Text = "Imagen";
            lbImagen.Click += lbImagen_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(491, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 140);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btsearch
            // 
            btsearch.Location = new Point(502, 38);
            btsearch.Name = "btsearch";
            btsearch.Size = new Size(107, 23);
            btsearch.TabIndex = 3;
            btsearch.Text = "Search";
            btsearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(17, 39);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(456, 23);
            txtSearch.TabIndex = 2;
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
            AddP.Click += DetailsP_Click;
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
            examinarPic.Click += pictureBox2_Click;
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
            // btexam
            // 
            btexam.Location = new Point(372, 218);
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
            label2.Click += label2_Click;
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
            ((System.ComponentModel.ISupportInitialize)GVProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label lbImagen;
        private PictureBox pictureBox1;
        private TextBox txtSearch;
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
        private DataGridView GVProduct;
        private Button AddProduct;
        private Button btsearch;
    }
}
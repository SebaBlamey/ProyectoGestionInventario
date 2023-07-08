namespace aadea.Vistas
{
    partial class FormMateriales
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            ListaMateriales = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            AddProduct = new Button();
            label1 = new Label();
            AddMaterial = new TabPage();
            labelResultado = new Label();
            opcionBox = new ComboBox();
            label5 = new Label();
            lblStock = new Label();
            label3 = new Label();
            btExaminar = new Button();
            btCancel = new Button();
            btSave = new Button();
            label2 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            txtStock = new TextBox();
            txtNameInsert = new TextBox();
            EditMaterial = new TabPage();
            boxMedidaActual = new ComboBox();
            txtStockActual = new TextBox();
            txtNameActual = new TextBox();
            picImagenModify = new FontAwesome.Sharp.IconPictureBox();
            btCancelMod = new Button();
            btSaveMod = new Button();
            btAddImagenModify = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btExaminMod = new Button();
            tabControl1.SuspendLayout();
            ListaMateriales.SuspendLayout();
            AddMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            EditMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImagenModify).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ListaMateriales);
            tabControl1.Controls.Add(AddMaterial);
            tabControl1.Controls.Add(EditMaterial);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.ShowToolTips = true;
            tabControl1.Size = new Size(691, 421);
            tabControl1.TabIndex = 0;
            // 
            // ListaMateriales
            // 
            ListaMateriales.Controls.Add(flowLayoutPanel1);
            ListaMateriales.Controls.Add(AddProduct);
            ListaMateriales.Controls.Add(label1);
            ListaMateriales.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ListaMateriales.ForeColor = Color.Black;
            ListaMateriales.Location = new Point(4, 24);
            ListaMateriales.Name = "ListaMateriales";
            ListaMateriales.Padding = new Padding(3);
            ListaMateriales.Size = new Size(683, 393);
            ListaMateriales.TabIndex = 0;
            ListaMateriales.Text = "Materiales";
            ListaMateriales.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanel1.ForeColor = Color.Black;
            flowLayoutPanel1.Location = new Point(17, 59);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(644, 317);
            flowLayoutPanel1.TabIndex = 16;
            // 
            // AddProduct
            // 
            AddProduct.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddProduct.ForeColor = Color.Black;
            AddProduct.Location = new Point(528, 14);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(133, 28);
            AddProduct.TabIndex = 13;
            AddProduct.Text = "Agregar material";
            AddProduct.UseVisualStyleBackColor = true;
            AddProduct.Click += AddProduct_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(17, 12);
            label1.Name = "label1";
            label1.Size = new Size(107, 23);
            label1.TabIndex = 10;
            label1.Text = "Materiales";
            // 
            // AddMaterial
            // 
            AddMaterial.Controls.Add(labelResultado);
            AddMaterial.Controls.Add(opcionBox);
            AddMaterial.Controls.Add(label5);
            AddMaterial.Controls.Add(lblStock);
            AddMaterial.Controls.Add(label3);
            AddMaterial.Controls.Add(btExaminar);
            AddMaterial.Controls.Add(btCancel);
            AddMaterial.Controls.Add(btSave);
            AddMaterial.Controls.Add(label2);
            AddMaterial.Controls.Add(iconPictureBox1);
            AddMaterial.Controls.Add(txtStock);
            AddMaterial.Controls.Add(txtNameInsert);
            AddMaterial.Location = new Point(4, 24);
            AddMaterial.Name = "AddMaterial";
            AddMaterial.Padding = new Padding(3);
            AddMaterial.Size = new Size(683, 393);
            AddMaterial.TabIndex = 1;
            AddMaterial.Text = "Agregar Material";
            AddMaterial.UseVisualStyleBackColor = true;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(39, 212);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 12;
            // 
            // opcionBox
            // 
            opcionBox.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            opcionBox.ForeColor = Color.Black;
            opcionBox.FormattingEnabled = true;
            opcionBox.Location = new Point(150, 172);
            opcionBox.Name = "opcionBox";
            opcionBox.Size = new Size(93, 25);
            opcionBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(150, 140);
            label5.Name = "label5";
            label5.Size = new Size(76, 22);
            label5.TabIndex = 10;
            label5.Text = "Unidad";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStock.ForeColor = Color.Black;
            lblStock.Location = new Point(36, 140);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(60, 22);
            lblStock.TabIndex = 9;
            lblStock.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(39, 53);
            label3.Name = "label3";
            label3.Size = new Size(84, 22);
            label3.TabIndex = 7;
            label3.Text = "Nombre";
            // 
            // btExaminar
            // 
            btExaminar.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btExaminar.ForeColor = Color.Black;
            btExaminar.Location = new Point(383, 208);
            btExaminar.Name = "btExaminar";
            btExaminar.Size = new Size(98, 23);
            btExaminar.TabIndex = 6;
            btExaminar.Text = "Agregar";
            btExaminar.UseVisualStyleBackColor = true;
            btExaminar.Click += btExaminar_Click;
            // 
            // btCancel
            // 
            btCancel.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btCancel.ForeColor = Color.Black;
            btCancel.Location = new Point(145, 255);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(75, 23);
            btCancel.TabIndex = 5;
            btCancel.Text = "Cancelar";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // btSave
            // 
            btSave.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btSave.ForeColor = Color.Black;
            btSave.Location = new Point(36, 255);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 23);
            btSave.TabIndex = 4;
            btSave.Text = "Guardar";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(383, 32);
            label2.Name = "label2";
            label2.Size = new Size(82, 22);
            label2.TabIndex = 3;
            label2.Text = "Imagen";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 141;
            iconPictureBox1.Location = new Point(353, 57);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(146, 141);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.ForeColor = Color.Black;
            txtStock.Location = new Point(36, 175);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(72, 22);
            txtStock.TabIndex = 1;
            txtStock.KeyPress += txtStock_KeyPress;
            // 
            // txtNameInsert
            // 
            txtNameInsert.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNameInsert.ForeColor = Color.Black;
            txtNameInsert.Location = new Point(39, 81);
            txtNameInsert.Name = "txtNameInsert";
            txtNameInsert.Size = new Size(181, 22);
            txtNameInsert.TabIndex = 0;
            // 
            // EditMaterial
            // 
            EditMaterial.Controls.Add(btExaminMod);
            EditMaterial.Controls.Add(boxMedidaActual);
            EditMaterial.Controls.Add(txtStockActual);
            EditMaterial.Controls.Add(txtNameActual);
            EditMaterial.Controls.Add(picImagenModify);
            EditMaterial.Controls.Add(btCancelMod);
            EditMaterial.Controls.Add(btSaveMod);
            EditMaterial.Controls.Add(btAddImagenModify);
            EditMaterial.Controls.Add(label8);
            EditMaterial.Controls.Add(label7);
            EditMaterial.Controls.Add(label6);
            EditMaterial.Controls.Add(label4);
            EditMaterial.Location = new Point(4, 24);
            EditMaterial.Name = "EditMaterial";
            EditMaterial.Size = new Size(683, 393);
            EditMaterial.TabIndex = 2;
            EditMaterial.Text = "Modificar Material";
            EditMaterial.UseVisualStyleBackColor = true;
            // 
            // boxMedidaActual
            // 
            boxMedidaActual.ForeColor = Color.Black;
            boxMedidaActual.FormattingEnabled = true;
            boxMedidaActual.Location = new Point(186, 179);
            boxMedidaActual.Name = "boxMedidaActual";
            boxMedidaActual.Size = new Size(121, 23);
            boxMedidaActual.TabIndex = 10;
            // 
            // txtStockActual
            // 
            txtStockActual.ForeColor = Color.Black;
            txtStockActual.Location = new Point(41, 179);
            txtStockActual.Name = "txtStockActual";
            txtStockActual.Size = new Size(125, 23);
            txtStockActual.TabIndex = 9;
            // 
            // txtNameActual
            // 
            txtNameActual.ForeColor = Color.Black;
            txtNameActual.Location = new Point(41, 74);
            txtNameActual.Name = "txtNameActual";
            txtNameActual.Size = new Size(251, 23);
            txtNameActual.TabIndex = 8;
            // 
            // picImagenModify
            // 
            picImagenModify.BackColor = Color.Transparent;
            picImagenModify.ForeColor = SystemColors.ControlText;
            picImagenModify.IconChar = FontAwesome.Sharp.IconChar.None;
            picImagenModify.IconColor = SystemColors.ControlText;
            picImagenModify.IconFont = FontAwesome.Sharp.IconFont.Auto;
            picImagenModify.IconSize = 148;
            picImagenModify.Location = new Point(385, 63);
            picImagenModify.Name = "picImagenModify";
            picImagenModify.Size = new Size(148, 151);
            picImagenModify.TabIndex = 7;
            picImagenModify.TabStop = false;
            // 
            // btCancelMod
            // 
            btCancelMod.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btCancelMod.ForeColor = Color.Black;
            btCancelMod.Location = new Point(186, 256);
            btCancelMod.Name = "btCancelMod";
            btCancelMod.Size = new Size(75, 23);
            btCancelMod.TabIndex = 6;
            btCancelMod.Text = "Cancelar";
            btCancelMod.UseVisualStyleBackColor = true;
            btCancelMod.Click += btCancelMod_Click;
            // 
            // btSaveMod
            // 
            btSaveMod.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btSaveMod.ForeColor = Color.Black;
            btSaveMod.Location = new Point(91, 256);
            btSaveMod.Name = "btSaveMod";
            btSaveMod.Size = new Size(75, 23);
            btSaveMod.TabIndex = 5;
            btSaveMod.Text = "Guardar";
            btSaveMod.UseVisualStyleBackColor = true;
            btSaveMod.Click += btSaveMod_Click;
            // 
            // btAddImagenModify
            // 
            btAddImagenModify.Location = new Point(0, 0);
            btAddImagenModify.Name = "btAddImagenModify";
            btAddImagenModify.Size = new Size(75, 23);
            btAddImagenModify.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(418, 38);
            label8.Name = "label8";
            label8.Size = new Size(82, 22);
            label8.TabIndex = 3;
            label8.Text = "Imagen";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(186, 146);
            label7.Name = "label7";
            label7.Size = new Size(76, 22);
            label7.TabIndex = 2;
            label7.Text = "Unidad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(41, 146);
            label6.Name = "label6";
            label6.Size = new Size(125, 22);
            label6.TabIndex = 1;
            label6.Text = "Stock actual";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(41, 33);
            label4.Name = "label4";
            label4.Size = new Size(149, 22);
            label4.TabIndex = 0;
            label4.Text = "Nombre actual";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btExaminMod
            // 
            btExaminMod.Location = new Point(425, 239);
            btExaminMod.Name = "btExaminMod";
            btExaminMod.Size = new Size(75, 23);
            btExaminMod.TabIndex = 12;
            btExaminMod.Text = "Examinar";
            btExaminMod.UseVisualStyleBackColor = true;
            btExaminMod.Click += btExaminMod_Click;
            // 
            // FormMateriales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 421);
            Controls.Add(tabControl1);
            Name = "FormMateriales";
            Text = "FormMateriales";
            Load += FormMaterials_Load;
            tabControl1.ResumeLayout(false);
            ListaMateriales.ResumeLayout(false);
            ListaMateriales.PerformLayout();
            AddMaterial.ResumeLayout(false);
            AddMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            EditMaterial.ResumeLayout(false);
            EditMaterial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picImagenModify).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage ListaMateriales;
        private TabPage AddMaterial;
        private TabPage EditMaterial;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private Button AddProduct;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private Button btExaminar;
        private Button btCancel;
        private Button btSave;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private TextBox txtStock;
        private TextBox txtNameInsert;
        private Label label5;
        private Label lblStock;
        private ComboBox opcionBox;
        private Label labelResultado;
        private ComboBox boxMedidaActual;
        private TextBox txtStockActual;
        private TextBox txtNameActual;
        private FontAwesome.Sharp.IconPictureBox picImagenModify;
        private Button btCancelMod;
        private Button btSaveMod;
        private Button btAddImagenModify;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label4;
        private Button btExaminMod;
    }
}
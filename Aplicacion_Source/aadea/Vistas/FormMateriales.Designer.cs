﻿namespace aadea.Vistas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            ListaMateriales = new TabPage();
            btDelete = new Button();
            EdtiProduct = new Button();
            AddProduct = new Button();
            lbImagen = new Label();
            pictureBox1 = new PictureBox();
            btsearch = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            DGV_materiales = new DataGridView();
            AddMaterial = new TabPage();
            EditMaterial = new TabPage();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl1.SuspendLayout();
            ListaMateriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGV_materiales).BeginInit();
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
            ListaMateriales.Controls.Add(btDelete);
            ListaMateriales.Controls.Add(EdtiProduct);
            ListaMateriales.Controls.Add(AddProduct);
            ListaMateriales.Controls.Add(lbImagen);
            ListaMateriales.Controls.Add(pictureBox1);
            ListaMateriales.Controls.Add(btsearch);
            ListaMateriales.Controls.Add(label1);
            ListaMateriales.Controls.Add(textBox1);
            ListaMateriales.Controls.Add(DGV_materiales);
            ListaMateriales.Location = new Point(4, 24);
            ListaMateriales.Name = "ListaMateriales";
            ListaMateriales.Padding = new Padding(3);
            ListaMateriales.Size = new Size(683, 393);
            ListaMateriales.TabIndex = 0;
            ListaMateriales.Text = "Materiales";
            ListaMateriales.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            btDelete.ForeColor = Color.Black;
            btDelete.Location = new Point(548, 339);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(121, 23);
            btDelete.TabIndex = 15;
            btDelete.Text = "Eliminar";
            btDelete.UseVisualStyleBackColor = true;
            // 
            // EdtiProduct
            // 
            EdtiProduct.ForeColor = Color.Black;
            EdtiProduct.Location = new Point(548, 310);
            EdtiProduct.Name = "EdtiProduct";
            EdtiProduct.Size = new Size(121, 23);
            EdtiProduct.TabIndex = 14;
            EdtiProduct.Text = "Editar";
            EdtiProduct.UseVisualStyleBackColor = true;
            // 
            // AddProduct
            // 
            AddProduct.ForeColor = Color.Black;
            AddProduct.Location = new Point(548, 281);
            AddProduct.Name = "AddProduct";
            AddProduct.Size = new Size(121, 23);
            AddProduct.TabIndex = 13;
            AddProduct.Text = "Agregar";
            AddProduct.UseVisualStyleBackColor = true;
            // 
            // lbImagen
            // 
            lbImagen.AutoSize = true;
            lbImagen.Location = new Point(588, 117);
            lbImagen.Name = "lbImagen";
            lbImagen.Size = new Size(47, 15);
            lbImagen.TabIndex = 12;
            lbImagen.Text = "Imagen";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(548, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 119);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btsearch
            // 
            btsearch.ForeColor = Color.Black;
            btsearch.Location = new Point(562, 39);
            btsearch.Name = "btsearch";
            btsearch.Size = new Size(107, 23);
            btsearch.TabIndex = 4;
            btsearch.Text = "Search";
            btsearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 12);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 10;
            label1.Text = "Materiales";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(516, 23);
            textBox1.TabIndex = 1;
            // 
            // DGV_materiales
            // 
            DGV_materiales.AllowUserToResizeColumns = false;
            DGV_materiales.AllowUserToResizeRows = false;
            DGV_materiales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_materiales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_materiales.BackgroundColor = Color.White;
            DGV_materiales.BorderStyle = BorderStyle.None;
            DGV_materiales.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DGV_materiales.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGV_materiales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGV_materiales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DGV_materiales.EnableHeadersVisualStyles = false;
            DGV_materiales.GridColor = Color.DarkBlue;
            DGV_materiales.Location = new Point(17, 80);
            DGV_materiales.Name = "DGV_materiales";
            DGV_materiales.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGV_materiales.RowHeadersVisible = false;
            DGV_materiales.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = Color.Plum;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            DGV_materiales.RowsDefaultCellStyle = dataGridViewCellStyle2;
            DGV_materiales.RowTemplate.Height = 25;
            DGV_materiales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_materiales.Size = new Size(516, 289);
            DGV_materiales.TabIndex = 9;
            // 
            // AddMaterial
            // 
            AddMaterial.Location = new Point(4, 24);
            AddMaterial.Name = "AddMaterial";
            AddMaterial.Padding = new Padding(3);
            AddMaterial.Size = new Size(683, 393);
            AddMaterial.TabIndex = 1;
            AddMaterial.Text = "Agregar Material";
            AddMaterial.UseVisualStyleBackColor = true;
            // 
            // EditMaterial
            // 
            EditMaterial.Location = new Point(4, 24);
            EditMaterial.Name = "EditMaterial";
            EditMaterial.Size = new Size(683, 393);
            EditMaterial.TabIndex = 2;
            EditMaterial.Text = "Modificar Material";
            EditMaterial.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGV_materiales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage ListaMateriales;
        private TabPage AddMaterial;
        private TabPage EditMaterial;
        private DataGridView DGV_materiales;
        private TextBox textBox1;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private Button btsearch;
        private PictureBox pictureBox1;
        private Label lbImagen;
        private Button btDelete;
        private Button EdtiProduct;
        private Button AddProduct;
    }
}
namespace aadea.userControls
{
    partial class productBodega
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridViewInv = new DataGridView();
            nameProduct = new Label();
            pictureBox1 = new PictureBox();
            eliminarBodega = new FontAwesome.Sharp.IconButton();
            modificarBodega = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewInv
            // 
            dataGridViewInv.AllowUserToAddRows = false;
            dataGridViewInv.AllowUserToResizeColumns = false;
            dataGridViewInv.AllowUserToResizeRows = false;
            dataGridViewInv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewInv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInv.BackgroundColor = Color.FromArgb(115, 124, 141);
            dataGridViewInv.BorderStyle = BorderStyle.None;
            dataGridViewInv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewInv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(38, 43, 58);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(38, 43, 58);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewInv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewInv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewInv.EnableHeadersVisualStyles = false;
            dataGridViewInv.GridColor = Color.FromArgb(155, 164, 181);
            dataGridViewInv.Location = new Point(199, 43);
            dataGridViewInv.Name = "dataGridViewInv";
            dataGridViewInv.ReadOnly = true;
            dataGridViewInv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewInv.RowHeadersVisible = false;
            dataGridViewInv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(155, 164, 181);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(57, 72, 103);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewInv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewInv.RowTemplate.Height = 25;
            dataGridViewInv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewInv.Size = new Size(332, 124);
            dataGridViewInv.TabIndex = 0;
            // 
            // nameProduct
            // 
            nameProduct.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            nameProduct.Location = new Point(0, 12);
            nameProduct.Name = "nameProduct";
            nameProduct.Size = new Size(676, 31);
            nameProduct.TabIndex = 1;
            nameProduct.Text = "Nombre del producto";
            nameProduct.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(34, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // eliminarBodega
            // 
            eliminarBodega.BackColor = Color.FromArgb(204, 102, 102);
            eliminarBodega.Cursor = Cursors.Hand;
            eliminarBodega.FlatAppearance.BorderColor = Color.FromArgb(154, 52, 52);
            eliminarBodega.FlatAppearance.BorderSize = 2;
            eliminarBodega.FlatAppearance.MouseDownBackColor = Color.FromArgb(154, 52, 52);
            eliminarBodega.FlatAppearance.MouseOverBackColor = Color.FromArgb(164, 62, 62);
            eliminarBodega.FlatStyle = FlatStyle.Flat;
            eliminarBodega.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            eliminarBodega.ForeColor = SystemColors.Control;
            eliminarBodega.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            eliminarBodega.IconColor = SystemColors.Control;
            eliminarBodega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            eliminarBodega.IconSize = 28;
            eliminarBodega.Location = new Point(546, 97);
            eliminarBodega.Name = "eliminarBodega";
            eliminarBodega.Size = new Size(118, 33);
            eliminarBodega.TabIndex = 8;
            eliminarBodega.Text = "Eliminar";
            eliminarBodega.TextImageRelation = TextImageRelation.ImageBeforeText;
            eliminarBodega.UseVisualStyleBackColor = false;
            eliminarBodega.Click += eliminarBodega_Click;
            // 
            // modificarBodega
            // 
            modificarBodega.BackColor = Color.FromArgb(121, 160, 191);
            modificarBodega.Cursor = Cursors.Hand;
            modificarBodega.FlatAppearance.BorderColor = Color.FromArgb(81, 120, 151);
            modificarBodega.FlatAppearance.BorderSize = 2;
            modificarBodega.FlatAppearance.MouseDownBackColor = Color.FromArgb(81, 120, 151);
            modificarBodega.FlatAppearance.MouseOverBackColor = Color.FromArgb(101, 140, 171);
            modificarBodega.FlatStyle = FlatStyle.Flat;
            modificarBodega.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            modificarBodega.ForeColor = SystemColors.Control;
            modificarBodega.IconChar = FontAwesome.Sharp.IconChar.PaintBrush;
            modificarBodega.IconColor = SystemColors.Control;
            modificarBodega.IconFont = FontAwesome.Sharp.IconFont.Auto;
            modificarBodega.IconSize = 28;
            modificarBodega.Location = new Point(546, 58);
            modificarBodega.Name = "modificarBodega";
            modificarBodega.Size = new Size(118, 33);
            modificarBodega.TabIndex = 7;
            modificarBodega.Text = "Modificar";
            modificarBodega.TextImageRelation = TextImageRelation.ImageBeforeText;
            modificarBodega.UseVisualStyleBackColor = false;
            modificarBodega.Click += modificarBodega_Click;
            // 
            // productBodega
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(155, 164, 181);
            Controls.Add(nameProduct);
            Controls.Add(pictureBox1);
            Controls.Add(eliminarBodega);
            Controls.Add(modificarBodega);
            Controls.Add(dataGridViewInv);
            Name = "productBodega";
            Size = new Size(676, 188);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridViewInv;
        private Label nameProduct;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton eliminarBodega;
        private FontAwesome.Sharp.IconButton modificarBodega;
    }
}

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
            tabControl1 = new TabControl();
            tabView = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            Editar = new TabPage();
            tabDelete = new TabPage();
            tabControl1.SuspendLayout();
            tabView.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabView);
            tabControl1.Controls.Add(Editar);
            tabControl1.Controls.Add(tabDelete);
            tabControl1.Dock = DockStyle.Top;
            tabControl1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(817, 478);
            tabControl1.TabIndex = 0;
            // 
            // tabView
            // 
            tabView.Controls.Add(flowLayoutPanel1);
            tabView.Controls.Add(panel1);
            tabView.ForeColor = Color.Black;
            tabView.Location = new Point(4, 26);
            tabView.Name = "tabView";
            tabView.Padding = new Padding(3);
            tabView.Size = new Size(809, 448);
            tabView.TabIndex = 0;
            tabView.Text = "Stock";
            tabView.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.ForeColor = Color.Black;
            flowLayoutPanel1.Location = new Point(8, 9);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(793, 429);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 0);
            panel1.TabIndex = 0;
            // 
            // Editar
            // 
            Editar.Location = new Point(4, 24);
            Editar.Name = "Editar";
            Editar.Padding = new Padding(3);
            Editar.Size = new Size(809, 450);
            Editar.TabIndex = 1;
            Editar.Text = "tabEdit";
            Editar.UseVisualStyleBackColor = true;
            // 
            // tabDelete
            // 
            tabDelete.Location = new Point(4, 24);
            tabDelete.Name = "tabDelete";
            tabDelete.Padding = new Padding(3);
            tabDelete.Size = new Size(809, 450);
            tabDelete.TabIndex = 2;
            tabDelete.Text = "Eliminar";
            tabDelete.UseVisualStyleBackColor = true;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 474);
            Controls.Add(tabControl1);
            Name = "FormInventario";
            Text = "FormInventario";
            tabControl1.ResumeLayout(false);
            tabView.ResumeLayout(false);
            tabView.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabView;
        private TabPage Editar;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TabPage tabDelete;
    }
}
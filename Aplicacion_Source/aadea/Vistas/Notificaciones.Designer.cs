namespace aadea.Vistas
{
    partial class Notificaciones
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
            pToo = new Panel();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // pToo
            // 
            pToo.Dock = DockStyle.Left;
            pToo.Location = new Point(0, 0);
            pToo.Name = "pToo";
            pToo.Size = new Size(10, 57);
            pToo.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 9);
            label1.Name = "label1";
            label1.Size = new Size(330, 42);
            label1.TabIndex = 4;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Notificaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(358, 57);
            Controls.Add(label1);
            Controls.Add(pToo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Notificaciones";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Notificaciones";
            FormClosing += Notificaciones_FormClosing;
            Load += Notificaciones_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel pToo;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
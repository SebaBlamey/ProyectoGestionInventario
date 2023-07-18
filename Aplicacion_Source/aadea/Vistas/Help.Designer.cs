namespace aadea.Vistas
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            textBoxAyuda = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(137, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 53);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBoxAyuda);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 473);
            panel1.TabIndex = 2;
            // 
            // textBoxAyuda
            // 
            textBoxAyuda.BackColor = Color.FromArgb(224, 224, 224);
            textBoxAyuda.BorderStyle = BorderStyle.None;
            textBoxAyuda.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxAyuda.Location = new Point(0, 62);
            textBoxAyuda.Multiline = true;
            textBoxAyuda.Name = "textBoxAyuda";
            textBoxAyuda.ReadOnly = true;
            textBoxAyuda.ScrollBars = ScrollBars.Vertical;
            textBoxAyuda.Size = new Size(321, 408);
            textBoxAyuda.TabIndex = 2;
            textBoxAyuda.TextAlign = HorizontalAlignment.Center;
            // 
            // Help
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 473);
            Controls.Add(panel1);
            Name = "Help";
            Text = "Help";
            Load += HelpForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void Help_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private TextBox textBoxAyuda;
    }
}
namespace aadea.Vistas
{
    partial class PINmod
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
            pictureBox1 = new PictureBox();
            PIN_box = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resource.logo3;
            pictureBox1.Location = new Point(0, -12);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(324, 226);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // PIN_box
            // 
            PIN_box.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            PIN_box.ForeColor = SystemColors.WindowFrame;
            PIN_box.HideSelection = false;
            PIN_box.Location = new Point(52, 276);
            PIN_box.MaxLength = 8;
            PIN_box.Name = "PIN_box";
            PIN_box.Size = new Size(222, 24);
            PIN_box.TabIndex = 8;
            PIN_box.Text = "IDENTIFICADOR";
            PIN_box.TextAlign = HorizontalAlignment.Center;
            PIN_box.Click += textBox1_MouseClick;
            PIN_box.TextChanged += PIN_box_TextChanged;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 25;
            iconButton1.Location = new Point(284, -3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(40, 38);
            iconButton1.TabIndex = 9;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resource.nube;
            pictureBox2.Location = new Point(10, 148);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(600, 600);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(138, 106, 61);
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(52, 192);
            label1.Name = "label1";
            label1.Size = new Size(222, 67);
            label1.TabIndex = 11;
            label1.Text = "Para reestablecer el Codigo PIN, debe ingresar el \"Identificador\" que viene ingresado en la documentacion del programa";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.Location = new Point(0, -3);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(40, 38);
            iconButton2.TabIndex = 12;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // PINmod
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(324, 407);
            Controls.Add(iconButton2);
            Controls.Add(label1);
            Controls.Add(iconButton1);
            Controls.Add(PIN_box);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PINmod";
            Text = "PINmod";
            Load += PINmod_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox PIN_box;
        private FontAwesome.Sharp.IconButton iconButton1;
        private PictureBox pictureBox2;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}









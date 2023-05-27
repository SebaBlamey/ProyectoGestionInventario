namespace aadea
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            loginButton = new Button();
            VerContrasena = new CheckBox();
            PIN_box = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(138, 106, 61);
            loginButton.FlatAppearance.BorderColor = Color.White;
            loginButton.FlatAppearance.BorderSize = 2;
            loginButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(85, 59, 16);
            loginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 59, 16);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = SystemColors.Control;
            loginButton.Location = new Point(120, 231);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(85, 31);
            loginButton.TabIndex = 2;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += button1_Click;
            // 
            // VerContrasena
            // 
            VerContrasena.AutoSize = true;
            VerContrasena.CheckAlign = ContentAlignment.MiddleRight;
            VerContrasena.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 119, 133);
            VerContrasena.FlatStyle = FlatStyle.Flat;
            VerContrasena.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            VerContrasena.ForeColor = SystemColors.InfoText;
            VerContrasena.Location = new Point(206, 213);
            VerContrasena.Name = "VerContrasena";
            VerContrasena.Size = new Size(68, 18);
            VerContrasena.TabIndex = 3;
            VerContrasena.Text = "Ver PIN";
            VerContrasena.TextAlign = ContentAlignment.MiddleRight;
            VerContrasena.UseVisualStyleBackColor = true;
            VerContrasena.CheckedChanged += VerContrasena_CheckedChanged;
            // 
            // PIN_box
            // 
            PIN_box.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            PIN_box.ForeColor = SystemColors.WindowFrame;
            PIN_box.HideSelection = false;
            PIN_box.Location = new Point(52, 190);
            PIN_box.MaxLength = 8;
            PIN_box.Name = "PIN_box";
            PIN_box.Size = new Size(222, 24);
            PIN_box.TabIndex = 4;
            PIN_box.Text = "Ingrese PIN";
            PIN_box.TextAlign = HorizontalAlignment.Center;
            PIN_box.Click += PIN_box_Click;
            PIN_box.MouseClick += PIN_box_MouseClick;
            PIN_box.TextChanged += PIN_box_TextChanged;
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
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resource.nube;
            pictureBox2.Location = new Point(10, 148);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(600, 600);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.Location = new Point(0, -1);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(40, 38);
            iconButton1.TabIndex = 7;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(324, 407);
            Controls.Add(iconButton1);
            Controls.Add(PIN_box);
            Controls.Add(VerContrasena);
            Controls.Add(loginButton);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delicias de el Tebal";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button loginButton;
        private CheckBox VerContrasena;
        private TextBox PIN_box;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
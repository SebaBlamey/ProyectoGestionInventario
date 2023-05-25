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
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(42, 58, 81);
            loginButton.FlatAppearance.BorderColor = Color.FromArgb(255, 119, 133);
            loginButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 119, 133);
            loginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 119, 133);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Ubuntu", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.ForeColor = SystemColors.Control;
            loginButton.Location = new Point(120, 244);
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
            VerContrasena.Checked = true;
            VerContrasena.CheckState = CheckState.Checked;
            VerContrasena.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 119, 133);
            VerContrasena.FlatStyle = FlatStyle.Flat;
            VerContrasena.Font = new Font("Ubuntu", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            VerContrasena.ForeColor = SystemColors.Window;
            VerContrasena.Location = new Point(82, 219);
            VerContrasena.Name = "VerContrasena";
            VerContrasena.Size = new Size(63, 20);
            VerContrasena.TabIndex = 3;
            VerContrasena.Text = "Ver PIN";
            VerContrasena.UseVisualStyleBackColor = true;
            VerContrasena.CheckedChanged += VerContrasena_CheckedChanged;
            // 
            // PIN_box
            // 
            PIN_box.Font = new Font("Ubuntu", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            PIN_box.ForeColor = SystemColors.WindowFrame;
            PIN_box.HideSelection = false;
            PIN_box.Location = new Point(79, 190);
            PIN_box.MaxLength = 8;
            PIN_box.Name = "PIN_box";
            PIN_box.Size = new Size(166, 21);
            PIN_box.TabIndex = 4;
            PIN_box.Text = "Ingresa PIN";
            PIN_box.TextAlign = HorizontalAlignment.Center;
            PIN_box.UseSystemPasswordChar = true;
            PIN_box.Click += PIN_box_Click;
            PIN_box.MouseClick += PIN_box_MouseClick;
            PIN_box.TextChanged += PIN_box_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 58, 81);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(324, 407);
            Controls.Add(PIN_box);
            Controls.Add(VerContrasena);
            Controls.Add(loginButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delicias de el Tebal";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button loginButton;
        private CheckBox VerContrasena;
        private TextBox PIN_box;
    }
}
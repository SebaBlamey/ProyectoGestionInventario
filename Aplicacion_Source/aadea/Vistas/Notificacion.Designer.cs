namespace aadea.Vistas
{
    partial class Notificacion
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
            ErrorP = new FontAwesome.Sharp.IconPictureBox();
            WarningLabel = new Label();
            Warning = new FontAwesome.Sharp.IconPictureBox();
            successful = new FontAwesome.Sharp.IconPictureBox();
            SuccessfulLabel = new Label();
            ErrorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)ErrorP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Warning).BeginInit();
            ((System.ComponentModel.ISupportInitialize)successful).BeginInit();
            SuspendLayout();
            // 
            // ErrorP
            // 
            ErrorP.BackColor = SystemColors.Control;
            ErrorP.ForeColor = SystemColors.ControlText;
            ErrorP.IconChar = FontAwesome.Sharp.IconChar.Ghost;
            ErrorP.IconColor = SystemColors.ControlText;
            ErrorP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ErrorP.IconSize = 38;
            ErrorP.Location = new Point(12, 29);
            ErrorP.Name = "ErrorP";
            ErrorP.Size = new Size(38, 41);
            ErrorP.TabIndex = 0;
            ErrorP.TabStop = false;
            // 
            // WarningLabel
            // 
            WarningLabel.Location = new Point(56, 29);
            WarningLabel.Name = "WarningLabel";
            WarningLabel.Size = new Size(180, 61);
            WarningLabel.TabIndex = 1;
            WarningLabel.Text = "Precaucion, La accion que va a realizar a continuacion no se puede revertir";
            // 
            // Warning
            // 
            Warning.BackColor = SystemColors.Control;
            Warning.ForeColor = SystemColors.ControlText;
            Warning.IconChar = FontAwesome.Sharp.IconChar.Gift;
            Warning.IconColor = SystemColors.ControlText;
            Warning.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Warning.IconSize = 38;
            Warning.Location = new Point(12, 29);
            Warning.Name = "Warning";
            Warning.Size = new Size(38, 41);
            Warning.TabIndex = 2;
            Warning.TabStop = false;
            // 
            // successful
            // 
            successful.BackColor = SystemColors.Control;
            successful.ForeColor = SystemColors.ControlText;
            successful.IconChar = FontAwesome.Sharp.IconChar.Warning;
            successful.IconColor = SystemColors.ControlText;
            successful.IconFont = FontAwesome.Sharp.IconFont.Auto;
            successful.IconSize = 38;
            successful.Location = new Point(12, 29);
            successful.Name = "successful";
            successful.Size = new Size(38, 41);
            successful.TabIndex = 3;
            successful.TabStop = false;
            // 
            // SuccessfulLabel
            // 
            SuccessfulLabel.Location = new Point(56, 29);
            SuccessfulLabel.Name = "SuccessfulLabel";
            SuccessfulLabel.Size = new Size(180, 61);
            SuccessfulLabel.TabIndex = 4;
            SuccessfulLabel.Text = "Operacion realizada con exito.";
            // 
            // ErrorLabel
            // 
            ErrorLabel.Location = new Point(56, 29);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(180, 61);
            ErrorLabel.TabIndex = 5;
            ErrorLabel.Text = "Error, No se pudo completar la accion, Verifique la informacion antes de continuar";
            // 
            // Notificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 93);
            Controls.Add(ErrorLabel);
            Controls.Add(SuccessfulLabel);
            Controls.Add(successful);
            Controls.Add(Warning);
            Controls.Add(WarningLabel);
            Controls.Add(ErrorP);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Notificacion";
            Text = "Notificacion";
            ((System.ComponentModel.ISupportInitialize)ErrorP).EndInit();
            ((System.ComponentModel.ISupportInitialize)Warning).EndInit();
            ((System.ComponentModel.ISupportInitialize)successful).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox ErrorP;
        private Label WarningLabel;
        private FontAwesome.Sharp.IconPictureBox Warning;
        private FontAwesome.Sharp.IconPictureBox successful;
        private Label SuccessfulLabel;
        private Label ErrorLabel;
    }
}
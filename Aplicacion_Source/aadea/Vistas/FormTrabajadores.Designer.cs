﻿namespace aadea.Vistas
{
    partial class FormTrabajadores
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
            DGV_T = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV_T).BeginInit();
            SuspendLayout();
            // 
            // DGV_T
            // 
            DGV_T.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_T.Location = new Point(12, 12);
            DGV_T.Name = "DGV_T";
            DGV_T.Size = new Size(682, 358);
            DGV_T.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Location = new Point(73, 396);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Location = new Point(300, 391);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(482, 396);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // FormTrabajadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(DGV_T);
            Name = "FormTrabajadores";
            Text = "FormTrabajadores";
            Load += FormTrabajadores_Load;
            ((System.ComponentModel.ISupportInitialize)DGV_T).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGV_T;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
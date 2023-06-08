namespace aadea.Vistas
{
    partial class FormProduccion
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
            HistoryBtn = new Model.BT();
            ActuallyProdBtn = new Model.BT();
            AddProdBtn = new Model.BT();
            SuspendLayout();
            // 
            // HistoryBtn
            // 
            HistoryBtn.BackColor = Color.Silver;
            HistoryBtn.BackgroundColor = Color.Silver;
            HistoryBtn.BorderColor = Color.PaleVioletRed;
            HistoryBtn.BorderRadius = 20;
            HistoryBtn.BorderSize = 0;
            HistoryBtn.FlatAppearance.BorderSize = 0;
            HistoryBtn.FlatAppearance.MouseOverBackColor = Color.DarkBlue;
            HistoryBtn.FlatStyle = FlatStyle.Flat;
            HistoryBtn.Font = new Font("Tahoma", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            HistoryBtn.ForeColor = Color.White;
            HistoryBtn.Location = new Point(245, 78);
            HistoryBtn.Name = "HistoryBtn";
            HistoryBtn.Size = new Size(261, 60);
            HistoryBtn.TabIndex = 0;
            HistoryBtn.Text = "Historial de produccion";
            HistoryBtn.TextColor = Color.White;
            HistoryBtn.UseVisualStyleBackColor = false;
            // 
            // ActuallyProdBtn
            // 
            ActuallyProdBtn.BackColor = Color.Silver;
            ActuallyProdBtn.BackgroundColor = Color.Silver;
            ActuallyProdBtn.BorderColor = Color.PaleVioletRed;
            ActuallyProdBtn.BorderRadius = 20;
            ActuallyProdBtn.BorderSize = 0;
            ActuallyProdBtn.FlatAppearance.BorderSize = 0;
            ActuallyProdBtn.FlatAppearance.MouseOverBackColor = Color.DarkBlue;
            ActuallyProdBtn.FlatStyle = FlatStyle.Flat;
            ActuallyProdBtn.Font = new Font("Tahoma", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ActuallyProdBtn.ForeColor = Color.White;
            ActuallyProdBtn.Location = new Point(245, 186);
            ActuallyProdBtn.Name = "ActuallyProdBtn";
            ActuallyProdBtn.Size = new Size(261, 60);
            ActuallyProdBtn.TabIndex = 1;
            ActuallyProdBtn.Text = "Ver Produccion Actual";
            ActuallyProdBtn.TextColor = Color.White;
            ActuallyProdBtn.UseVisualStyleBackColor = false;
            // 
            // AddProdBtn
            // 
            AddProdBtn.BackColor = Color.Silver;
            AddProdBtn.BackgroundColor = Color.Silver;
            AddProdBtn.BorderColor = Color.PaleVioletRed;
            AddProdBtn.BorderRadius = 20;
            AddProdBtn.BorderSize = 0;
            AddProdBtn.FlatAppearance.BorderSize = 0;
            AddProdBtn.FlatAppearance.MouseOverBackColor = Color.DarkBlue;
            AddProdBtn.FlatStyle = FlatStyle.Flat;
            AddProdBtn.Font = new Font("Tahoma", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            AddProdBtn.ForeColor = Color.White;
            AddProdBtn.Location = new Point(245, 297);
            AddProdBtn.Name = "AddProdBtn";
            AddProdBtn.Size = new Size(261, 60);
            AddProdBtn.TabIndex = 2;
            AddProdBtn.Text = "Ingresar Produccion";
            AddProdBtn.TextColor = Color.White;
            AddProdBtn.UseVisualStyleBackColor = false;
            // 
            // FormProduccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddProdBtn);
            Controls.Add(ActuallyProdBtn);
            Controls.Add(HistoryBtn);
            Name = "FormProduccion";
            Text = "FormProduccion";
            ResumeLayout(false);
        }

        #endregion

        private Model.BT HistoryBtn;
        private Model.BT ActuallyProdBtn;
        private Model.BT AddProdBtn;
    }
}
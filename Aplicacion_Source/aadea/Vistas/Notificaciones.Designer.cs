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
            components=new System.ComponentModel.Container();
            pToo=new Panel();
            pcSucc=new PictureBox();
            pcInfo=new PictureBox();
            pictureBox3=new PictureBox();
            label1=new Label();
            timer1=new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pcSucc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pToo
            // 
            pToo.Dock=DockStyle.Top;
            pToo.Location=new Point(0, 0);
            pToo.Name="pToo";
            pToo.Size=new Size(260, 5);
            pToo.TabIndex=0;
            // 
            // pcSucc
            // 
            pcSucc.Image=Properties.Resource.succes;
            pcSucc.Location=new Point(10, 10);
            pcSucc.Name="pcSucc";
            pcSucc.Size=new Size(70, 70);
            pcSucc.SizeMode=PictureBoxSizeMode.Zoom;
            pcSucc.TabIndex=1;
            pcSucc.TabStop=false;
            // 
            // pcInfo
            // 
            pcInfo.Image=Properties.Resource.info1;
            pcInfo.Location=new Point(10, 10);
            pcInfo.Name="pcInfo";
            pcInfo.Size=new Size(70, 70);
            pcInfo.SizeMode=PictureBoxSizeMode.Zoom;
            pcInfo.TabIndex=2;
            pcInfo.TabStop=false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image=Properties.Resource.delete;
            pictureBox3.Location=new Point(10, 10);
            pictureBox3.Name="pictureBox3";
            pictureBox3.Size=new Size(70, 70);
            pictureBox3.SizeMode=PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex=3;
            pictureBox3.TabStop=false;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(86, 35);
            label1.Name="label1";
            label1.Size=new Size(38, 15);
            label1.TabIndex=4;
            label1.Text="label1";
            // 
            // timer1
            // 
            timer1.Tick+=timer1_Tick;
            // 
            // Notificaciones
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(260, 92);
            Controls.Add(label1);
            Controls.Add(pcInfo);
            Controls.Add(pcSucc);
            Controls.Add(pToo);
            Controls.Add(pictureBox3);
            FormBorderStyle=FormBorderStyle.None;
            Name="Notificaciones";
            StartPosition=FormStartPosition.CenterParent;
            Text="Notificaciones";
            FormClosing+=Notificaciones_FormClosing;
            Load+=Notificaciones_Load;
            ((System.ComponentModel.ISupportInitialize)pcSucc).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pToo;
        private PictureBox pcSucc;
        private PictureBox pcInfo;
        private PictureBox pictureBox3;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}
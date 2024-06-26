﻿namespace aadea.userControls
{
    public partial class UserMaterial : UserControl
    {
        public UserMaterial()
        {
            InitializeComponent();
        }

        public event EventHandler buttonModifyClick;
        public event EventHandler buttonDeleteClick;
        #region propierties

        public string nombretit
        {
            get { return nametxt.Text; }
            set { nametxt.Text = value; }
        }

        public int ID { get; set; }
        public string Cantidad
        {
            get { return lblCantidada.Text; }
            set
            {
                float cantidad;
                if (float.TryParse(value, out cantidad))
                {
                    lblCantidada.Text = cantidad.ToString("0.##"); // Formato de cadena para mostrar el número con parte decimal
                }
                else
                {
                    lblCantidada.Text = value;
                }
            }
        }

        public string Unidad
        {
            get { return lblUnidad.Text; }
            set { lblUnidad.Text = value; }
        }

        public Image MaterialImage
        {
            get { return iconPictureBox1.Image; }
            set { iconPictureBox1.Image = value; }
        }

        #endregion

        private void modify_iconButton_Click(object sender, EventArgs e)
        {
            buttonModifyClick?.Invoke(this, EventArgs.Empty);
        }

        private void delete_iconButton_Click(object sender, EventArgs e)
        {
            buttonDeleteClick?.Invoke(this, EventArgs.Empty);
        }

        private void lblCantidada_Click(object sender, EventArgs e)
        {

        }
    }
}

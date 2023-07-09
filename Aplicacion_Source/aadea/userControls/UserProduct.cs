using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aadea.userControls;

public partial class UserProduct : UserControl
{
    public UserProduct()
    {
        InitializeComponent();
    }
    public event EventHandler? btModifyProducto;
    public event EventHandler? btDeleteProducto;

    #region Propiertes

    public int ID { get; set; }
    public string Tittle
    {
        get { return lblTittle.Text; }
        set { lblTittle.Text = value; }
    }

    public string Desc
    {
        get { return lblDescripcion.Text; }
        set { lblDescripcion.Text = value; }
    }

    public Image PictureBox1
    {
        get { return picProducto.Image; }
        set { picProducto.Image = value; }
    }

    #endregion

    private void iconButton1_Click(object sender, EventArgs e)
    {
        btModifyProducto?.Invoke(this, EventArgs.Empty);
    }

    private void iconButton_Click(object sender, EventArgs e)
    {
        btDeleteProducto?.Invoke(this, EventArgs.Empty);
    }
}
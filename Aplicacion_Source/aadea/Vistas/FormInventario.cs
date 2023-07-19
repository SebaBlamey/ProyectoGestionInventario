
using aadea.Extras;
using aadea.Logicaq;
using aadea.userControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using aadea.Properties;

namespace aadea.Vistas
{
    public partial class FormInventario : Form
    {
        private int idLocal;

        public FormInventario()
        {
            InitializeComponent();

            tabControl1.TabPages.Remove(addProdTab);
            tabControl1.TabPages.Remove(tabSizes);
            tabControl1.TabPages.Remove(ModStock);
        }
        private void FormProduccion_Load(object? sender, EventArgs e)
        {
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.Multiline = true;
            flowLayoutPanel1.Controls.Clear();
            L_inventario l_Inventario = new L_inventario();
            DataTable dataTable = l_Inventario.listProducts();
            foreach (DataRow row in dataTable.Rows)
            {
                productBodega userControl = new productBodega();

                int id = Convert.ToInt32(row["ID"]);
                string nombre = row["nombre"].ToString();
                byte[] imagen = DBNull.Value.Equals(row["imagen"]) ? null : (byte[])row["imagen"];

                userControl.ID = Convert.ToInt32(row["ID"]);
                userControl.Tittle = nombre;

                userControl.buttonDeleteClick += (s, args) =>
                {
                    UserControl_DeleteButtonClicked(userControl, s, args);
                    idLocal = userControl.ID;
                };
                userControl.buttonModifyClick += (s, args) =>
                {
                    UserControl_ButtonModify(userControl);

                };
                if (imagen != null && imagen.Length > 0)
                {

                    using (MemoryStream ms = new MemoryStream(imagen))
                    {
                        System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                        userControl.PictureBox1 = img;
                    }
                }
                else
                {
                    userControl.PictureBox1 = Resource.defaultImage;
                }
                flowLayoutPanel1.Controls.Add(userControl);

                L_bodega l_Bodega = new L_bodega();
                DataTable list = l_Bodega.listInventarioporID(id);
                userControl.DataGridView1.DataSource = list;

            }
            this.refreshDGV();


        }

        private void UserControl_ButtonModify(productBodega user)
        {
            L_inventario l_Inventario = new L_inventario();
            Principal.menuTitleLaberl.Text = "MODIFICAR PRODUCTO DE BODEGA";
            DataTable list = l_Inventario.listStockID(user.ID);
            tabControl1.SelectedTab = ModStock;
            tabControl1.TabPages.Add(ModStock);
            tabControl1.TabPages.Remove(tabView);
            tabControl1.TabPages.Remove(tabSizes);
            tabControl1.TabPages.Remove(addProdTab);
            this.idLocal = user.ID;
            DGV_Stock.DataSource = list;
        }

        private void UserControl_DeleteButtonClicked(productBodega user, object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de realizar esta acción?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string id = Convert.ToString(user.ID);
                L_inventario del = new L_inventario();
                del.delFromInventory(id);
                this.FormProduccion_Load(sender, e);
            }

        }

        private void addProd_Click(object sender, EventArgs e)
        {
        }

        private void addProd_Back_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar la entrada del carácter si no es un número o una tecla de control
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void goToMainInventory()
        {
            Principal.menuTitleLaberl.Text = "BODEGA";
            tabControl1.SelectedTab = tabView;
            tabControl1.TabPages.Add(tabView);
            tabControl1.TabPages.Remove(addProdTab);
            tabControl1.TabPages.Remove(tabSizes);
            tabControl1.TabPages.Remove(ModStock);
        }

        private void addProdTab_Click(object sender, EventArgs e)
        {
            DGV_P_AddT.ClearSelection();
            DGV_Size_AddT.ClearSelection();
        }

        private void sizesBtn_Click(object sender, EventArgs e)
        {
        }

        private void sizesBackBtn_Click(object sender, EventArgs e)
        {
        }

        private void sizesAddBtn_Click(object sender, EventArgs e)
        {
        }

        private void clearSelections()
        {
            textBox1.Clear();
            sizesAddTB.Clear();
            textBox2.Clear();
        }

        private void refreshDGV()
        {
            L_inventario list = new L_inventario();
            DataTable dt1 = list.listSizes();
            DataTable dt2 = list.listAllProducts();
            DGV_Sizes.DataSource = dt1;
            DGV_Size_AddT.DataSource = dt1;
            DGV_P_AddT.DataSource = dt2;
        }

        private void sizesDelBtn_Click(object sender, EventArgs e)
        {
        }

        private void stockBackBtn_Click(object sender, EventArgs e)
        {
        }

        private void incStockBtn_Click(object sender, EventArgs e)
        {
        }

        private void decStockBtn_Click(object sender, EventArgs e)
        {
        }

        private void addProdutcto_Click(object sender, EventArgs e)
        {
            Principal.menuTitleLaberl.Text = "AGREGAR A BODEGA";
            tabControl1.SelectedTab = addProdTab;
            tabControl1.TabPages.Add(addProdTab);
            tabControl1.TabPages.Remove(tabView);
            tabControl1.TabPages.Remove(tabSizes);
            tabControl1.TabPages.Remove(ModStock);
        }

        private void verTamano_Click(object sender, EventArgs e)
        {
            Principal.menuTitleLaberl.Text = "VER TAMAÑO";
            tabControl1.SelectedTab = tabSizes;
            tabControl1.TabPages.Add(tabSizes);
            tabControl1.TabPages.Remove(tabView);
            tabControl1.TabPages.Remove(addProdTab);
            this.refreshDGV();
        }

        private void agregarInv_Click(object sender, EventArgs e)
        {
            if (DGV_P_AddT.SelectedRows.Count == 0 || DGV_Size_AddT.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto y un tamaño antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Ingrese un stock inicial antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string idProd = Convert.ToString(DGV_P_AddT.SelectedRows[0].Cells["ID"].Value);
            string idSize = Convert.ToString(DGV_Size_AddT.SelectedRows[0].Cells["ID"].Value);
            int stock = int.Parse(textBox1.Text);

            L_inventario ins = new L_inventario();
            ins.addToInventory(idProd, idSize, stock);
            goToMainInventory();
            this.clearSelections();
            this.FormProduccion_Load(sender, e);
            MostrarNotificacion("Producto ingresado a bodega", Color.Green, 1);
        }

        private void MostrarNotificacion(string mensaje, Color color, int tipo)
        {
            Notificaciones notificacion = new Notificaciones(mensaje, color, tipo);

            int x = this.Right - notificacion.Width;
            int y = this.Bottom;
            notificacion.StartPosition = FormStartPosition.Manual;
            notificacion.Location = new Point(x, y);

            notificacion.Show(this);
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            goToMainInventory();
        }

        private void backInventario_Click(object sender, EventArgs e)
        {
            this.goToMainInventory();
            this.FormProduccion_Load(sender, e);
        }

        private void agregarInventario_Click(object sender, EventArgs e)
        {
            L_inventario ins = new L_inventario();
            if (string.IsNullOrEmpty(sizesAddTB.Text))
            {
                MessageBox.Show("Ingrese un numero para poder proceder");
                return;
            }
            int size = int.Parse(sizesAddTB.Text);
            ins.addSize(size);
            this.refreshDGV();
            this.clearSelections();
            MostrarNotificacion("Tamaño agregado", Color.Green, 1);
        }

        private void quitarInventario_Click(object sender, EventArgs e)
        {
            if (DGV_Sizes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un tamaño para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("¿Estás seguro de realizar esta acción?", "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(DGV_Sizes.SelectedRows[0].Cells["ID"].Value);
                L_inventario del = new L_inventario();
                del.delSize(id);
                this.refreshDGV();
                MostrarNotificacion("Tamaño eliminado", Color.Red, 3);
            }
        }

        private void volverModStock_Click(object sender, EventArgs e)
        {
            this.goToMainInventory();
            this.FormProduccion_Load(sender, e);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) || DGV_Stock.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un tamaño y llene el stock antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int incStock = Convert.ToInt32(textBox2.Text);
            if (incStock == 0) return;
            int size = Convert.ToInt32(DGV_Stock.SelectedRows[0].Cells["Tamaño"].Value);
            L_inventario inc = new L_inventario();
            inc.incDecStock(this.idLocal, size, incStock);
            this.clearSelections();
            L_inventario list = new L_inventario();
            DataTable dt1 = list.listStockID(this.idLocal);
            DGV_Stock.DataSource = dt1;
            MostrarNotificacion("Stock aumentado", Color.Green, 1);
        }

        private void minu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) || DGV_Stock.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un tamaño y llene el stock antes de continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int decStock = Convert.ToInt32(textBox2.Text);
            if (decStock == 0) return;
            if (decStock > Convert.ToInt32(DGV_Stock.SelectedRows[0].Cells["Stock"].Value))
            {
                MessageBox.Show("No puede eliminar una cantidad mayor a la presentada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int size = Convert.ToInt32(DGV_Stock.SelectedRows[0].Cells["Tamaño"].Value);
            L_inventario dec = new L_inventario();
            dec.incDecStock(this.idLocal, size, -decStock);
            this.clearSelections();
            L_inventario list = new L_inventario();
            DataTable dt1 = list.listStockID(this.idLocal);
            DGV_Stock.DataSource = dt1;
            MostrarNotificacion("Stcok disminuido", Color.Blue, 2);
        }

        private void DGV_P_AddT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

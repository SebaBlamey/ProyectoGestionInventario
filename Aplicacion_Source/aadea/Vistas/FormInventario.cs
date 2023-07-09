
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
        }
        private void FormProduccion_Load(object? sender, EventArgs e)
        {
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
                flowLayoutPanel1.Controls.Add(userControl);
                
                L_bodega l_Bodega = new L_bodega();
                DataTable list = l_Bodega.listInventarioporID(id);
                userControl.DataGridView1.DataSource = list;

            }
            DataTable dataTable1 = l_Inventario.listProductsNotInInventory();
            DGV_P_AddT.DataSource = dataTable1;
            DataTable dataTable2 = l_Inventario.listSizes();
            DGV_Size_AddT.DataSource = dataTable2;


        }

        private void UserControl_ButtonModify(productBodega userControl)
        {
            tabControl1.SelectedTab = addProdTab;
            tabControl1.TabPages.Add(addProdTab);
            tabControl1.TabPages.Remove(tabView);
            tabControl1.TabPages.Remove(tabSizes);
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addProd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = addProdTab;
            tabControl1.TabPages.Add(addProdTab);
            tabControl1.TabPages.Remove(tabView);
            tabControl1.TabPages.Remove(tabSizes);

        }

        private void addProd_Back_Click(object sender, EventArgs e)
        {
            goToMainInventory();


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
            this.FormProduccion_Load(sender, e);


        }

        private void goToMainInventory()
        {
            tabControl1.SelectedTab = tabView;
            tabControl1.TabPages.Add(tabView);
            tabControl1.TabPages.Remove(addProdTab);
            tabControl1.TabPages.Remove(tabSizes);


        }

        private void addProdTab_Click(object sender, EventArgs e)
        {
            DGV_P_AddT.ClearSelection();
            DGV_Size_AddT.ClearSelection();
        }

        private void sizesBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabSizes;
            tabControl1.TabPages.Add(tabSizes);
            tabControl1.TabPages.Remove(tabView);
            tabControl1.TabPages.Remove(addProdTab);
            L_inventario list = new L_inventario();
            DataTable dt = list.listSizes();
            DGV_Sizes.DataSource = dt;
        }

        private void sizesBackBtn_Click(object sender, EventArgs e)
        {
            this.goToMainInventory();
            this.FormProduccion_Load(sender, e);
        }

        private void sizesAddBtn_Click(object sender, EventArgs e)
        {

            L_inventario ins = new L_inventario();
            if (string.IsNullOrEmpty(sizesAddTB.Text))
            {
                MessageBox.Show("Ingrese un numero para poder proceder");
                return;
            }
            int size = int.Parse(sizesAddTB.Text);
            //   ins.addSize(size);
        }
    }
}

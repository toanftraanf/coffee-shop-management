using CoffeeShopManagement.DAO;
using CoffeeShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();

            LoadTable();
            LoadCategory();
        }

        #region Methods
        void LoadCategory()
        {
            List<Category> list = CategoryDAO.Instance.LoadCategoryList();
            cbCategory.DataSource = list;
            cbCategory.DisplayMember = "Name";
        }

        void LoadFoodByCategoryID(int id)
        {
            List<Food> foods = FoodDAO.Instance.getFoodListByCategoryID(id);
            cbFood.DataSource = foods;
            cbFood.DisplayMember = "Name";
        }

        void LoadTable()
        {
            List<Table> list = TableDAO.Instance.LoadTableList();
            foreach (Table table in list)
            {
                if (table != null)
                {
                    Button btn = new Button() { Width = Table.width, Height = Table.height };
                    btn.Text = table.Name + Environment.NewLine + table.Status;
                    btn.Click += Btn_Click;
                    btn.Tag = table;
                    if (table.Status.Equals("Trống"))
                    {
                        btn.BackColor = Color.GreenYellow;
                    }
                    else
                    {
                        btn.BackColor = Color.LightPink;
                    }

                    flpTable.Controls.Add(btn);
                }
            }
        }

        void showBill(int id)
        {
            float totalPrice = 0;
            lsvBill.Items.Clear();
            List<Menu> menus = MenuDAO.Instance.GetListMenuByTableId(id);
            foreach (Menu info in menus)
            {
                ListViewItem item = new ListViewItem(info.FoodName.ToString());
                item.SubItems.Add(info.Count.ToString());
                item.SubItems.Add(info.Price.ToString("n"));
                item.SubItems.Add(info.TotalPrice.ToString("n"));
                lsvBill.Items.Add(item);
                totalPrice += info.TotalPrice;
            }
            CultureInfo cultureInfo = new CultureInfo("vi-VN");
            txbTotalPrice.Text = totalPrice.ToString("c", cultureInfo);
        }

        #endregion

        #region Events
        private void Btn_Click(object? sender, EventArgs e)
        {
            int id = (((Button)sender).Tag as Table).ID;
            Console.WriteLine(id.ToString());
            showBill(id);
        }

        private void logouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = (Category)cb.SelectedItem;
            id = selected.Id;

            LoadFoodByCategoryID(id);
        }
        #endregion


    }
}

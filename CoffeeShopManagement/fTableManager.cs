using CoffeeShopManagement.DAO;
using CoffeeShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        #region Methods
        void LoadTable()
        {
            List<Table> list = TableDAO.Instance.LoadTableList();
            foreach (Table table in list)
            {
                if (table != null)
                {
                    Button btn = new Button() { Width = Table.width, Height = Table.height };
                    btn.Text = table.Name + Environment.NewLine + table.Status;
                    if(table.Status.Equals("Trống"))
                    {
                        btn.BackColor = Color.GreenYellow;
                    } else
                    {
                        btn.BackColor = Color.LightPink;
                    }

                    flpTable.Controls.Add(btn);
                }
            }
        }
        #endregion

        #region Events
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
        #endregion

    }
}

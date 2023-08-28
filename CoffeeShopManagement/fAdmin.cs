using CoffeeShopManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagement
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

            loadAccountList();
        }

        void loadFoodList()
        {
            string query = "select * from Food";
            dtgvFood.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void loadAccountList()
        {
            string query = "EXEC dbo.USP_GetAccountByUserName @userName";
            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { "staff" });
        }
    }
}

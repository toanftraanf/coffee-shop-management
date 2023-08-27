﻿using CoffeeShopManagement.DAO;
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

        void loadAccountList()
        {
            string query = "EXEC dbo.USP_GetAccountByUserName @userName";

            DataProvider provider = new DataProvider();

            dtgvAccount.DataSource = provider.ExecuteQuery(query, new object[] { "staff" });
        }
    }
}

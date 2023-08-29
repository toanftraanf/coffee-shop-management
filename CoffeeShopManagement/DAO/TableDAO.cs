using CoffeeShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance 
        {
            get { if (instance == null) instance = new TableDAO(); return instance; }
            private set => instance = value;
        }

        private TableDAO() { }

        public List<Table> LoadTableList()
        {
            List<Table> list = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
            foreach (DataRow row in data.Rows) 
            {
                list.Add(new Table(row));
            }
            return list;
        }
    }
}

using CoffeeShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance 
        {
            get { if (instance == null) instance = new MenuDAO(); return instance; }
            private set => instance = value; 
        }

        private MenuDAO() { }

        public List<Menu> GetListMenuByTableId(int id)
        {
            List<Menu> list = new List<Menu>();
            string query = "SELECT f.name, bi.count, f.price, f.price*bi.count AS totalPrice " +
                "FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f " +
                "WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows) {
                list.Add(new Menu(row));
            }
            return list;
        }
    }
}

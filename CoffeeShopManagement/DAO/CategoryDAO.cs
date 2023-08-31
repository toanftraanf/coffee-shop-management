﻿using CoffeeShopManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance 
        {
            get { if (instance == null) instance = new CategoryDAO(); return instance; }
            private set => instance = value; 
        }

        private CategoryDAO() { }

        public List<Category> LoadCategoryList()
        {
            List<Category> list = new List<Category>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.FoodCategory");
            foreach (DataRow row in data.Rows)
            {
                list.Add(new Category(row));
            }
            return list;
        }
    }
}

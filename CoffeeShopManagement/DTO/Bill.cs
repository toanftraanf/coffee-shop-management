﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopManagement.DTO
{
    public class Bill
    {
        private int iD;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int status;

        public Bill(int iD, DateTime? dateCheckIn, DateTime? dateCheckOut, int status) 
        {
            this.ID = iD;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = row["dateCheckIn"] == DBNull.Value ? null : (DateTime?)row["dateCheckIn"];
            this.DateCheckOut = row["dateCheckOut"] == DBNull.Value ? null : (DateTime?)row["dateCheckOut"];
            this.Status = (int)row["status"];
        }

        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }
    }
}

﻿

namespace ShopApp.DAL.Models.Orders
{
    public class GetOrders
    {
        public int orderid { get; set; }

        public int? custid { get; set; }

        public int empid { get; set; }

        public DateTime orderdate { get; set; }

        public DateTime requireddate { get; set; }

        public DateTime? shippeddate { get; set; }


    }
}

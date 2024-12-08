
using ShopApp.DAL.Core;

namespace ShopApp.DAL.Entities
{
    public class OrderDetails 
    {
        public int orderid { get; set; }

        public int productid { get; set; }

        public decimal unitprice { get; set; }

        public int qty { get; set; }

        public int discount { get; set; }
    }
}

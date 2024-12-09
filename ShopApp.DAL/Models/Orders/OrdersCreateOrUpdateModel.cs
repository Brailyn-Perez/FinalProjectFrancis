

namespace ShopApp.DAL.Models.Orders
{
    public class OrdersCreateOrUpdateModel
    {
        public int orderid { get; set; }

        public int? custid { get; set; }

        public int empid { get; set; }

        public DateTime orderdate { get; set; }

        public DateTime requireddate { get; set; }

        public DateTime? shippeddate { get; set; }

        public int shippedrid { get; set; }

        public decimal freight { get; set; }

        public string shipaddress { get; set; }

        public string shipcity { get; set; }

        public string? shippostalcode { get; set; }

        public string shipcountry { get; set; }
    }
}


using ShopApp.DAL.Core;

namespace ShopApp.DAL.Entities
{
    public class Products : AuditEntity
    {
        public int productid { get; set; }

        public string productname { get; set; }

        public int supplierdid { get; set; }

        public int categoryid { get; set; }

        public decimal unitprice { get; set; }

        public bool discontinued { get; set; }
    }
}

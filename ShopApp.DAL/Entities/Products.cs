
using ShopApp.DAL.Core;
using System.ComponentModel.DataAnnotations;

namespace ShopApp.DAL.Entities
{
    public class Products : AuditEntity
    {
        [Key]
        public int productid { get; set; }

        public string productname { get; set; }

        public int supplierdid { get; set; }

        public int categoryid { get; set; }

        public decimal unitprice { get; set; }

        public bool discontinued { get; set; }
    }
}

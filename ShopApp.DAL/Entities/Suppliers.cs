
using ShopApp.DAL.Core;
using System.ComponentModel.DataAnnotations;

namespace ShopApp.DAL.Entities
{
    public class Suppliers : ContactEntity
    {
        [Key]
        public int supplierid { get; set; }

        public string companyname { get; set; }
    }
}

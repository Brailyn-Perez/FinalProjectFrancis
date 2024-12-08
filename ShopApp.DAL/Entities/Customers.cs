
using ShopApp.DAL.Core;

namespace ShopApp.DAL.Entities
{
    public class Customers : ContactEntity
    {
        public int custid   { get; set; }

        public string companyname { get; set; }

        public string email { get; set; }

    }
}

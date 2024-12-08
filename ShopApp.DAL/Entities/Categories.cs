

using ShopApp.DAL.Core;

namespace ShopApp.DAL.Entities
{
    public class Categories : AuditEntity
    {
        public int categoryId { get; set; }

        public string categoryName { get; set; }

        public string description { get; set; }


    }
}

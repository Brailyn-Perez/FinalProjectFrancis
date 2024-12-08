
namespace ShopApp.DAL.Models.Categories
{
    public class CategoriesCreateOrUpdateModel
    {
        public int categoryId { get; set; }

        public string categoryName { get; set; }

        public string description { get; set; }

        public DateTime creation_date { get; set; }

        public int creation_user { get; set; }

        public DateTime? modify_date { get; set; }

        public int? modify_user { get; set; }
    }
}

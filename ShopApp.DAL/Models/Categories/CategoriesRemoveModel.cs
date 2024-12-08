

namespace ShopApp.DAL.Models.Categories
{
    public class CategoriesRemoveModel
    {
        public int categoryId { get; set; }

        public int? delete_user { get; set; }

        public DateTime? delete_date { get; set; }

        public bool delete { get; set; }
    }
}

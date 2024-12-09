

namespace ShopApp.DAL.Models.Shippers
{
    public class ShippersRemoveModel
    {
        public int shipperid { get; set; }

        public int? delete_user { get; set; }

        public DateTime? delete_date { get; set; }

        public bool delete { get; set; }
    }
}

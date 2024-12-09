
namespace ShopApp.DAL.Models.Supliers
{
    public class SupliersRemoveModel
    {
        public int supplierid { get; set; }

        public int? delete_user { get; set; }

        public DateTime? delete_date { get; set; }

        public bool delete { get; set; }
    }
}

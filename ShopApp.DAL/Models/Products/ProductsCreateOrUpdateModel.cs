

namespace ShopApp.DAL.Models.Products
{
    public class ProductsCreateOrUpdateModel
    {
        public int productid { get; set; }

        public string productname { get; set; }

        public int supplierdid { get; set; }

        public int categoryid { get; set; }

        public decimal unitprice { get; set; }

        public bool discontinued { get; set; }

        public DateTime creation_date { get; set; }

        public int creation_user { get; set; }

        public DateTime? modify_date { get; set; }

        public int? modify_user { get; set; }
    }
}

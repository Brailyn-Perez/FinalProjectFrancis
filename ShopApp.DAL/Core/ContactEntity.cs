
namespace ShopApp.DAL.Core
{
    public abstract class ContactEntity : LocationEntity
    {
        public string contactname { get; set; }

        public string contacttitle { get; set; }

        public string phone { get; set; }

        public string? fax { get; set; }
    }
}

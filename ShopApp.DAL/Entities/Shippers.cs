
using ShopApp.DAL.Core;

namespace ShopApp.DAL.Entities
{
    public class Shippers: LocationEntity
    {
        public int shipperid { get; set; }

        public string name { get; set; }

        public string phone { get; set; }

    }
}

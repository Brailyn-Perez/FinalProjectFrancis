
using ShopApp.DAL.Models.Shippers;

namespace ShopApp.DAL.Interfaces
{
    public interface IDaoShippers
    {
        void CreateShippers(ShippersCreateOrUpdateModel shippers);

        void UpdateShippers(ShippersCreateOrUpdateModel shippers);

        void RemoveShippers(ShippersRemoveModel shippers);

        List<GetShippers> GetShippers();

        GetShippers GetShippersById(int id);
    }
}

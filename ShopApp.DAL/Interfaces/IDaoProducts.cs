
using ShopApp.DAL.Models.Products;

namespace ShopApp.DAL.Interfaces
{
    public interface IDaoProducts
    {
        void CreateProducts(ProductsCreateOrUpdateModel products);

        void UpdateProducts(ProductsCreateOrUpdateModel product);

        void RemoveProducts(ProductsRemoveModel products);

        List<GetProducts> GetProducts();

        GetProducts GetProductsById(int id);
    }
}

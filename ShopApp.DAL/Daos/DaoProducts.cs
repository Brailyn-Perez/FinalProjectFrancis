
using Microsoft.Extensions.Logging;
using ShopApp.DAL.Context;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models.Products;

namespace ShopApp.DAL.Daos
{
    internal class DaoProducts : IDaoProducts
    {
        private readonly ILogger _logger;
        private readonly ShopContext _shopContext;

        public DaoProducts(ShopContext context, ILogger<DaoSuppliers> logger)
        {
            _logger = logger;
            _shopContext = context;
        }
        public void CreateProducts(ProductsCreateOrUpdateModel products)
        {
            throw new NotImplementedException();
        }

        public List<GetProducts> GetProducts()
        {
            throw new NotImplementedException();
        }

        public GetProducts GetProductsById(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveProducts(ProductsRemoveModel products)
        {
            throw new NotImplementedException();
        }

        public void UpdateProducts(ProductsCreateOrUpdateModel product)
        {
            throw new NotImplementedException();
        }
    }
}

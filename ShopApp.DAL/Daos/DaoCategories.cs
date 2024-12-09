

using Microsoft.Extensions.Logging;
using ShopApp.DAL.Context;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models.Categories;

namespace ShopApp.DAL.Daos
{
    public class DaoCategories : IDaoCategories
    {
        private readonly ILogger _logger;
        private readonly ShopContext _shopContext;

        public DaoCategories(ILogger logger, ShopContext shopContext)
        {
            _logger = logger;
            _shopContext = shopContext;
        }

        public void CreateCategories(CategoriesCreateOrUpdateModel categories)
        {
            throw new NotImplementedException();
        }

        public List<GetCategories> GetCategories()
        {
            throw new NotImplementedException();
        }

        public GetCategories GetCategoriesById(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveCategories(CategoriesRemoveModel categories)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategories(CategoriesCreateOrUpdateModel categories)
        {
            throw new NotImplementedException();
        }
    }
}

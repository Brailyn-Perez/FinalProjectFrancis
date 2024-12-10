

using Microsoft.Extensions.Logging;
using ShopApp.DAL.Context;
using ShopApp.DAL.Entities;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models.Categories;

namespace ShopApp.DAL.Daos
{
    public class DaoCategories : IDaoCategories
    {
        private readonly ILogger _logger;
        private readonly ShopContext _shopContext;

        public DaoCategories(ShopContext shopContext)
        {
           
            _shopContext = shopContext;
        }

        public void CreateCategories(CategoriesCreateOrUpdateModel categoriesCreate)
        {
            try
            {
                Categories categories = new Categories()
                {
                    categoryid = categoriesCreate.categoryId,
                    categoryName = categoriesCreate.categoryName,
                    description = categoriesCreate.description,
                    creation_date = categoriesCreate.creation_date,
                    creation_user = categoriesCreate.creation_user

                };
                _shopContext.Categories.Add(categories);
                _shopContext.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError("Ocurrio un error creando una categoria");
            }
        }

        public List<GetCategories> GetCategories()
        {
            List<GetCategories> categoriesList = new List<GetCategories>();

            categoriesList = (from Categories in _shopContext.Categories
                         where Categories.deleted == false
                         select new GetCategories()
                         {
                             categoryId = Categories.categoryid,
                             categoryName = Categories.categoryName,
                             description = Categories.description,
                             creation_date = Categories.creation_date
                         }).ToList();
            
            return categoriesList;
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

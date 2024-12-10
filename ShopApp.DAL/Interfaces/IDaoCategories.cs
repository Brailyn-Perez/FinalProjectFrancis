
using ShopApp.DAL.Models.Categories;

namespace ShopApp.DAL.Interfaces
{
    public interface IDaoCategories
    {
        void CreateCategories(CategoriesCreateOrUpdateModel categories);

        void UpdateCategories(CategoriesCreateOrUpdateModel categories);

        void RemoveCategories(CategoriesRemoveModel categories);

        List<GetCategoriesModel>  GetCategories();

        GetCategoriesModel GetCategoriesById(int id);
    }
}

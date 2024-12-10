

using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using ShopApp.DAL.Context;
using ShopApp.DAL.Entities;
using ShopApp.DAL.Exceptions;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models.Categories;
using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace ShopApp.DAL.Daos
{
    public class DaoCategories : IDaoCategories
    {
        private readonly ILogger _logger;
        private readonly ShopContext _shopContext;

        public DaoCategories(ShopContext shopContext, ILogger<DaoCategories> logger)
        {
            _logger = logger;
            _shopContext = shopContext;
        }

        public void CreateCategories(CategoriesCreateOrUpdateModel categoriesCreate)
        {
            try
            {

                if (categoriesCreate is null)
                {
                    throw new DaoCategoriesException("La categoría no puede ser null.");
                }

                if (string.IsNullOrWhiteSpace(categoriesCreate.categoryName))
                {
                    throw new DaoCategoriesException("El nombre de la categoría no debe estar vacío.");
                }

                if (categoriesCreate.categoryName.Length > 15)
                {
                    throw new DaoCategoriesException("el nombre no puede exceder los 15 caracteres");
                }

                if (string.IsNullOrWhiteSpace(categoriesCreate.description))
                {
                    throw new DaoCategoriesException("La descripcion esta vacia");
                }

                if (categoriesCreate.description.Length > 200)
                {
                    throw new DaoCategoriesException("La descripción no puede exceder los 200 caracteres.");
                }

                if (categoriesCreate.creation_date == default)
                {
                    throw new DaoCategoriesException("La fecha de creación es inválida.");
                }

                if (categoriesCreate.creation_user <= 0)
                {
                    throw new DaoCategoriesException("El usuario creador debe ser un valor positivo.");
                }

                Categories categories = new Categories()
                {
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
                _logger.LogError($"Ocurrió un error inesperado creando la categoría: {ex}", ex);
                throw new DaoCategoriesException($"Ocurrió un error inesperado creando la categoría.{ex.ToString()}");
            }
        }

        public List<GetCategoriesModel> GetCategories()
        {
            List<GetCategoriesModel> categories = new List<GetCategoriesModel>();
            try
            {


                categories = (from categoriesdtos in _shopContext.Categories
                              where categoriesdtos.deleted == false
                              orderby categoriesdtos.creation_date descending
                              select new GetCategoriesModel()
                              {
                                  categoryId = categoriesdtos.categoryid,
                                  categoryName = categoriesdtos.categoryName,
                                  description = categoriesdtos.description,
                                  creation_date = categoriesdtos.creation_date
                              }).ToList();

            }
            catch (Exception ex)
            {
                _logger.LogError("Error opteniendo la lista de categori", ex.ToString());
            }
            return categories;
        }

        public GetCategoriesModel GetCategoriesById(int id)
        {
            GetCategoriesModel model = new GetCategoriesModel();
            try
            {
                var categorie = _shopContext.Categories.Find(id);
                if (categorie is null)
                {
                    throw new DaoCategoriesException("no se encontro la categoria por id");
                }

                model.categoryId = categorie.categoryid;
                model.categoryName = categorie.categoryName;
                model.description = categorie.description;
                model.creation_date = categorie.creation_date;

            }
            catch (Exception ex)
            {
                _logger.LogError("Error opteniendo categoria por ID");
            }
            return model;
        }

        public void RemoveCategories(CategoriesRemoveModel categoriesRemove)
        {
            try
            {
                if (categoriesRemove is null)
                {
                    throw new DaoCategoriesException("no se aceptan objetos nulos");
                }
                if (int.IsNegative(categoriesRemove.categoryId) || categoriesRemove.categoryId <= 0)
                {
                    throw new DaoCategoriesException("el Id no puede ser negativo");
                }
                if (categoriesRemove.categoryId.Equals(""))
                {
                    throw new DaoCategoriesException("No se aceptan valores de id vacios");
                }
                if (categoriesRemove.delete_user <= 0)
                {
                    throw new DaoCategoriesException("el Id no puede ser negativo");
                }
                if (categoriesRemove.delete_date == default)
                {
                    throw new DaoCategoriesException("Error con la fecha");
                }
                if (categoriesRemove.deleted == true)
                {
                    throw new DaoCategoriesException("no se pueden eliminar usuarios borrados");
                }

                Categories categories = new Categories()
                {
                    categoryid = categoriesRemove.categoryId,
                    delete_user = categoriesRemove.delete_user,
                    delete_date = categoriesRemove.delete_date,
                    deleted = true
                };

                _shopContext.Categories.Update(categories);
                _shopContext.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError("Error Eliminando Categorias", ex, ToString());
            }
        }

        public void UpdateCategories(CategoriesCreateOrUpdateModel categoriesUpdate)
        {
            try
            {
                if (categoriesUpdate is null)
                {
                    throw new DaoCategoriesException("La categoría no puede ser null.");
                }

                if (string.IsNullOrWhiteSpace(categoriesUpdate.categoryName))
                {
                    throw new DaoCategoriesException("El nombre de la categoría no debe estar vacío.");
                }

                if (categoriesUpdate.categoryName.Length > 15)
                {
                    throw new DaoCategoriesException("el nombre no puede exceder los 15 caracteres");
                }

                if (string.IsNullOrWhiteSpace(categoriesUpdate.description))
                {
                    throw new DaoCategoriesException("La descripcion esta vacia");
                }

                if (categoriesUpdate.description.Length > 200)
                {
                    throw new DaoCategoriesException("La descripción no puede exceder los 200 caracteres.");
                }

                if (categoriesUpdate.modify_date == default)
                {
                    throw new DaoCategoriesException("La fecha de modificacion es inválida.");
                }

                if (categoriesUpdate.modify_user <= 0)
                {
                    throw new DaoCategoriesException("El usuario modificador debe ser un valor positivo.");
                }

                Categories categories = new Categories()
                {
                    categoryid = categoriesUpdate.categoryId,
                    categoryName = categoriesUpdate.categoryName,
                    description = categoriesUpdate.description,
                    modify_date = categoriesUpdate.modify_date,
                    modify_user = categoriesUpdate.modify_user
                };
                _shopContext.Categories.Update(categories);
                _shopContext.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError("Error Editando las categorias", ex.ToString());
            }
        }
    }
}

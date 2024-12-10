using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models.Categories;

namespace ShopApp.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IDaoCategories _daoCategories;
        public CategoriesController(IDaoCategories daoCategories)
        {
            _daoCategories = daoCategories;
        }
        // GET: CategoriesController
        public ActionResult Index()
        {
            var categories = _daoCategories.GetCategories();
            return View(categories);
        }

        // GET: CategoriesController/Details/5
        public ActionResult Details(int id)
        {
            var categoriesById = _daoCategories.GetCategoriesById(id);
            return View(categoriesById);
        }

        // GET: CategoriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoriesCreateOrUpdateModel categoriesCreate)
        {
            try
            {
                categoriesCreate.creation_date = DateTime.Now;
                categoriesCreate.creation_user = 1;
                _daoCategories.CreateCategories(categoriesCreate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesController/Edit/5
        public ActionResult Edit(int id)
        {
            var editCategories = _daoCategories.GetCategoriesById(id);
            return View(editCategories);
        }

        // POST: CategoriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoriesCreateOrUpdateModel updateModel)
        {
            try
            {
                updateModel.modify_date = DateTime.Now;
                updateModel.modify_user = 1;
                _daoCategories.UpdateCategories(updateModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

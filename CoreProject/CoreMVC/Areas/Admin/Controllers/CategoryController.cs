using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using X.PagedList;

namespace CoreMVC.Areas.Admin.Controllers
{
    [Area("Admin")]  // Bu controller içerisinde oluşturulan action'ların area'dan geldigini bildirdik.
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index(int page = 1)
        {
            var values = cm.GetList().ToPagedList(page, 3); // sayfalama işleminde bize 2 syf getirir.
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category p)
        {
            CategoryValidator cv = new CategoryValidator();
            FluentValidation.Results.ValidationResult results = cv.Validate(p);
            if (results.IsValid) // sonuclar gecerli ise calisacak.
            {
                p.CategoryStatus = true;
                cm.TAdd(p);
                return RedirectToAction("Index", "Category"); // yönlendirme sayfası
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult CategoryDelete(int id)
        {
            var value = cm.TGetById(id);
            cm.TDelete(value);
            return RedirectToAction("Index");  // category/index'e yonlendirir.
        }
        public IActionResult CategoryEdit(Category p)
        {
            p.CategoryStatus = true;
            cm.TUpdate(p);
            return RedirectToAction("Index");
        }
    }
}

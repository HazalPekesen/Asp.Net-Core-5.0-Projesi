using CoreMVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreMVC.Areas.Admin.Controllers
{
    public class ChartController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<Category> list = new List<Category>();
            list.Add(new Category
            {
                categoryname = "Teknoloji",
                categorycount = 10
            });
            list.Add(new Category
            {
                categoryname = "Yazılım",
                categorycount = 14
            });
            list.Add(new Category
            {
                categoryname = "Spor",
                categorycount = 5
            });
            return Json(new { JSONList = list });
        }
    }
}

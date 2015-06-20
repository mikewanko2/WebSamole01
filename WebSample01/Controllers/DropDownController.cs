using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSample01.Models;

namespace WebSample01.Controllers
{
    public class DropDownController : Controller
    {
        // GET: DropDown
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit() {
            //今回は横着します
            var user = new User {Id = 1, CategoryId = 1, Name = "Tanaka" };
            var categoris = new List<Category> {
                  new Category { Id = 1, Name = "A" }
                , new Category { Id = 2, Name = "B" } 
            };
            //ViewBag定義
            ViewBag.Categories = new SelectList(categoris, "Id", "Name", user.CategoryId);
            return View(user);
        }
    }
}
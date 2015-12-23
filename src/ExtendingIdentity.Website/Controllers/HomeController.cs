using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using ExtendingIdentity.Website.Models;

namespace ExtendingIdentity.Website.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db) { _db = db; }
        public IActionResult Index()
        {
            var user = _db.Users.Include(p => p.WorkLogItems).FirstOrDefault();
            if (user != null)
            {
                user.WorkLogItems.Add(new WorkLogItem { Description = "New item added" });
                _db.SaveChanges();
                ViewBag.WorkItems = user.WorkLogItems.ToList();
            }
            else ViewBag.WorkItems = new WorkLogItem[] { };

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

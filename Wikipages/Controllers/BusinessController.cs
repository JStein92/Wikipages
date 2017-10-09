using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Wikipages.Models;

namespace Wikipages.Controllers
{
   
    public class BusinessController : Controller
    {
        private WikipagesContext db = new WikipagesContext();
        public IActionResult Index()
        {
            return View(db.Business.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Business business)
        {
            db.Business.Add(business);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

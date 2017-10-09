using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Wikipages.Models;

namespace Wikipages.Controllers
{

    public class BusinessTypeController : Controller
    {
        private WikipagesContext db = new WikipagesContext();
        public IActionResult Index()
        {
            return View(db.BusinessType.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(BusinessType businessType)
        {
            db.BusinessType.Add(businessType);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int businessTypeId)
        {
            var businessesOfType = db.Business.Where(businesses => businesses.Business_Type_Id == businessTypeId);

            var selectedBusiness = db.BusinessType.FirstOrDefault(selected => selected.Id == businessTypeId);
            
            return View(businessesOfType);
        }
        [HttpPost]
        public IActionResult CreateBusiness(Business business)
        {
            db.Business.Add(business);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult CreateBusiness()
        {
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VillaBerk.Models;

namespace VillaBerk.Controllers
{
    public class HomeController : Controller
    {
        VillaBerkContext _context = new VillaBerkContext();

        // GET: Home
        public ActionResult Index()
        {
            var products = _context
                .Products
                .Where(i => i.isApproved == true && i.isHome == true)
                .ToList();

            return View(products);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using mvcCore5._0.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace mvcCore5._0.Controllers
{
    public class ProductController : Controller
    {
        public readonly NorthwindContext _context;
        public ProductController(NorthwindContext context)
        {
            _context = context;
        }
        public IActionResult Details(int id)
        {
            Product product = _context.Products.Where(p => p.ProductId == id).FirstOrDefault();
            return View(product);
        }
        public IActionResult Index()
        {

            List<Product> products = _context.Products.ToList();
            return View(products);
        }
        public ActionResult CreatePopUp()
        {
            return PartialView();
        }
        [HttpGet]
        public JsonResult LoadLists()
        {
            
            var resp= Json(_context.Shippers.Select(x => new
            {
                ShipperId = x.ShipperId,
                CompanyName = x.CompanyName
            }).ToList());
            var data = resp.Value;
            //var data = JsonSerializer.Serialize(resp).ToList();
            return Json(new { data= data });//JsonRequestBehavior.AllowGet
        }
    }
    
}

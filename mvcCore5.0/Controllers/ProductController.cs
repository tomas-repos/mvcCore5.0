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
        [HttpGet]
        public JsonResult LoadShippers()
        {
            try
            {
                var resp= Json(_context.Shippers.Select(x => new
                {
                    ShipperId = x.ShipperId,
                    CompanyName = x.CompanyName
                }).ToList());
                var jsonString = JsonSerializer.Serialize(resp);
                return Json(jsonString, System.Web.Mvc.JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                throw;
            }
            
        }
    }
    
}

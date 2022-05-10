using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using mvcCore5._0.Models;

namespace mvcCore5._0.Models
{
    public class ProductSupplierCategory
    {
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> Suppliers { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}

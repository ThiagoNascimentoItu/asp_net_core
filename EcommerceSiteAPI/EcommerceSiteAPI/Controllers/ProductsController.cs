using EcommerceSiteAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceSiteAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private List<Product> _product = new List<Product>
        { 
            new Product(1,"Chinelo",10),
            new Product(2,"Tempero",5),
            new Product(3,"Bicicleta",50),
            new Product(4,"Raiva",250),
        };

       [HttpGet]
       public IActionResult Get()
        {
            return Ok(_product);
        }
    }
}

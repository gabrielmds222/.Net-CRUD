
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrudDotnet.Data;
using CrudDotnet.Models;
using System.Linq;

namespace CrudDotnet.Controllers
{
    [ApiController]
    [Route("v1/products")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Product>>> Get([FromServices] DataContext context)
        {
            var products = await context.Products.ToListAsync();
            return products;
        }

    }
}
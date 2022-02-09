using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _contex; 

        public ProductsController(StoreContext contex)
        {
            _contex = contex;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduts()
        {
            return await _contex.Products.ToListAsync();
        }

        [HttpGet ("{id}")]
        public async Task<ActionResult<Product>> getProduct(int id)
        { 
            return await _contex.Products.FindAsync(id);  
        }
    }
}

using FKDesignBusiness.Abstract;
using FKDesignEntities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FKDesignApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //private readonly IProductServices _productServices;
        //private readonly FKDesignDBContext _context;
        //private readonly IConfiguration _configuration;
        //private readonly GenericHelperMethods _genericHelperMethods;
        private IProductServices _productServices;
        public ProductController(IProductServices productServices)
        {
            this._productServices = productServices;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>>GetAllProducts()
        {
            var product = await _productServices.GetAllProducts();
            return Ok(product);
        }

    }
}

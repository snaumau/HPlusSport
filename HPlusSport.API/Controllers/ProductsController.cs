﻿using HPlusSport.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace HPlusSport.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext _context;

        public ProductsController(ShopContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public ActionResult GetAllProduct()
        {
            return Ok(_context?.Products?.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult GetProduct(int id)
        {
            var product = _context?.Products?.Find(id);
            if (product is null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}

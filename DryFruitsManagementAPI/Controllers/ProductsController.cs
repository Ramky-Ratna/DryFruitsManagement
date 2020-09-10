using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DryFruiltsDataService.Models;
using DryFruiltsDataService;

using Microsoft.AspNetCore.Cors;

namespace DryFruitsManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IDataRepository _repository;

        public ProductsController(IDataRepository repo)
        {
            _repository = repo;
        }

        // GET: api/Products
        [HttpGet]
        public ActionResult<List<TblProducts>> GetTblProducts()
        {
           return _repository.GetAllProducts();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public ActionResult<TblProducts> GetTblProducts(int id)
        {
            var product = _repository.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public IActionResult PutTblProducts(int id, TblProducts tblProducts)
        {
            if (id != tblProducts.ProductId)
            {
                return BadRequest();
            }
            tblProducts.Modified = DateTime.Now;
            _repository.UpdatProduct(tblProducts);
            return NoContent();
        }

        // POST: api/Products
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ActionResult PostTblProducts(TblProducts tblProducts)
        {
            tblProducts.AddedDate = DateTime.Now;
            tblProducts.Modified = DateTime.Now;
            _repository.AddProduct(tblProducts);
            return CreatedAtAction("GetTblProducts", new { id = tblProducts.ProductId }, tblProducts);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public ActionResult DeleteTblProducts(int id)
        {
            _repository.DeleteProduct(id);
            return NoContent();
        }
  }
}

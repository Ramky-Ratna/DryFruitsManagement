using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DryFruiltsDataService.Models;
using DryFruiltsDataService;

namespace DryFruitsManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypesController : ControllerBase
    {
        private IDataRepository _repository;

        public ProductTypesController(IDataRepository repo)
        {
            _repository = repo;
        }

        // GET: api/ProductTypes
        [HttpGet]
        public ActionResult<List<ProductType>> GetProductType()
        {
            return _repository.GetAllProductTypes().ToList();
        }       
    }
}

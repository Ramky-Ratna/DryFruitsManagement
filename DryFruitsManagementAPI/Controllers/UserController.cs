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
    public class UserController : ControllerBase
    {
        private IDataRepository _repository;

        public UserController(IDataRepository repo)
        {
            _repository = repo;
        }

        // GET: api/User
        [HttpGet]
        public ActionResult<List<TblUser>> GetTblUser()
        {
            return _repository.GetAllUsers();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public ActionResult<TblUser> GetTblUser(int id)
        {
            var tblUser = _repository.GetUserById(id);

            if (tblUser == null)
            {
                return NotFound();
            }

            return tblUser;
        }

        // PUT: api/User/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public IActionResult PutTblUser(int id, TblUser tblUser)
        {
            if (id != tblUser.UserId)
            {
                return BadRequest();
            }

            _repository.UpdateUser(tblUser);            

            return NoContent();
        }

        // POST: api/User
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public ActionResult PostTblUser(TblUser tblUser)
        {
           _repository.AddUser(tblUser);
            return CreatedAtAction("GetTblUser", new { id = tblUser.UserId }, tblUser);
        }

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public ActionResult DeleteTblUser(int id)
        {
            _repository.DeleteUser(id);

            return NoContent();
        }
        
    }
}

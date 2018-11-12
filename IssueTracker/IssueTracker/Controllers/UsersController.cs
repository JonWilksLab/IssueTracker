using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLibrary;

namespace IssueTracker.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUsers _users;
        private ILogger _logger;

        public UsersController(IUsers users, ILogger logger)
        {
            _users = users;
            _logger = logger;
        }
        // GET: api/Users
        [HttpGet(Name = "GetAllUsers")]
        public IEnumerable<User> Get()
        {
            return _users.GetUsers();
        }

        // GET: api/Users/5
        [HttpGet("{id}", Name = "GetUser")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Users
        [HttpPost(Name = "PostUser")]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Users/5
        [HttpPut("{id}", Name = "PutUser")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}", Name ="DeleteUser")]
        public void Delete(int id)
        {
        }
    }
}

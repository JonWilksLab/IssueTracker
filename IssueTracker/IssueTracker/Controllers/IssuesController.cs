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
    [Route("api/issues")]
    [ApiController]
    public class IssuesController : ControllerBase
    {
        private IIssues _issues;
        private ILogger _logger;

        public IssuesController(IIssues issues, ILogger logger)
        {
            _issues = issues;
            _logger = logger;
        }
        // GET: api/Issues
        [HttpGet(Name ="GetAllIssues")]
        public IEnumerable<Issue> Get()
        {
            return _issues.GetIssues();
        }

        // GET: api/Issues/5
        [HttpGet("{id}", Name = "GetIssue")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Issues
        [HttpPost(Name = "PostIssue")]
        public void Post([FromBody] Issue value)
        {
           _issues.UpdateIssue(value);
        }

        // PUT: api/Issues/5
        [HttpPut("{id}",Name ="PutIssue")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}", Name = "DeleteIssue")]
        public void Delete(int id)
        {
        }
    }
}

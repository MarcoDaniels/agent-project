using System.Collections.Generic;
using agent_project.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace agent_project.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ProjectController : Controller
    {
        // GET
        private readonly IProjectRepository _projectRepository;

        public ProjectController(IProjectRepository projectRepository) {
            _projectRepository = projectRepository;
        }
        
        // GET: api/
        [HttpGet]
        public IEnumerable<ProjectItem> GetAll() {
            return _projectRepository.GetAll().ToList();
        }

        // GET api/5
        [HttpGet("{name}", Name = "GetProject")]
        public IActionResult GetByName(string name) {
            var item = _projectRepository.Find(name);
            if (item == null) {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value) { }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value) { }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id) { }
    }
}
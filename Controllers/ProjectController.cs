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

        /**
         * constructor
         */
        public ProjectController(IProjectRepository projectRepository) {
            _projectRepository = projectRepository;
        }
        
        /**
         * Returns all occourences of projects
         * GET: api/project/
         */
        [HttpGet]
        public IEnumerable<ProjectItem> GetAll() {
            return _projectRepository.GetAll().ToList();
        }

        /**
         * Returns specific project
         * GET api/project/test
         */
        [HttpGet("{name}", Name = "GetProject")]
        public IActionResult GetByName(string name) {
            var item = _projectRepository.Find(name);
            if (item == null) {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        // POST api/project/
        [HttpPost]
        public void PostProject(ProjectItem value)
        {
            // TODO: implement
        }

        // PUT api/project/test/
        [HttpPut("{name}")]
        public void PutProject(string name, ProjectItem value)
        {
            // TODO: implement
        }

        // DELETE api/project/test
        [HttpDelete("{name}")]
        public void DeleteProject(int name)
        {
            // TODO: implement
        }
    }
}
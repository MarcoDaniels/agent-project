using agent_project.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace agent_project.Controllers
{
    [Produces("application/json")]
    [Route("agent/[controller]")]
    public class ProjectController : Controller
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectController(IProjectRepository projectRepository) {
            _projectRepository = projectRepository;
        }
        
        /**
         * GET: agent/project/
         */
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_projectRepository.GetAll().ToList());
        }

        /**
         * GET agent/project/{name}
         */
        [HttpGet("{name}", Name = "GetProject")]
        public IActionResult GetByName(string name) 
        {
            var item = _projectRepository.Find(name);
            if (item == null) {
                return NotFound();
            }
            return Ok(item);
        }

        // POST agent/project/
        [HttpPost]
        public void PostProject(ProjectItem value)
        {
            // TODO: implement
        }

        // PUT agent/project/test/
        [HttpPut("{name}")]
        public void PutProject(string name, ProjectItem value)
        {
            // TODO: implement
        }

        // DELETE agent/project/test
        [HttpDelete("{name}")]
        public void DeleteProject(int name)
        {
            // TODO: implement
        }
    }
}
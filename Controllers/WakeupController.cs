using System.Linq;
using agent_project.Models;
using Microsoft.AspNetCore.Mvc;

namespace agent_project.Controllers
{
    [Produces("application/json")]
    [Route("agent/[controller]")]
    public class WakeupController : Controller
    {
        private readonly IProjectRepository _projectRepo;

        public WakeupController(IProjectRepository projectRepo) {
            _projectRepo = projectRepo;
        }
        /**
         * wakeup call for agent
         * GET: agent/wakeup
         */
        [HttpGet]
        public IActionResult Wakeup()
        {
            var result = new WakeupStatus
            {
                Awake = true,
                Options = new []{
                    new Options
                    {
                        Type = "info",
                        Field = "name"
                    }, 
                    new Options
                    {
                        Type = "open",
                        Field = "name"
                    }
                },
                CountProjects = _projectRepo.GetAll().Count()
            };

            return Ok(result);
        }
        
        private class Options
        {
            public string Type;
            public string Field;
        }
        
        private class WakeupStatus
        {
            public bool Awake;
            public Options[] Options;
            public int CountProjects;
        }
    }
}
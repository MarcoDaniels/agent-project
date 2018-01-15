using System.Linq;
using agent_project.Models;
using Microsoft.AspNetCore.Mvc;

namespace agent_project.Controllers
{
    [Produces("application/json")]
    [Route("agent/[controller]")]
    public class WakeupController : Controller
    {
        // GET
        private readonly IProjectRepository _projectRepo;

        /**
         * constructor
         */
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
                CountProjects = _projectRepo.GetAll().Count()
            };

            return Ok(result);
        }
        
        /**
         * Wakeup status structure
         */
        private class WakeupStatus
        {
            public bool Awake;
            public int CountProjects;
        }
    }
}
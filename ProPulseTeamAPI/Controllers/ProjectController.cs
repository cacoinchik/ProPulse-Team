using Microsoft.AspNetCore.Mvc;

namespace ProPulseTeamAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : ControllerBase
    {
        private static readonly List<string> Projects = new()
        {
            "Проект 1",
            "Проект 2",
            "Проект 3"
        };

        [HttpGet]
        public ActionResult<List<string>> GetProjects()
        {
            return Ok(Projects);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IJobService _jobService;
        private JobsControllerMappers _mappers;

        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
            _mappers = new JobsControllerMappers();
        }

        [HttpGet("all")]
        public IActionResult GetAllJobs() { }

        [HttpGet("job/{Id]")]
        public IActionResult GetJobById(int jobId) { }

        [HttpPost("create")]
        public void CreateJob() { }

        [HttpPut("update")]
        public IActionResult UpdateJob() { }

        [HttpDelete("delete/{Id}")]
        public IActionResult DeleteJob(int jobId) { }
    }
}

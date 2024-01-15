using API.InputModels;
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
        public IActionResult GetAllJobs() {

            List<JobDTO> jobDTOs = _jobService.GetAllJobs();
            return jobDTOs == null ? NotFound() : Ok(jobDTOs);
        }

        [HttpGet("job/{Id}")]
        public IActionResult GetJobById(int jobId) 
        {
            JobDTO jobById = _jobService.GetJobById(jobId);
            return jobById == null ? NotFound() : Ok(jobById);
        }

        [HttpPost("create")]
        public void CreateJob(JobInputModelToAdd model) 
        {
            Console.WriteLine("create http request received");
            JobDTO jobDTO = _mappers.MapModelToJobDTOToAdd(model);
            _jobService.AddJob(jobDTO);
        }

        [HttpPut("update")]
        public IActionResult UpdateJob(JobInputModelToUpdate model)
        {
            JobDTO jobDTO = _mappers.MapModelToJobDTOToUpdate(model);
            bool jobUpdated = _jobService.UpdateJob(jobDTO);

            return jobUpdated == false ? NotFound() : Ok(jobDTO);
        }

        [HttpDelete("delete/{Id}")]
        public IActionResult DeleteJob(int jobId)
        {
            bool jobDeleted = _jobService.DeleteJob(jobId);

            return jobDeleted == false ? NotFound() : Ok(jobId);
        }
    }
}

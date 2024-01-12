using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal class JobServiceMappers
    {
        public Job MapJobDTOToJob(JobDTO jobDTO)
        {
            Job job = new Job
            {
                Id = jobDTO.Id,
                Company = jobDTO.Company,
                Description = jobDTO.Description,
                Interest = jobDTO.Interest,
                Status = jobDTO.Status,
                AppliedAt = jobDTO.AppliedAt,
            };

            return job;
        }

        public List<JobDTO> MapJobsToJobDTOs(List<Job> jobs)
        {
            List<JobDTO> jobDTOs = new List<JobDTO>();

            foreach (Job job in jobs)
            {
                JobDTO jobDTO = new JobDTO
                {
                    Id = job.Id,
                    Company = job.Company,
                    Description = job.Description,
                    Interest = job.Interest,
                    Status = job.Status,
                    AppliedAt = job.AppliedAt,
                };

                jobDTOs.Add(jobDTO);
            }

            return jobDTOs;
        }

        public JobDTO MapJobToJobDTO(Job job)
        {
            JobDTO jobDTO = new JobDTO
            {
                Id = job.Id,
                Company = job.Company,
                Description = job.Description,
                Interest = job.Interest,
                Status = job.Status,
                AppliedAt = job.AppliedAt,
            };

            return jobDTO;
        }
    }
}

using Core;
using DataBaseConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class JobService : IJobService
    {
        private readonly DataContext _dataContext;
        private JobServiceMappers _mappers;

        public JobService(DataContext dataContext)
        {
            _dataContext = dataContext;
            _mappers = new JobServiceMappers();
        }

        public void AddJob(JobDTO jobToAdd)
        {
            _dataContext.Jobs.Add(_mappers.MapJobDTOToJob(jobToAdd));
            _dataContext.SaveChanges();
        }

        public List<JobDTO> GetAllJobs()
        {
            List<Job> jobs = _dataContext.Jobs.ToList();

            return _mappers.MapJobsToJobDTOs(jobs);
        }

        public JobDTO GetJobById(int jobId)
        {
            Job? job = _dataContext.Jobs
                .Where(j => j.Id == jobId)
                .SingleOrDefault();

            return _mappers.MapJobToJobDTO(job);
        }

        public bool UpdateJob(JobDTO jobDTOToUpdate)
        {
            Job newJob = _mappers.MapJobDTOToJob(jobDTOToUpdate);
            Job? existingJob = _dataContext.Jobs.Find(jobDTOToUpdate.Id);
            bool jobExists = false;

            if (existingJob != null)
            {
                _dataContext.Entry(existingJob).CurrentValues.SetValues(newJob);
                _dataContext.SaveChanges();
                jobExists = true;
            }

            return jobExists;
        }

        public bool DeleteJob(int jobId)
        {
            var jobToDelete = _dataContext.Jobs.Find(jobId);
            bool jobExists = false;

            if (jobToDelete != null)
            {
                _dataContext.Jobs.Remove(jobToDelete);
                _dataContext.SaveChanges();
                jobExists = true;
            }

            return jobExists;
        }


    }
}

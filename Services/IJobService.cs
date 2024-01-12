using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IJobService
    {
        void AddJob(JobDTO jobDTO);
        List<JobDTO> GetAllJobs();
        JobDTO GetJobById(int id);
        bool UpdateJob(JobDTO jobDTO);
        bool DeleteJob(int id);
    }
}

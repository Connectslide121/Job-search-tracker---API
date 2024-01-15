using API.InputModels;
using Services;

namespace API
{
    public class JobsControllerMappers
    {
        public JobDTO MapModelToJobDTOToAdd(JobInputModelToAdd model)
        {
            JobDTO jobDTO = new JobDTO
            {
                Company = model.Company,
                Description = model.Description,
                Interest = model.Interest,
                Status = model.Status,
                AppliedAt = DateTime.Now,
            };

            return jobDTO;
        }

        public JobDTO MapModelToJobDTOToUpdate(JobInputModelToUpdate model)
        {
            JobDTO jobDTO = new JobDTO
            {
                Company = model.Company,
                Description = model.Description,
                Interest = model.Interest,
                Status = model.Status,
                AppliedAt = model.AppliedAt,
            };

            return jobDTO;
        }

    }
}

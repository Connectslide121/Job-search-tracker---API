namespace API.InputModels
{
    public class JobInputModelToUpdate
    {
        public string Company { get; set; }
        public string Description { get; set; }
        public string Interest { get; set; }
        public string Status { get; set; }
        public DateTime AppliedAt { get; set; }
    }
}

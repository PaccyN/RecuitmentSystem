namespace WebApplicant.Model
{
    public class InterviewGetInputDto
    {
        public Guid Id { get; set; }
        public string IdPosition { get; set; }
        public string IdApplicant { get; set; }
        public DateOnly InterviewDate { get; set; } 
        public TimeOnly TimeFrom { get; set; } 
        public TimeOnly TimeTo { get; set; }
        public bool IsActive { get; set; }
        public string UserAdded { get; set; }
        public DateTime DateAdded { get; set; }
    }
}

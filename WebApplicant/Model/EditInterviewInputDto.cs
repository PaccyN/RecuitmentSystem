namespace WebApplicant.Model
{
    public class EditInterviewInputDto
    {
        public Guid Id { get; set; }
        public string IdPosition { get; set; }
        public string IdApplicant { get; set; }
        public DateOnly InterviewDate { get; set; } = new DateOnly();
        public TimeOnly TimeFrom { get; set; }

        public TimeOnly TimeTo { get; set; }
    }
}

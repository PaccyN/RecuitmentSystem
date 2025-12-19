namespace APIApplicant.Model
{
    public class InterviewInputDto
    {
        public string IdPosition { get; set; }
        public string IdApplicant { get; set; }
        public DateOnly InterviewDate { get; set; } = new DateOnly();
        public TimeOnly TimeFrom { get; set; } 

        public TimeOnly TimeTo { get; set; } 
    }
}

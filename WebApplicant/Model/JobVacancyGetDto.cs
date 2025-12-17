namespace WebApplicant.Model
{
    public class JobVacancyGetDto
    {
        public Guid Id { get; set; }
        public string IdPosition { get; set; }
        public string NumberOfPosition { get; set; }
        public string Description { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}

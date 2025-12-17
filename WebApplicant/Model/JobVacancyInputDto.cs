namespace WebApplicant.Model
{
    public class JobVacancyInputDto
    {
        public string IdPosition { get; set; }
        public string NumberOfPosition { get; set; }
        public string Description { get; set; }
        public DateTime DateFrom { get; set; } = DateTime.Now;
        public DateTime DateTo { get; set; } = DateTime.Now;
    }
}

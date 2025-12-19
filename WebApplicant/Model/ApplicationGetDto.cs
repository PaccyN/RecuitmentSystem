namespace WebApplicant.Model
{
    public class ApplicationGetDto
    {
        public Guid Id { get; set; }
        public string IdApplicant { get; set; }
        public bool IsActive { get; set; }
        public DateTime Date { get; set; }
        public string UserAdded { get; set; }
        public DateTime DateAdded { get; set; }
    }
}

namespace WebApplicant.Model
{
    public class OfferGetDto
    {
        public Guid Id { get; set; }
        public string IdApplicant { get; set; }
        public string IdPosition { get; set; }
        public float Salary { get; set; }
        public string UserAdded { get; set; }
        public DateTime DateAdded { get; set; }
    }
}

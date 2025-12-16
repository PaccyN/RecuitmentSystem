namespace WebApplicant.Model
{
    public class ApplicantGetDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CV { get; set; }
        public string ApplicationLetter { get; set; }
        public string Reference { get; set; }
        public DateTime DateAdded { get; set; }
    }
}

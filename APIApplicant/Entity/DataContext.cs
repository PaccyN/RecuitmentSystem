using Microsoft.EntityFrameworkCore;

namespace APIApplicant.Entity
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder Builder)
        {
            base.OnConfiguring(Builder);
            Builder.UseSqlServer("Data Source=.;Initial Catalog=RecruitmentMIS; Integrated Security=True; TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
            model.Entity<Applicant>();
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace APIApplicant.Entity
{
    public class DataContext : DbContext
    {
        public DbSet<Interview> Interviews { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder Builder)
        {
            base.OnConfiguring(Builder);
            Builder.UseSqlServer("Data Source=.;Initial Catalog=RecruitmentMIS; Integrated Security=True; TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
            model.Entity<Applicant>();
            model.Entity<JobVacancy>();
            model.Entity<Application>();
            model.Entity<Interview>();
            model.Entity<Offer>();
        }
    }
}

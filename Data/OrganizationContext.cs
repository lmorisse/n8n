using Microsoft.EntityFrameworkCore;

namespace TranslectivateApp.Data
{
    public class OrganizationContext : DbContext
    {
        public OrganizationContext(DbContextOptions<OrganizationContext> options) : base(options)
        {
        }

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
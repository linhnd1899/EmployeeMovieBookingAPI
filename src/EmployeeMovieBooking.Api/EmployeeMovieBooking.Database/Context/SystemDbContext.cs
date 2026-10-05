using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EmployeeMovieBooking.Database.Context
{
    public partial class SystemDbContext : DbContext
    {
        public SystemDbContext(DbContextOptions<SystemDbContext> options) : base(options)
        {

        }

        public SystemDbContext(DbContextOptions<SystemDbContext> options, IConfiguration configuration) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("portal");
            builder.ApplyConfigurationsFromAssembly(typeof(EmployeeMovieBooking.Database.AssemblyReference).Assembly);
            base.OnModelCreating(builder);
        }
    }
}

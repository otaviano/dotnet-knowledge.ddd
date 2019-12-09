using Knowledge.Ddd.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Knowledge.Ddd.Infra.Data.Context
{
    public class UniversityDBContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }

        public UniversityDBContext(DbContextOptions options) 
            : base(options) { }
    }
}

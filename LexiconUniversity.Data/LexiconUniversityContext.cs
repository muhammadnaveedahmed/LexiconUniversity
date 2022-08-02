using LexiconUniversity.Core;
using Microsoft.EntityFrameworkCore;

namespace LexiconUniversity.Data
{
    public class LexiconUniversityContext : DbContext
    {
        public LexiconUniversityContext(DbContextOptions<LexiconUniversityContext> options)
            : base(options)
        {
        }

        public DbSet<Course> Course { get; set; }

        public DbSet<Student> Student { get; set; }
    }
}

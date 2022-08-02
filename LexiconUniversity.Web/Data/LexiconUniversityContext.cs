using Microsoft.EntityFrameworkCore;

namespace LexiconUniversity.Web.Data
{
    public class LexiconUniversityContext : DbContext
    {
        public LexiconUniversityContext(DbContextOptions<LexiconUniversityContext> options)
            : base(options)
        {
        }

        public DbSet<LexiconUniversity.Core.Course> Course { get; set; } = default!;

        public DbSet<LexiconUniversity.Core.Student>? Student { get; set; }
    }
}

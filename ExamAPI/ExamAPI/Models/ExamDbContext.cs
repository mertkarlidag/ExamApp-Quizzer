using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace ExamAPI.Models
{
    public class ExamDbContext:DbContext
    {
        public ExamDbContext(DbContextOptions<ExamDbContext> options):base(options)
        {

        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

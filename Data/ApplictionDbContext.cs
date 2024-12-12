using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using project.Models.student.cs;

namespace project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> Options) : base(Options)

        {


        }
        public DbSet<Student> Students { get; set; }
    }
}






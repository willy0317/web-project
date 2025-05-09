using web_final.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
namespace web_final.Models
{
    public class SchoolContext:DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Member> Members { get; set; }
        protected override void OnModelCreating(ModelBuilder mode){
          
        }
    }
}

    


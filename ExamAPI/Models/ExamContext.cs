using Microsoft.EntityFrameworkCore;

namespace ExamAPI.Models
{
    public class ExamContext : DbContext
    {
        public ExamContext (DbContextOptions<ExamContext> options) : base (options) 
        { 
        
        }
        
        public DbSet<Exam> exams { get; set; }

         


    }
}

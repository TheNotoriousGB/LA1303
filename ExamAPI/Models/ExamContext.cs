using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure; 
using Microsoft.EntityFrameworkCore.Storage;
using System.Linq.Expressions;
namespace ExamAPI.Models
{
    public class ExamContext : DbContext
    {
        public ExamContext (DbContextOptions<ExamContext> options) : base (options) 
        {
            try { 
            var databaseCreator = Database.GetService<IRelationalDatabaseCreator>() as RelationalDatabaseCreator;

            if (databaseCreator != null)
            {
                if (!databaseCreator.CanConnect()) databaseCreator.Create();
                if (!databaseCreator.HasTables()) databaseCreator.CreateTables();
            }

            }
            catch (Exception ex) 
            {
            Console.WriteLine (ex.Message);
            }
        }
        
        public DbSet<Exam> exams { get; set; }

         


    }
}

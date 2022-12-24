using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TP4.Models;

namespace TP4.Data
{
    public class UniversityContext : DbContext
    {
        private static UniversityContext? Singleton = null;
        public DbSet<Student> Student { get; set; }
        private UniversityContext(DbContextOptions o) : base(o) { }

        public static UniversityContext getInstance()
        {
            if (Singleton == null)
            {
                Singleton = Instatiate_UniversityContext();
            }
            return Singleton;
        }
        public static UniversityContext Instatiate_UniversityContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();

            optionsBuilder.UseSqlite("Data source=.\\database.db;");
            Debug.WriteLine("Running");

            return new UniversityContext(optionsBuilder.Options);
        }
    }
}

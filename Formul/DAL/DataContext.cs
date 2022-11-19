using Formul.Entities;
using Microsoft.EntityFrameworkCore;

namespace Formul.DAL
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
                
        }
        public DbSet<Formula> Formulas { get; set; }
        public DbSet<Parametr> Parametrs { get; set; }
    }
}


using FirstTask.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstTask.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
            :base(options) { 
        }
        public DbSet<Hello> Hellos { get; set; }
    }
}

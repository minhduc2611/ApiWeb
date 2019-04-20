using dotnetangular.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetangular.Persistence
{
    public class MyDbContext: DbContext
    {
        public MyDbContext (DbContextOptions<MyDbContext> options ):base(options)
        {
            
        }

        public DbSet<Make> Makes { get; set; }
    }
}
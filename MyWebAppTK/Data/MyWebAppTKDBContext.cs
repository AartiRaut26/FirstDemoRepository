using Microsoft.EntityFrameworkCore;
using MyWebAppTK.Models;

namespace MyWebAppTK.Data
{
    public class MyWebAppTKDBContext : DbContext
    {
        public MyWebAppTKDBContext(DbContextOptions<MyWebAppTKDBContext> options) : base(options)
        {
            
        }

        public DbSet<BookingsModel> bookings { get; set; }
    }
}

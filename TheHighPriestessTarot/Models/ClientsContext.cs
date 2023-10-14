using Microsoft.EntityFrameworkCore;

namespace TheHighPriestessTarot.Models
{
    public class ClientsContext : DbContext
    {
        public ClientsContext(DbContextOptions<ClientsContext> options) : base(options)
        {

        }

        public DbSet<Clients> Clients { get; set; }

        public DbSet<Healing_Dept> Healing_Dept { get; set; }

    }
}

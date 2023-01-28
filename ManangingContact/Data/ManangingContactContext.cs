using ManangingContact.Models;
using Microsoft.EntityFrameworkCore;

namespace ManangingContact.Data
{
    public class ManangingContactContext : DbContext
    {
        public ManangingContactContext(DbContextOptions<ManangingContactContext> options) : base(options)
        {
        }

        public DbSet<Contacts> Contacts { get; set; }
    }
}

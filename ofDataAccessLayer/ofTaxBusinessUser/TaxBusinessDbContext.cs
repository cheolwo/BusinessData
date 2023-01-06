using BusinessData.ofBusinessUser;
using Microsoft.EntityFrameworkCore;

namespace BusinessData.ofTaxBusinessUser
{
    public class TaxBusinessDbContext : DbContext
    {
        public TaxBusinessDbContext(DbContextOptions<TaxBusinessDbContext> options)
            : base(options)
        {

        }
        public DbSet<TaxBusinessUser> TaxBusinessUsers { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using Arsenoaia_Alexandru_Lab2.Models;

namespace Arsenoaia_Alexandru_Lab2.Data
{
    public class Arsenoaia_Alexandru_Lab2Context : DbContext
    {
        public Arsenoaia_Alexandru_Lab2Context (DbContextOptions<Arsenoaia_Alexandru_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Arsenoaia_Alexandru_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Arsenoaia_Alexandru_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}

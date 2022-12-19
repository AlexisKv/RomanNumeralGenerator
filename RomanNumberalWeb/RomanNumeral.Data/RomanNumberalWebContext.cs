using Microsoft.EntityFrameworkCore;

namespace RomanNumeral.Data
{
    public class RomanNumberalWebContext : DbContext, IRomanNumeralDbContext
    {
        public RomanNumberalWebContext (DbContextOptions<RomanNumberalWebContext> options)
            : base(options)
        {
        }

        public DbSet<RomanNumeral.Core.Models.Logs> Logs { get; set; } = default!;
        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
    }
}

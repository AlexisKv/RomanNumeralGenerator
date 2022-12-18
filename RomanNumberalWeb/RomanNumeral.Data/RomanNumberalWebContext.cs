using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RomanNumeral.Core.Models;

namespace RomanNumberalWeb.Data
{
    public class RomanNumberalWebContext : DbContext
    {
        public RomanNumberalWebContext (DbContextOptions<RomanNumberalWebContext> options)
            : base(options)
        {
        }

        public DbSet<RomanNumeral.Core.Models.Logs> Logs { get; set; } = default!;
    }
}

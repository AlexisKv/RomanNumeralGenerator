using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RomanNumeral.Core.Models;

namespace RomanNumeral.Data;

public interface IRomanNumeralDbContext
{
    DbSet<T> Set<T>() where T : class;
    EntityEntry<T> Entry<T>(T entity) where T : class;
    DbSet<Logs> Logs { get; set; }
    int SaveChanges();
    Task<int> SaveChangesAsync();
}
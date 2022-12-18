using RomanNumeral.Core.Models;

namespace RomanNumeral.Core.Services;

public interface IDbService
{
    public void Create<T>(T entity) where T : Entity;

    public void Delete<T>(T entity) where T : Entity;

    public void Update<T>(T entity) where T : Entity;

    public List<T> GetAll<T>() where T : Entity;

    public T GetById<T>(int id) where T : Entity;

    public IQueryable<T> Query<T>() where T : Entity;
}
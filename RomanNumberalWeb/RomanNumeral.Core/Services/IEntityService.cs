using RomanNumeral.Core.Models;

namespace RomanNumeral.Core.Services;

public interface IEntityService<T> where T: Entity
{
    public void Create(T entity);

    public void Delete(T entity);

    public void Update(T entity);

    public List<T> GetAll();

    public T GetById(int id);

    public IQueryable<T> Query();
}
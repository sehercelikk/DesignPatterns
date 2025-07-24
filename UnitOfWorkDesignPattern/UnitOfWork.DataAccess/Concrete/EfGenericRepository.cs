using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.DataAccess.Abstract;
using UnitOfWork.DataAccess.Context;

namespace UnitOfWork.DataAccess.Concrete;

public class EfGenericRepository<T> : IGenericDal<T> where T : class, new()
{
    private readonly DataContext _context;

    public EfGenericRepository(DataContext context)
    {
        _context = context;
    }

    public void Delete(T entity)
    {
        _context.Remove(entity);
    }

    public List<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }

    public T GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }

    public void Insert(T entity)
    {
        _context.Add(entity);
    }

    public void MultiUpdate(List<T> entity)
    {
        _context.UpdateRange(entity);
    }

    public void Update(T entity)
    {
        _context.Update(entity);
    }
}

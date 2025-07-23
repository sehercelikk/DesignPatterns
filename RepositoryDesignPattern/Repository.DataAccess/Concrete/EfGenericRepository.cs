using Npgsql.Internal;
using Repository.DataAccess.Abstract;
using Repository.DataAccess.Context;
using Repository.DataAccess.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataAccess.Concrete;

public class EfGenericRepository<T> : IGenericDal<T> where T : class, new()
{
    private readonly ProductDbContext _context;

    public EfGenericRepository(ProductDbContext context)
    {
        _context = context;
    }

    public void Delete(T entity)
    {
        _context.Remove(entity);
        _context.SaveChanges();

    }

    public T GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }

    public List<T> GetList()
    {
        return _context.Set<T>().ToList();
    }

    public void Insert(T entity)
    {
        _context.Add(entity);
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        _context.Update(entity);
        _context.SaveChanges();
    }
}

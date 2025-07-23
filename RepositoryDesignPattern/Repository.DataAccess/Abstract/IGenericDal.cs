using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataAccess.Abstract;

public interface IGenericDal<T> where T : class, new()
{
    void Insert(T entity);
    void Update(T entity);
    void Delete(T entity);
    List<T> GetList();
    T GetById(int id);
}

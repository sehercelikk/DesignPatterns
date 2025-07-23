using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Business.Abstract;

public interface IGenericService<T> where T : class,new()
{
    void TInsert(T entity);
    void TUpdate(T entity);
    void TDelete(T entity);
    List<T> TGetList();
    T TGetById(int id);
}

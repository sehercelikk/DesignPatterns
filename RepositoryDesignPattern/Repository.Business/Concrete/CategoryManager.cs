using Repository.Business.Abstract;
using Repository.DataAccess.Abstract;
using Repository.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Business.Concrete;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void TDelete(Category entity)
    {
        _categoryDal.Delete(entity);
    }

    public Category TGetById(int id)
    {
        return _categoryDal.GetById(id);
    }

    public List<Category> TGetList()
    {
        return _categoryDal.GetList();
    }

    public void TInsert(Category entity)
    {
        _categoryDal.Insert(entity);
    }

    public void TUpdate(Category entity)
    {
        _categoryDal.Update(entity);
    }
}

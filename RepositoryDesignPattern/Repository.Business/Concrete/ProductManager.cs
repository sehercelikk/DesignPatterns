﻿using Repository.Business.Abstract;
using Repository.DataAccess.Abstract;
using Repository.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Business.Concrete;

public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public void TDelete(Product entity)
    {
        _productDal.Delete(entity);
    }

    public Product TGetById(int id)
    {
       return _productDal.GetById(id);
    }

    public List<Product> TGetList()
    {
        return _productDal.GetList();
    }

    public void TInsert(Product entity)
    {
        _productDal.Insert(entity);
    }

    public void TUpdate(Product entity)
    {
        _productDal.Update(entity);
    }
    public List<Product> TGetCategoryProduct()
    {
        return _productDal.GetCategoryProductList();
    }
}

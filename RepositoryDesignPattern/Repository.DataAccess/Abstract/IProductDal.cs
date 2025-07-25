﻿using Repository.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataAccess.Abstract;

public interface IProductDal : IGenericDal<Product>
{
    List<Product> GetCategoryProductList();
}

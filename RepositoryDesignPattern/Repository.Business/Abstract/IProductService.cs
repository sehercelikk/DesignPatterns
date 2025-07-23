using Repository.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Business.Abstract;

public interface IProductService : IGenericService<Product>
{
    List<Product> TGetCategoryProduct();
}

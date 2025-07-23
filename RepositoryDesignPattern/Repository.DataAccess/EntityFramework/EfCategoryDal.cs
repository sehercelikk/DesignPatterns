using Repository.DataAccess.Abstract;
using Repository.DataAccess.Concrete;
using Repository.DataAccess.Context;
using Repository.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataAccess.EntityFramework;

public class EfCategoryDal : EfGenericRepository<Category>, ICategoryDal
{
    public EfCategoryDal(ProductDbContext context) : base(context)
    {
    }
}

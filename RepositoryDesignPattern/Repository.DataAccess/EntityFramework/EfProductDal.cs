using Microsoft.EntityFrameworkCore;
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

public class EfProductDal : EfGenericRepository<Product>, IProductDal
{
    private readonly ProductDbContext _context;
    public EfProductDal(ProductDbContext context) : base(context)
    {
        _context = context;
    }

    public List<Product> GetCategoryProductList()
    {
        var result = _context.Products.Include(a => a.Category).ToList();
        return result;
    }
}

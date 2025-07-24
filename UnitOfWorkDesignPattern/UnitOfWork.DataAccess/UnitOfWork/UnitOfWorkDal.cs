using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.DataAccess.Context;

namespace UnitOfWork.DataAccess.UnitOfWork;

public class UnitOfWorkDal : IUnitOfWorkDal
{
    private readonly DataContext _context;

    public UnitOfWorkDal(DataContext context)
    {
        _context = context;
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.DataAccess.Abstract;
using UnitOfWork.DataAccess.Concrete;
using UnitOfWork.DataAccess.Context;
using UnitOfWork.Entity.Concrete;

namespace UnitOfWork.DataAccess.EntityFramework;

public class EfProcessDal : EfGenericRepository<Process>, IProcessDal
{
    public EfProcessDal(DataContext context) : base(context)
    {
    }

}

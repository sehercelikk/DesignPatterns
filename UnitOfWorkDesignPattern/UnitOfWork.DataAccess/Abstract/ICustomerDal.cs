using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Entity.Concrete;

namespace UnitOfWork.DataAccess.Abstract;

public interface ICustomerDal : IGenericDal<Customer>
{
}

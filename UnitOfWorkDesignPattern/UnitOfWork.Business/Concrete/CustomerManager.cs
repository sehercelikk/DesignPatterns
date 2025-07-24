using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Business.Abstract;
using UnitOfWork.DataAccess.Abstract;
using UnitOfWork.DataAccess.UnitOfWork;
using UnitOfWork.Entity.Concrete;

namespace UnitOfWork.Business.Concrete;

public class CustomerManager : ICustomerService
{
    private readonly ICustomerDal _customerDal;
    private readonly IUnitOfWorkDal _unitOfWork;

    public CustomerManager(IUnitOfWorkDal unitOfWork, ICustomerDal customerDal)
    {
        _unitOfWork = unitOfWork;
        _customerDal = customerDal;
    }

    public void TDelete(Customer entity)
    {
        _customerDal.Delete(entity);
        _unitOfWork.Save();
    }

    public List<Customer> TGetAll()
    {
        return _customerDal.GetAll();
    }

    public Customer TGetById(int id)
    {
        return _customerDal.GetById(id);
    }

    public void TInsert(Customer entity)
    {
        _customerDal.Insert(entity);
        _unitOfWork.Save();
    }

    public void TMultiUpdate(List<Customer> entity)
    {
        _customerDal.MultiUpdate(entity);
        _unitOfWork.Save();
    }

    public void TUpdate(Customer entity)
    {
        _customerDal.Update(entity);
        _unitOfWork.Save();
    }
}

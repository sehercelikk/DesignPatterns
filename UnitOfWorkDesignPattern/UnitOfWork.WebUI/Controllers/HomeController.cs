using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UnitOfWork.Business.Abstract;
using UnitOfWork.Entity.Concrete;
using UnitOfWork.WebUI.Models;

namespace UnitOfWork.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerService _customerService;

        public HomeController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerViewModel model)
        {
            var value1 = _customerService.TGetById(model.SenderId);
            var value2= _customerService.TGetById(model.ReciverId);
            value1.Balance -= model.Amount;
            value2.Balance += model.Amount;
            List<Customer> modifiedCustomer = new List<Customer>
            {
                value1,
                value2
            };
            _customerService.TMultiUpdate(modifiedCustomer);
            return View();
        }
        public IActionResult GetListCustomer()
        {
            var values = _customerService.TGetAll();
            return View(values);
        }

        
    }
}

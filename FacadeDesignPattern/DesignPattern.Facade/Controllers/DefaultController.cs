using DesignPattern.Facade.DAL;
using DesignPattern.Facade.FacadePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Facade.Controllers;

public class DefaultController : Controller
{
    Context context=new Context();

    [HttpGet]
    public IActionResult AddNewCustomer()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddNewCustomer(Customer customer)
    {
        context.Customers.Add(customer);
        context.SaveChanges();
        return RedirectToAction("CustomerList");
    }

    public IActionResult CustomerList()
    {
        var values= context.Customers.ToList();
        return View(values);
    }

    public IActionResult AddNewProduct()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddNewProduct(Product product)
    {
        context.Products.Add(product);
        context.SaveChanges();
        return RedirectToAction("CustomerList");
    }

    public IActionResult ProductList()
    {
        var values = context.Products.ToList();
        return View(values);
    }


    [HttpGet]
    public IActionResult OrderDetailStart()
    {
        return View();
    }

    [HttpPost]
    public IActionResult OrderDetailStart(int customerId,int productId,int orderId, int productCount, decimal productPrice)
    {
        OrderFacade orderFacade = new OrderFacade();
        orderFacade.ComplateOrderDetail(customerId,productId,orderId,productCount,productPrice);
        
        return RedirectToAction("OrderIndex");
    }


    [HttpGet]
    public IActionResult OrderStart()
    {
        return View();
    }


    [HttpPost]
    public IActionResult OrderStart(int customerId)
    {
        OrderFacade orderFacade= new OrderFacade();
        orderFacade.ComplateOrder(customerId);
        return RedirectToAction("OrderIndex");

    }

    public IActionResult OrderIndex()
    {
        var values = context.Customers.ToList();
        return View(values);
    }

}

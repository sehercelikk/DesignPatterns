using DesignPatter.Mediator.MediatorPattern.Commands;
using DesignPatter.Mediator.MediatorPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DesignPatter.Mediator.Controllers;

public class ProductController : Controller
{
    private readonly IMediator _mediator;

    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task<IActionResult> Index()
    {
        var values = await _mediator.Send(new GetAllProductQuery());
        return View(values);
    }

    public async Task<IActionResult> GetByIdProduct(int id)
    {
        var values= await _mediator.Send(new GetProductByIdQuery(id));
        return View(values);
    }

    public async Task<IActionResult> DeleteProduct(int id)
    {
        await _mediator.Send(new RemoveProductCommand(id));
        return RedirectToAction("Index");
    }

    [HttpGet]
    public async Task<IActionResult> UpdateProduct(int id)
    {
        var findId = await _mediator.Send(new UpdateProductQuery(id));
        return View(findId);
    }

    [HttpPost]
    public async Task<IActionResult> UpdateProduct(UpdateProductCommand command)
    {
        await _mediator.Send(command);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult AddProduct() => View();

    [HttpPost]
    public async Task<IActionResult> AddProduct(CreateProductCommand command)
    {
        await _mediator.Send(command);
        return RedirectToAction("Index");
    }
}

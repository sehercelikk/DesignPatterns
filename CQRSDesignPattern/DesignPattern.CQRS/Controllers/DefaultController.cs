using DesignPattern.CQRS.CQRSPattern.Command;
using DesignPattern.CQRS.CQRSPattern.Handler;
using DesignPattern.CQRS.CQRSPattern.Queries;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.CQRS.Controllers;

public class DefaultController : Controller
{
    private readonly GetProductQueryHandler _getProductQueryHandler;
    private readonly CreateProductCommandHandler _createProductCommandHandler;
    private readonly GetProductByIdQueryHandler _getProductByIdQueryHandler;
    private readonly DeleteProductCommandHandler _deleteProductCommandHandler;
    private readonly UpdateProductCommandHandler _updateProductCommandHandler;
    private readonly PostUpdateProductCommandHandler _postUpdateProductCommandHandler;
    public DefaultController(GetProductQueryHandler getProductQueryHandler, CreateProductCommandHandler createProductCommandHandler, GetProductByIdQueryHandler getProductByIdQueryHandler, DeleteProductCommandHandler deleteProductCommandHandler, UpdateProductCommandHandler updateProductCommandHandler, PostUpdateProductCommandHandler postUpdateProductCommandHandler)
    {
        _getProductQueryHandler = getProductQueryHandler;
        _createProductCommandHandler = createProductCommandHandler;
        _getProductByIdQueryHandler = getProductByIdQueryHandler;
        _deleteProductCommandHandler = deleteProductCommandHandler;
        _updateProductCommandHandler = updateProductCommandHandler;
        _postUpdateProductCommandHandler = postUpdateProductCommandHandler;
    }

    public IActionResult Index()
    {
        var values = _getProductQueryHandler.Handle();
        return View(values);
    }

    public IActionResult Create() => View();

    [HttpPost]
    public IActionResult Create(CreateProductCommand command)
    {
        _createProductCommandHandler.Handle(command);
        return RedirectToAction("Index");
    }

    public IActionResult GetProduct(int id)
    {
        var value = _getProductByIdQueryHandler.Handle(new GetProductByIdQuery(id));
        return View(value);
    }

    public IActionResult DeleteProduct(int id)
    {
        _deleteProductCommandHandler.Handle(new DeleteProductCommand(id));
        return RedirectToAction("Index");
    }

    public IActionResult Update(int id)
    {
        var values= _updateProductCommandHandler.Handle(new GetProductUpdateIdQuery(id));
        return View(values);
    }

    [HttpPost]
    public IActionResult Update(UpdateProductCommand command)
    {
        _postUpdateProductCommandHandler.Handle(command);
        return RedirectToAction("Index");
    }


}

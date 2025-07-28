using MediatR;

namespace DesignPatter.Mediator.MediatorPattern.Commands;

public class UpdateProductCommand : IRequest
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public int Stock { get; set; }
    public string StockType { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
}

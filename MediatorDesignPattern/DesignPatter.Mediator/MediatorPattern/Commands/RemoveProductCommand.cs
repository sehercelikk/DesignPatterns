using MediatR;

namespace DesignPatter.Mediator.MediatorPattern.Commands;

public class RemoveProductCommand : IRequest
{
    public int ProductId { get; set; }

    public RemoveProductCommand(int productId)
    {
        ProductId = productId;
    }
}

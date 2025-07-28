using DesignPatter.Mediator.DAL;
using DesignPatter.Mediator.MediatorPattern.Commands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace DesignPatter.Mediator.MediatorPattern.Handlers;

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
{
    private readonly Context _context;

    public UpdateProductCommandHandler(Context context)
    {
        _context = context;
    }

    public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var values = await _context.Products.FindAsync(request.ProductId);
        values.Name= request.Name;
        values.Price= request.Price;
        values.Stock= request.Stock;
        values.CategoryId= request.CategoryId;
        values.StockType= request.StockType;
        await _context.SaveChangesAsync();
    }
}

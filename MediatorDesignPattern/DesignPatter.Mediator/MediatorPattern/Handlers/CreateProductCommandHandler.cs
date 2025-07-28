using DesignPatter.Mediator.DAL;
using DesignPatter.Mediator.MediatorPattern.Commands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace DesignPatter.Mediator.MediatorPattern.Handlers;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
{
    private readonly Context _context;

    public CreateProductCommandHandler(Context context)
    {
        _context = context;
    }

    public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var value = await _context.Products.AddAsync(new Product
        {
            Name = request.Name,
            CategoryId = request.CategoryId,
            Price = request.Price,
            Stock = request.Stock,
            StockType = request.StockType,
        });
        await _context.SaveChangesAsync();
    }
}

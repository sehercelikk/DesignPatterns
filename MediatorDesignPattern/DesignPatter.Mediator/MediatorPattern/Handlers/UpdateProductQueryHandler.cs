using DesignPatter.Mediator.DAL;
using DesignPatter.Mediator.MediatorPattern.Queries;
using DesignPatter.Mediator.MediatorPattern.Results;
using MediatR;
using NuGet.Protocol.Plugins;

namespace DesignPatter.Mediator.MediatorPattern.Handlers;

public class UpdateProductQueryHandler : IRequestHandler<UpdateProductQuery, UpdateProductQueryResult>
{
    private readonly Context _context;

    public UpdateProductQueryHandler(Context context)
    {
        _context = context;
    }

    public async Task<UpdateProductQueryResult> Handle(UpdateProductQuery request, CancellationToken cancellationToken)
    {
        var values = await _context.Products.FindAsync(request.Id);
        return new UpdateProductQueryResult
        {
            Name = values.Name,
            CategoryId = values.CategoryId,
            Price = values.Price,
            ProductId = values.ProductId,
            Stock = values.Stock,
            StockType = values.StockType,
        };
    }
}

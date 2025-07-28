using DesignPatter.Mediator.DAL;
using DesignPatter.Mediator.MediatorPattern.Queries;
using DesignPatter.Mediator.MediatorPattern.Results;
using MediatR;
using NuGet.Protocol.Plugins;

namespace DesignPatter.Mediator.MediatorPattern.Handlers;

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResult>
{
    private readonly Context _context;

    public GetProductByIdQueryHandler(Context context)
    {
        _context = context;
    }

    public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var values = await _context.Products.FindAsync(request.Id);
        return new GetProductByIdQueryResult
        {
            Name = values.Name,
            ProductId = values.ProductId,
            Stock = values.Stock,
        };
    }
}
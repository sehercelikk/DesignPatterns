using DesignPatter.Mediator.DAL;
using DesignPatter.Mediator.MediatorPattern.Queries;
using DesignPatter.Mediator.MediatorPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DesignPatter.Mediator.MediatorPattern.Handlers;

public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetAllProductQueryResult>>
{
    private readonly Context _context;

    public GetAllProductQueryHandler(Context context)
    {
        _context = context;
    }

    public async Task<List<GetAllProductQueryResult>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
    {
        return await _context.Products.Select(a => new GetAllProductQueryResult
        {
            ProductId = a.ProductId,
            Price = a.Price,
            Name = a.Name,
            CategoryId = a.CategoryId,
            Stock = a.Stock,
            StockType = a.StockType,
        }).AsNoTracking().ToListAsync();
    }
}

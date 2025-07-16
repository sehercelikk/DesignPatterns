using DesignPattern.CQRS.CQRSPattern.Queries;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handler;

public class GetProductByIdQueryHandler
{
    private readonly Context _context;

    public GetProductByIdQueryHandler(Context context)
    {
        _context = context;
    }

    public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
    {
        var values = _context.Set<Product>().Find(query.ID);
        return new GetProductByIdQueryResult
        {
            ProductName = values.Name,
            ProductID = values.ProductID,
            Price = values.Price,
            Stock = values.Stock,
        };
    }
}

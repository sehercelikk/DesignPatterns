using DesignPattern.CQRS.CQRSPattern.Queries;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handler;

public class UpdateProductCommandHandler
{
    private readonly Context _context;

    public UpdateProductCommandHandler(Context context)
    {
        _context = context;
    }

    public GetProductUpdateQueryResult Handle(GetProductUpdateIdQuery query)
    {
        var values = _context.Products.Find(query.Id);
        return new GetProductUpdateQueryResult
        {
            Name = values.Name,
            Price = values.Price,
            Description = values.Description,
            Stock = values.Stock,
            Id=values.ProductID,
        };
    }
}

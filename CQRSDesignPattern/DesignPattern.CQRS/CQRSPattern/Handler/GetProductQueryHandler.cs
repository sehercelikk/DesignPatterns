using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handler;

public class GetProductQueryHandler
{
    private readonly Context _context;

    public GetProductQueryHandler(Context context)
    {
        _context = context;
    }

    public List<GetProductQueryResult> Handle()
    {
        var values = _context.Products.Select(a => new GetProductQueryResult
        {
            ID=a.ProductID,
            Price=a.Price,
            ProductName=a.Name,
            Stock=a.Stock,
        }).ToList();

        return values;
    }
}

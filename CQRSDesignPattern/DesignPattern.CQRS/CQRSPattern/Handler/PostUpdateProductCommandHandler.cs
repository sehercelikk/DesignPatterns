using DesignPattern.CQRS.CQRSPattern.Command;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handler;

public class PostUpdateProductCommandHandler
{
    private readonly Context _context;

    public PostUpdateProductCommandHandler(Context context)
    {
        _context = context;
    }

    public void Handle(UpdateProductCommand command)
    {
        var value = _context.Products.Find(command.Id);
        value.Name = command.Name;
        value.Price = command.Price;
        value.Status = true;
        value.Stock = command.Stock;
        value.Description = command.Description;
        _context.SaveChanges();
    }
}

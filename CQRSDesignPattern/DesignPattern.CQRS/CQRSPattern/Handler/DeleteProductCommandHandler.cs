using DesignPattern.CQRS.CQRSPattern.Command;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handler;

public class DeleteProductCommandHandler
{
    private readonly Context _context;

    public DeleteProductCommandHandler(Context context)
    {
        _context = context;
    }

    public void Handle(DeleteProductCommand command)
    {
        var value= _context.Products.Find(command.Id);
        _context.Products.Remove(value);
        _context.SaveChanges();
    }
}

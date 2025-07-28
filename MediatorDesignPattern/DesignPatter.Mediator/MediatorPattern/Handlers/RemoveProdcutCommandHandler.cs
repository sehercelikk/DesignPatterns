using DesignPatter.Mediator.DAL;
using DesignPatter.Mediator.MediatorPattern.Commands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace DesignPatter.Mediator.MediatorPattern.Handlers;

public class RemoveProdcutCommandHandler : IRequestHandler<RemoveProductCommand>
{
    private readonly Context _context;

    public RemoveProdcutCommandHandler(Context context)
    {
        _context = context;
    }

    public async Task Handle(RemoveProductCommand request, CancellationToken cancellationToken)
    {
        var value= await _context.Products.FindAsync(request.ProductId);
         _context.Products.Remove(value);
        await _context.SaveChangesAsync();

    }
}

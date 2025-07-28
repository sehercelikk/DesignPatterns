using DesignPatter.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPatter.Mediator.MediatorPattern.Queries;

public class UpdateProductQuery : IRequest<UpdateProductQueryResult>
{
    public int Id { get; set; }

    public UpdateProductQuery(int id)
    {
        Id =id;
    }
}

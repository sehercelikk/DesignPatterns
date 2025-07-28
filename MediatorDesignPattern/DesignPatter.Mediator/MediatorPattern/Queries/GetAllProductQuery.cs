using DesignPatter.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPatter.Mediator.MediatorPattern.Queries;

public class GetAllProductQuery : IRequest<List<GetAllProductQueryResult>>
{

}

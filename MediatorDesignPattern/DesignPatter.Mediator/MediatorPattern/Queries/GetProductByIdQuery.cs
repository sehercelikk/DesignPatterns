﻿using DesignPatter.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPatter.Mediator.MediatorPattern.Queries;

public class GetProductByIdQuery : IRequest<GetProductByIdQueryResult>
{
    public int Id { get; set; }

    public GetProductByIdQuery(int id)
    {
        Id = id;
    }
}

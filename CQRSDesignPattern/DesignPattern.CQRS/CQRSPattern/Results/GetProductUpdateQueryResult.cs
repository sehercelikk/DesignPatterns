﻿namespace DesignPattern.CQRS.CQRSPattern.Results;

public class GetProductUpdateQueryResult
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
}

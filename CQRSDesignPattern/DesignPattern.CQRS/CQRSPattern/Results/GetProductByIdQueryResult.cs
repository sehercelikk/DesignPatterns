﻿namespace DesignPattern.CQRS.CQRSPattern.Results;

public class GetProductByIdQueryResult
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
}

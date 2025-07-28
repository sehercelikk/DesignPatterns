namespace DesignPatter.Mediator.MediatorPattern.Results;

public class UpdateProductQueryResult
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public int Stock { get; set; }
    public string StockType { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
}

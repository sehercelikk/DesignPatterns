namespace DesignPattern.CQRS.CQRSPattern.Queries;

public class GetProductUpdateIdQuery
{
    public int Id { get; set; }

    public GetProductUpdateIdQuery(int id)
    {
        Id = id;
    }
}

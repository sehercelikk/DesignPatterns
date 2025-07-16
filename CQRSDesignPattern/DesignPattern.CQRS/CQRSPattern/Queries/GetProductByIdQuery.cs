namespace DesignPattern.CQRS.CQRSPattern.Queries;

public class GetProductByIdQuery
{
    public int ID { get; set; }

    public GetProductByIdQuery(int ıD)
    {
        ID = ıD;
    }
}

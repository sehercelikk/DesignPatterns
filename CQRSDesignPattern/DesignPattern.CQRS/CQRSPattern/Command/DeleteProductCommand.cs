namespace DesignPattern.CQRS.CQRSPattern.Command;

public class DeleteProductCommand
{
    public int Id { get; set; }

    public DeleteProductCommand(int id)
    {
        Id = id;
    }
}

using DesignPattern.Observer.DAL;

namespace DesignPattern.Observer.ObserverPattern;

public class CreateDiscountCode : IObserver
{
    private readonly IServiceProvider _provider;

    public CreateDiscountCode(IServiceProvider provider)
    {
        _provider = provider;
    }

    Context context = new Context();

    public void CreateNewUser(AppUser appUser)
    {
        context.Discounts.Add(new Discount
        {
            DiscountCode = "DERGIMART",
            Amount = 35,
            Status = true
        });
        context.SaveChanges();
    }
}

using DesignPattern.Observer.DAL;

namespace DesignPattern.Observer.ObserverPattern;

public class CreateWelcomeMessage : IObserver
{
    private readonly IServiceProvider _provider;

    public CreateWelcomeMessage(IServiceProvider provider)
    {
        _provider = provider;
    }

    Context context=new Context();
    public void CreateNewUser(AppUser appUser)
    {
        context.WelcomeMessages.Add(new WelcomeMessage
        {
            Name = appUser.Name + " " + appUser.Surname,
            Content= "Dergi bültenimize kayıt olduğunuz için çok teşekkür ederim",
        });
        context.SaveChanges();
    }
}

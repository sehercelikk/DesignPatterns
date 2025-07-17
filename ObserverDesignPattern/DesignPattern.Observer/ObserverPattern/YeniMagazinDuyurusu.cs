using DesignPattern.Observer.DAL;

namespace DesignPattern.Observer.ObserverPattern;

public class YeniMagazinDuyurusu : IObserver
{
    private readonly IServiceProvider _provider;

    public YeniMagazinDuyurusu(IServiceProvider provider)
    {
        _provider = provider;
    }

    Context context = new Context();

    public void CreateNewUser(AppUser appUser)
    {
        context.UserProcesses.Add(new UserProcess
        {
            NameSurname = appUser.Name + " " + appUser.Surname,
            Magazine = "Bilim Dergisi",
            Content = "Bilim Dergimizin Mart Sayısı 1 Martta Evininize ulaştrılacaktır"
        });
        context.SaveChanges();
    }
}
    
using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern;

public class MailDecorator : Decorator
{
    private readonly INotifier _notifier;
    Context context = new Context();
    public MailDecorator(INotifier notifier, Context context) : base(notifier)
    {
        _notifier = notifier;
    }

    public void SendMailNotifier(Notifier notifier)
    {
        notifier.NotifierSubject = "Günlük Sabah Toplantısı";
        notifier.NotifierCreator = "Yönetici";
        notifier.NotifierChannel = "Mail";
        notifier.NotifierType = "Private Team";
        context.Notifiers.Add(notifier);
        context.SaveChanges();
    }

    public override void CreateNotify(Notifier notifier)
    {
        base.CreateNotify(notifier);
        SendMailNotifier(notifier);
    }
}

using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2;

public class EncryptoSubjectDecorator : Decorator
{
    private readonly ISendMessage _sendMessage;
    Context context=new Context();
    public EncryptoSubjectDecorator(ISendMessage sendMessage) : base(sendMessage)
    {
        _sendMessage = sendMessage;
    }

    public void SendMessageByEncryptoSubject(Message message)
    {
        
        string data = "";
        data = message.Subject;
        char[] chars = data.ToCharArray();
        foreach(var item in chars)
        {
            message.Subject += Convert.ToChar(item+3).ToString();
        }
        context.Messages.Add(message);
        context.SaveChanges();
    }

    public override void SendMessage(Message message)
    {
        base.SendMessage(message);
        SendMessageByEncryptoSubject(message);
    }
}

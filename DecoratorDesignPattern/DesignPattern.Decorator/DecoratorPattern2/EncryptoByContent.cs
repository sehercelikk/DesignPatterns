using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2;

public class EncryptoByContent : Decorator
{
    private readonly ISendMessage _sendMessage;
    Context context= new Context();
    public EncryptoByContent(ISendMessage sendMessage) : base(sendMessage)
    {
        _sendMessage = sendMessage;
    }

    public void SendMessageByEncryptoContent(Message message)
    {
        message.Sender = "Takım Lideri";
        message.Receiver = "Yazılım Ekibi";
        message.Content = "17.00 da publish yapılacak";
        message.Subject = "Proje Güncelleme";
        string data = "";
        data = message.Content;
        char[] chars = data.ToCharArray();
        foreach (var item in chars)
        {
            message.Content += Convert.ToChar(item + 3).ToString();
        }
        context.Messages.Add(message);
        context.SaveChanges();
    }

    public override void SendMessage(Message message)
    {
        base.SendMessage(message);
        SendMessageByEncryptoContent(message);
    }

}

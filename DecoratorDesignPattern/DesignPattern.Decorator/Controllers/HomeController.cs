using DesignPattern.Decorator.DAL;
using DesignPattern.Decorator.DecoratorPattern2;
using DesignPattern.Decorator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DesignPattern.Decorator.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index() => View();

    [HttpPost]
    public IActionResult Index(Message message)
    {
        CreateNewMessage createNewMessage = new CreateNewMessage();
        createNewMessage.SendMessage(message);
        return View();
    }

    [HttpGet]
    public IActionResult Index2() => View();

    [HttpPost]
    public IActionResult Index2(Message message)
    {
        CreateNewMessage createNewMessage = new CreateNewMessage();
        EncryptoSubjectDecorator encryptoSubject = new EncryptoSubjectDecorator(createNewMessage);
        encryptoSubject.SendMessageByEncryptoSubject(message);
        return View();
    }

    [HttpGet]
    public IActionResult Index3() => View();

    [HttpPost]
    public IActionResult Index3(Message message)
    {
        CreateNewMessage createNewMessage = new CreateNewMessage();
        SubjectIdDecorator subjectIdDecorator = new SubjectIdDecorator(createNewMessage);
        subjectIdDecorator.SendMessageIdSubject(message);
        return View();
    }

}

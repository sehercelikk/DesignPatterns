using DesignPattern.TemplateMethod.TemplatePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.TemplateMethod.Controllers;

public class DefaultController : Controller
{
    public IActionResult BasicPlanIndex()
    {
        NetflixPlans netflixPlans = new BasicPlan();
        ViewBag.v1 = netflixPlans.PlanType("Temel Plan");
        ViewBag.v2 = netflixPlans.CountPerson(2);
        ViewBag.v3 = netflixPlans.Price(64.99);
        ViewBag.v4 = netflixPlans.Content("Film-Dizi");
        ViewBag.v5 = netflixPlans.Resolution("720px");


        NetflixPlans netflixPlans1 = new StandartPlan();
        ViewBag.v6 = netflixPlans.PlanType("Standart Plan");
        ViewBag.v7 = netflixPlans.CountPerson(3);
        ViewBag.v8 = netflixPlans.Price(74.99);
        ViewBag.v9 = netflixPlans.Content("Film-Dizi-Müzik");
        ViewBag.v10 = netflixPlans.Resolution("1080px");

        NetflixPlans netflixPlans2 = new UltraPlan();
        ViewBag.v11 = netflixPlans.PlanType("Ultra Plan");
        ViewBag.v12 = netflixPlans.CountPerson(20);
        ViewBag.v13 = netflixPlans.Price(99.99);
        ViewBag.v14 = netflixPlans.Content("Film-Dizi-Müzik-Oyun");
        ViewBag.v15 = netflixPlans.Resolution("Full HD");
        return View();
    }
}

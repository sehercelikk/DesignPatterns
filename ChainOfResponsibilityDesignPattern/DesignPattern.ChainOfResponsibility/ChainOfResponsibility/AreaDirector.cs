using DesignPattern.ChainOfResponsibility.DAL.Context;
using DesignPattern.ChainOfResponsibility.DAL.Entities;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility;

public class AreaDirector : Employee
{
    public override void ProcessRequest(CustomerProcessViewModel req)
    {
        Context context = new Context();
        if (req.Amount <= 400000)
        {
            CustomerProcess customerProcess = new CustomerProcess();
            customerProcess.Amount = req.Amount.ToString();
            customerProcess.CustomerName = req.CustomerName;
            customerProcess.EmployeeName = "Bölge Müdürü - Ahmet Karaca";
            customerProcess.Description = "Para çekme işlemi onaylandı, müşteriye talep ettiği tutar ödendi";
            context.CustomerProcesses.Add(customerProcess);
            context.SaveChanges();
        }
        else
        {
            CustomerProcess customerProcess = new CustomerProcess();
            customerProcess.Amount = req.Amount.ToString();
            customerProcess.CustomerName = req.CustomerName;
            customerProcess.EmployeeName = "Bölge Müdürü - Ahmet Karaca";
            customerProcess.Description = "Para çekme işlemi bölge müdürünün günlük ödeme limitini aştığı için işlem  reddedildi. Müşterinin günlük en fazla çekebileceği " +
                "tutar 400 Bin ₺ olup çekmek istediği kalan tutar için bir sonraki iş gününü beklemek durumundadır.";
            context.CustomerProcesses.Add(customerProcess);
            context.SaveChanges();
        }
    }
}

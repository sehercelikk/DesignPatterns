using DesignPattern.ChainOfResponsibility.DAL.Context;
using DesignPattern.ChainOfResponsibility.DAL.Entities;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility;

public class ManagerAssistant : Employee
{
    public override void ProcessRequest(CustomerProcessViewModel req)
    {
        Context context = new Context();
        if(req.Amount<=150000)
        {
            CustomerProcess customerProcess = new CustomerProcess();
            customerProcess.Amount = req.Amount.ToString();
            customerProcess.CustomerName = req.CustomerName;
            customerProcess.EmployeeName = "Şube Müdür Yardımcısı - Hasan Kaygusuz";
            customerProcess.Description = "Para çekme işlemi onaylandı, müşteriye talep ettiği tutar ödendi";
            context.CustomerProcesses.Add(customerProcess);
            context.SaveChanges();
        }
        else if (NextApprover != null)
        {
            CustomerProcess customerProcess = new CustomerProcess();
            customerProcess.Amount = req.Amount.ToString();
            customerProcess.CustomerName = req.CustomerName;
            customerProcess.EmployeeName = "Şube Müdür Yardımcısı - Hasan Kaygusuz";
            customerProcess.Description = "Para çekme işlemi şube müdür yardımcısının günlük ödeme limitini aştığı için işlem Şube Müdürüne yönlendirildi";
            context.CustomerProcesses.Add(customerProcess);
            context.SaveChanges();
            NextApprover.ProcessRequest(req);
        }
    }
}

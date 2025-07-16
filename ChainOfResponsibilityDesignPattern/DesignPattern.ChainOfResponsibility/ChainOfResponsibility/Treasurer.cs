using DesignPattern.ChainOfResponsibility.DAL.Context;
using DesignPattern.ChainOfResponsibility.DAL.Entities;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility;

public class Treasurer : Employee
{
    public override void ProcessRequest(CustomerProcessViewModel req)
    {
        Context context = new Context();
        if(req.Amount<=100000)
        {
            CustomerProcess customerProcess = new CustomerProcess();
            customerProcess.Amount = req.Amount.ToString();
            customerProcess.CustomerName = req.CustomerName;
            customerProcess.EmployeeName = "Veznedar - Ayşe Çınar";
            customerProcess.Description = "Para çekme işlemi onaylandı, müşteriye talep ettiği tutar ödendi";
            context.CustomerProcesses.Add(customerProcess);
            context.SaveChanges();
        }
        else if(NextApprover !=null)
        {
            CustomerProcess customerProcess = new CustomerProcess();
            customerProcess.Amount= req.Amount.ToString();
            customerProcess.CustomerName = req.CustomerName;
            customerProcess.EmployeeName = "Veznedar - Ayşe Çınar";
            customerProcess.Description = "Para çekme işlemi veznedarın günlük ödeme limitini aştığı için işlem Şube Müdür Yardımcısına yönlendirildi";
            context.CustomerProcesses.Add(customerProcess);
            context.SaveChanges();
            NextApprover.ProcessRequest(req);
        }
           
    }
}

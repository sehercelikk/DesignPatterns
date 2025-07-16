using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility;

public abstract class Employee 
{
    protected Employee NextApprover;
    public void SetNextApprover(Employee superviser)
    {
        this.NextApprover = superviser;
    }

    public abstract void ProcessRequest(CustomerProcessViewModel req);
}

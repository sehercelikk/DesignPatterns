using System.Text;

namespace DesignPattern.Composite.CompositePattern;

public class ProductComposite : IComponent
{
    private List<IComponent> _component;
    public ICollection<IComponent> Component=> _component;

    public void Add(IComponent component)
    {
        _component.Add(component);
    }

    public int Id { get; set; }
    public string Name { get; set; }

    public ProductComposite(int id, string name)
    {
        Id = id;
        Name = name;
        _component = new List<IComponent>();
    }


    public string Display()
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append($"<div class='text-success'> {Name} ({TotalCount()})</div>");
        stringBuilder.Append("<ul class='list-group list-group-flush ms-2'>");
        foreach (var component in _component)
        {
            stringBuilder.Append(component.Display());
        }
        stringBuilder.Append("</ul>");
        return stringBuilder.ToString();
    }

    public int TotalCount()
    {
        return _component.Sum(a=>a.TotalCount());
    }
}

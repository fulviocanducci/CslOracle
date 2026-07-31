namespace WinForm.Models;

public sealed class People
{
    public People()
    {

    }
    public People(string name, decimal price, bool active)
    {
        Name = name;
        Price = price;
        Active = active;
    }

    public People(int id, string name, decimal price, bool active)
    {
        Id = id;
        Name = name;
        Price = price;
        Active = active;
    }

    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; } = 0;
    public bool Active { get; set; } = true;
    public DateTime CreatedAt { get; set; }
}

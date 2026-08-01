namespace WinForm.Models;

public sealed class People
{
    public People() { }

    public People(string name, decimal price, bool active, DateTime createdAt)
    {
        Id = 0;
        Name = name.ToUpper();
        Price = price;
        Active = active;
        CreatedAt = createdAt;
    }

    public People(int id, string name, decimal price, bool active, DateTime createdAt) : this(name, price, active, createdAt)
    {
        Id = id;
    }

    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; } = 0;
    public bool Active { get; set; } = true;
    public DateTime CreatedAt { get; set; }
}

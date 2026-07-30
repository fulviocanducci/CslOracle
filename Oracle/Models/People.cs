namespace Oracle.Models;

public class People
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public DateTime? CreatedAt { get; set; }

    public static implicit operator bool(People? people) => people != null;
}

public class Option<T>
{
    private readonly T? _value;
    private Option(T? value)
    {
        _value = value;
    }
    public bool HasValue => _value is not null;
    public T Value => HasValue ? _value! : throw new InvalidOperationException("No value");
    public static implicit operator bool(Option<T> option) => option.HasValue;
    public static implicit operator Option<T>(T? value) => new(value);
}

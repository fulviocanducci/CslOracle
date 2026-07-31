namespace Mask;

public static class Extensions
{
    public static Currency MaskCurrency(this TextBox textBox, string value = "0,00")
    {
        return Currency.Add(textBox, value);
    }
}

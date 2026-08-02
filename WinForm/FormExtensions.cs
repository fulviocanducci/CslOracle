using FluentValidation.Results;
using System.Globalization;
using System.Text;

namespace WinForm;

public static class FormExtensions
{
    internal static FontStyle SetUnderline(CheckBox checkBox)
    {
        return checkBox.Font.Style | FontStyle.Underline;
    }
    internal static FontStyle DelUnderline(CheckBox checkBox)
    {
        return checkBox.Font.Style & ~FontStyle.Underline;
    }
    public static void SetLayoutFocus(this CheckBox checkBox)
    {
        if (checkBox is null)
        {
            return;
        }
        Font originalFont = checkBox.Font;
        checkBox.GotFocus += (_, _) =>
        {
            checkBox.Font = new Font(originalFont, originalFont.Style | FontStyle.Underline);
        };
        checkBox.LostFocus += (_, _) =>
        {
            checkBox.Font = originalFont;
        };
    }

    public static bool IsValue(this ValidationFailure failure, string find)
    {
        return IsValue(failure.PropertyName, find);
    }
    public static bool IsValue(this string value, string find)
    {
        if (string.IsNullOrWhiteSpace(value)) return false;
        return value.Equals(find, StringComparison.OrdinalIgnoreCase);
    }

    public static void Toggle(this Button button, string loading = "Salvando")
    {
        if (button.Enabled)
        {
            button.Tag = button.Text;
            button.Enabled = false;
            button.Text = loading;
        }
        else
        {
            button.Enabled = true;
            button.Text = button.Tag?.ToString();
        }
        button.Update();
        button.Refresh();
    }
    public static bool TryGetDateTime(this TextBox tb, out DateTime value, string? format = null, CultureInfo? culture = null)
    {
        culture ??= CultureInfo.CurrentCulture;
        value = default;
        if (string.IsNullOrWhiteSpace(tb.Text)) return false;
        if (!string.IsNullOrEmpty(format))
            return DateTime.TryParseExact(tb.Text, format, culture, DateTimeStyles.None, out value);
        return DateTime.TryParse(tb.Text, culture, DateTimeStyles.None, out value);
    }

    public static bool TryGetDate(this TextBox tb, out DateTime value, string? format = "dd/MM/yyyy", CultureInfo? culture = null)
    {
        return TryGetDateTime(tb, out value, format, culture);
    }

    public static bool TryGetDateTime(this MaskedTextBox mb, out DateTime value, string? format = "dd/MM/yyyy HH:mm:ss", CultureInfo? culture = null)
    {
        culture ??= CultureInfo.CurrentCulture;
        value = default;
        if (string.IsNullOrWhiteSpace(mb.Text)) return false;
        if (!string.IsNullOrEmpty(format))
            return DateTime.TryParseExact(mb.Text, format, culture, DateTimeStyles.None, out value);
        return DateTime.TryParse(mb.Text, culture, DateTimeStyles.None, out value);
    }

    public static bool TryGetDate(this MaskedTextBox mb, out DateTime value, string? format = "dd/MM/yyyy", CultureInfo? culture = null)
    {
        return TryGetDateTime(mb, out value, format, culture);
    }

    public static bool TryGetDecimalCurrency(this TextBox tb, out decimal value, CultureInfo? culture = null)
    {
        culture ??= CultureInfo.CurrentCulture;
        return decimal.TryParse(tb.Text, NumberStyles.Currency, culture, out value);
    }

    public static int ToGetIntValue(this DataGridView dataGridView, string name)
    {
        object? id = dataGridView?.CurrentRow?.Cells[name].Value;
        if (id != null && int.TryParse(id.ToString(), out int Id))
        {
            return Id;
        }
        return 0;
    }

    public static long ToGetLongValue(this DataGridView dataGridView, string name)
    {
        object? id = dataGridView?.CurrentRow?.Cells[name].Value;
        if (id != null && long.TryParse(id.ToString(), out long Id))
        {
            return Id;
        }
        return 0;
    }

    public static string ToTextDate(this DateTime value, string format = "dd/MM/yyyy")
    {
        return value.ToString(format);
    }
    public static string ToTextDateTime(this DateTime value, string format = "dd/MM/yyyy HH:mm:ss")
    {
        return value.ToString(format);
    }
    public static string ToTextDecimal(this decimal value, int decimalPlaces = 2)
    {
        return value.ToString($"N{decimalPlaces}");
    }
    public static string GetErrors(this List<ValidationFailure> errors)
    {
        if (errors == null)
        {
            return string.Empty;
        }
        StringBuilder str = new(errors.Count);
        foreach (ValidationFailure failure in errors)
        {
            if (str.Length > 0)
            {
                str.Append(@$"{Environment.NewLine}{failure.ErrorMessage}");
            }
            else
            {
                str.Append(failure.ErrorMessage);
            }
        }
        return str.ToString();
    }
    public static void EnterAsTab(this Form form)
    {
        form.KeyPreview = true;
        form.KeyDown += (_, e) =>
        {
            if (e.KeyCode != Keys.Enter) return;
            form.SelectNextControl(form.ActiveControl, true, true, true, true);
            e.SuppressKeyPress = true;
        };
    }
}

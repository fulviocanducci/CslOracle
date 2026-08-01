using FluentValidation.Results;
using System.Text;

namespace WinForm;

public static class FormExtensions
{
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

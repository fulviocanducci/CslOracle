namespace WinForm;

public static class MessageCustomBox
{
    public static DialogResult Show(string message, string title = "Informação", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information)
    {
        return MessageBox.Show(message, title, buttons, icon);
    }

    public static DialogResult Error(string message)
    {
        return MessageBox.Show(message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static DialogResult Success(string message)
    {
        return MessageBox.Show(message, "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static DialogResult Warning(string message)
    {
        return MessageBox.Show(message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public static DialogResult Question(string message)
    {
        return MessageBox.Show(message, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    }
}

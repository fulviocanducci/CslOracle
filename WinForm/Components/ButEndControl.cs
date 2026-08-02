namespace WinForm.Components;

public partial class ButEndControl : UserControl
{
    public event EventHandler? OnPressed;

    public ButEndControl()
    {
        InitializeComponent();
        ButEnd.Dock = DockStyle.Fill;
    }

    private void ButEnd_Click(object? sender, EventArgs e)
    {
        OnPressed?.Invoke(this, e);
    }

    public Button Button
    {
        get { return ButEnd; }
    }

    public void PerformClick()
    {
        ButEnd?.PerformClick();
    }

    public static implicit operator Button(ButEndControl butEndControl)
    {
        return butEndControl.ButEnd;
    }
}

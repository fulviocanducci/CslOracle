namespace WinForm.Components
{
    public partial class ButNewControl : UserControl
    {
        public event EventHandler? OnPressed;
        public ButNewControl()
        {
            InitializeComponent();
            ButNew.Dock = DockStyle.Fill;
        }

        public Button Button
        {
            get { return ButNew; }
        }

        public void PerformClick()
        {
            ButNew?.PerformClick();
        }

        private void ButNew_Click(object sender, EventArgs e)
        {
            OnPressed?.Invoke(this, e);
        }

        public static implicit operator Button(ButNewControl butNewControl)
        {
            return butNewControl.ButNew;
        }
    }
}

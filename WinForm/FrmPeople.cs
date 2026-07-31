using WinForm.DataAccess;

namespace WinForm
{
    public partial class FrmPeople : Form
    {
        public readonly OracleDataAccess OracleDataAccess;
        public FrmPeople()
        {
            InitializeComponent();
            OracleDataAccess = OracleConnection.Instance;
            //OracleDataAccess.Database.EnsureCreated();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridLoad();
        }

        private void DataGridLoad()
        {
            DataGridViewPeoples.DataSource = OracleDataAccess
                .People
                .Select(x => new { x.Id, x.Name })
                .ToList();
        }
        private void ButEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtuNew_Click(object sender, EventArgs e)
        {
            using FrmPeopleUpdate frm = new(OracleDataAccess);
            frm.ShowDialog();
            DataGridLoad();
        }
    }
}

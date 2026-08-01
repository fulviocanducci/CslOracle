using WinForm.DataAccess;
using WinForm.Repositories;

namespace WinForm
{
    public partial class FrmPeople : Form
    {
        public readonly OracleDataAccess OracleDataAccess;
        public readonly RepositoryPeople RepositoryPeople;
        public FrmPeople()
        {
            InitializeComponent();
            OracleDataAccess = OracleConnection.Instance.CreateContext();
            RepositoryPeople = new(OracleDataAccess);
        }

        private void DataGridLoad()
        {
            DataGridViewPeoples.DataSource = RepositoryPeople.Get(TxtSearch.Text);
        }

        private void FrmPeopleUpdateShow(int id = 0)
        {
            using FrmPeopleUpdate frm = new(OracleDataAccess, id);
            frm.ShowDialog();
            DataGridLoad();
        }

        private void ButEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtuNew_Click(object sender, EventArgs e)
        {
            FrmPeopleUpdateShow();
        }

        private void DataGridViewPeoples_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int Id = ((DataGridView)sender).ToGetIntValue("ColumnPeopleId");
                if (Id > 0)
                {
                    FrmPeopleUpdateShow(Id);
                }
            }
        }

        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataGridLoad();
            }
        }

        private void FrmPeople_Load(object sender, EventArgs e)
        {
            DataGridLoad();
        }
    }
}

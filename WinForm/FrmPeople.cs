using Microsoft.EntityFrameworkCore;
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
                .AsNoTracking()
                .Where(c => c.Name.ToUpper().StartsWith(TxtSearch.Text.ToUpper()))
                .OrderBy(o => o.Name)
                .Select(x => new { x.Id, x.Name })
                .ToList();
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
                DataGridView dataGridView = (DataGridView)sender;
                object? id = dataGridView?.CurrentRow?.Cells["ColumnPeopleId"].Value;
                if (id != null && int.TryParse(id.ToString(), out int Id))
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
    }
}

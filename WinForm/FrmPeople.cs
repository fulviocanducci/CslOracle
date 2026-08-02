using WinForm.DataAccess;
using WinForm.Repositories;

namespace WinForm;

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
        if (frm.Updated) DataGridLoad();
    }

    private void ButNew_OnPressed(object sender, EventArgs e)
    {
        FrmPeopleUpdateShow();
    }

    private void ButEnd_OnPressed(object sender, EventArgs e)
    {
        Close();
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
        CancelButton = (Button)ButEnd;
    }

    private void DataGridViewPeoples_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            int id = ((DataGridView)sender).ToGetIntValue("ColumnPeopleId");
            if (id > 0)
            {
                FrmPeopleUpdateShow(id);
            }
        }
    }

    private void DataGridViewPeoples_KeyDown(object sender, KeyEventArgs e)
    {
        var grid = ((DataGridView)sender);
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            if (grid.CurrentRow is null) return;
            int id = grid.ToGetIntValue("ColumnPeopleId");
            if (id > 0)
            {
                FrmPeopleUpdateShow(id);
            }
        }
    }
}

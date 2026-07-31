using WinForm.DataAccess;
using WinForm.Models;

namespace WinForm
{
    public partial class FrmPeopleUpdate : Form
    {
        internal OracleDataAccess OracleDataAccess { get; }
        protected int Id { get; set; }
        public FrmPeopleUpdate(OracleDataAccess oracleDataAccess, int id = 0)
        {
            InitializeComponent();
            OracleDataAccess = oracleDataAccess;
            Id = id;
        }

        private void ButEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            People people = new People();
            people.Id = Id;
            people.Name = TxtName.Text;
            people.Price = 0;
            people.CreatedAt = DateTime.Now;
            if (decimal.TryParse(TxtPrice.Text, out decimal price))
            {
                people.Price = price;
            }
            if (DateTime.TryParse(TxtCreatedAt.Text, out DateTime createdAt))
            {
                people.CreatedAt = createdAt;
            }
            people.Active = ChkActive.Checked;
            if (Id == 0)
            {
                OracleDataAccess.People.Add(people);
            }
            else
            {
                OracleDataAccess.People.Update(people);
            }
            OracleDataAccess.SaveChanges();
            OracleDataAccess.Entry(people).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            ButEnd.PerformClick();
        }
    }
}

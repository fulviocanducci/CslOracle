using Mask;
using Microsoft.EntityFrameworkCore;
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
            People people = new()
            {
                Id = Id,
                Name = TxtName.Text,
                Price = 0,
                CreatedAt = DateTime.Now
            };
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

        private void FrmPeopleUpdate_Load(object sender, EventArgs e)
        {
            TxtPrice.MaskCurrency();
            if (Id > 0)
            {
                People? people = OracleDataAccess.People.AsNoTracking().FirstOrDefault(o => o.Id == Id);
                if (people != null)
                {
                    TxtName.Text = people.Name;
                    TxtPrice.Text = people.Price.ToString("N2");
                    TxtCreatedAt.Text = people.CreatedAt.ToString("dd/MM/yyyy HH:mm:ss");
                    ChkActive.Checked = people.Active;
                }
            }
        }
    }
}

using FluentValidation.Results;
using Mask;
using WinForm.DataAccess;
using WinForm.Models;
using WinForm.Models.Validations;
using WinForm.Repositories;
namespace WinForm
{
    public partial class FrmPeopleUpdate : Form
    {
        internal RepositoryPeople RepositoryPeople { get; }
        internal PeopleValidation PeopleValidation { get; }
        protected int Id { get; set; }
        public bool Updated { get; private set; }
        public FrmPeopleUpdate(OracleDataAccess oracleDataAccess, int id = 0)
        {
            InitializeComponent();
            RepositoryPeople = new(oracleDataAccess);
            PeopleValidation = new PeopleValidation();
            Id = id;
            Updated = false;
            this.EnterAsTab();
        }

        private void ButEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(TxtPrice.Text, out decimal price)) { }
            if (DateTime.TryParse(TxtCreatedAt.Text, out DateTime createdAt)) { }
            People people = new(Id, TxtName.Text, price, ChkActive.Checked, createdAt);
            ValidationResult validation = PeopleValidation.Validate(people);
            if (validation.IsValid == false)
            {
                MessageCustomBox.Error(validation.Errors.GetErrors());
                TxtName.Focus();
            }
            else
            {
                if (RepositoryPeople.CreateOrUpdate(people))
                {
                    MessageCustomBox.Success("Registro salvo com sucesso!");
                    Updated = true;
                    ButEnd.PerformClick();
                }
                else
                {
                    MessageCustomBox.Error("Falha ao salvar o registro!");
                    Updated = false;
                }
            }
        }
        private void SetControlValues(string name = "", string price = "0,00", string? createdAt = null, bool active = false)
        {
            TxtName.Text = name;
            TxtPrice.Text = price;
            TxtCreatedAt.Text = createdAt ?? DateTime.Now.ToTextDateTime();
            ChkActive.Checked = active;
        }

        private void FrmPeopleUpdate_Load(object sender, EventArgs e)
        {
            TxtPrice.MaskCurrency();
            SetControlValues();
            if (Id > 0)
            {
                People? people = RepositoryPeople.Get(Id);
                if (people != null)
                {
                    SetControlValues(people.Name, people.Price.ToTextDecimal(), people.CreatedAt.ToTextDateTime(), people.Active);
                }
            }
            TxtName.Focus();
        }
    }
}

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
        public FrmPeopleUpdate(OracleDataAccess oracleDataAccess, int id = 0)
        {
            InitializeComponent();
            RepositoryPeople = new(oracleDataAccess);
            PeopleValidation = new PeopleValidation();
            Id = id;
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
                    ButEnd.PerformClick();
                }
                else
                {
                    MessageCustomBox.Error("Falha ao salvar o registro!");
                }
            }
        }

        private void FrmPeopleUpdate_Load(object sender, EventArgs e)
        {
            TxtPrice.MaskCurrency();
            TxtName.Text = string.Empty;
            TxtPrice.Text = "0,00";
            TxtCreatedAt.Text = DateTime.Now.ToTextDateTime();
            ChkActive.Checked = true;
            if (Id > 0)
            {
                People? people = RepositoryPeople.Get(Id);
                if (people != null)
                {
                    TxtName.Text = people.Name;
                    TxtPrice.Text = people.Price.ToTextDecimal();
                    TxtCreatedAt.Text = people.CreatedAt.ToTextDateTime();
                    ChkActive.Checked = people.Active;
                }
            }
            TxtName.Focus();
        }
    }
}

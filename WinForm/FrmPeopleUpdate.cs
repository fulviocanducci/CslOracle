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

        private async void FrmPeopleUpdate_Load(object sender, EventArgs e)
        {
            CancelButton = (Button)ButEnd;
            TxtPrice.MaskCurrency();
            ChkActive.SetLayoutFocus();
            SetControlValues();
            if (Id > 0)
            {
                People? people = await RepositoryPeople.GetAsync(Id);
                if (people != null)
                {
                    SetControlValues(people.Name, people.Price.ToTextDecimal(), people.CreatedAt.ToTextDateTime(), people.Active);
                }
            }
            TxtName.Focus();
        }

        private void ButEnd_OnPressed(object sender, EventArgs e)
        {
            Close();
        }

        private async void ButSave_Click(object sender, EventArgs e)
        {
            if (TxtName.Text.Trim().Length == 0)
            {
                MessageCustomBox.Error("Nome é obrigatório.");
                TxtName.Focus();
                TxtName.SelectAll();
                return;
            }
            if (TxtPrice.TryGetDecimalCurrency(out decimal price) == false)
            {
                MessageCustomBox.Error("Preço deve ser maior ou igual a zero.");
                TxtPrice.Focus();
                return;
            }
            if (TxtCreatedAt.TryGetDateTime(out DateTime createdAt) == false)
            {
                MessageCustomBox.Error("Data de criação inválida.");
                TxtCreatedAt.Focus();
                return;
            }
            People people = new(Id, TxtName.Text.Trim(), price, ChkActive.Checked, createdAt);
            ValidationResult validation = PeopleValidation.Validate(people);
            if (validation.IsValid == false)
            {
                MessageCustomBox.Error(validation.Errors.GetErrors());
                ValidationFailure? first = validation.Errors.FirstOrDefault();
                if (first != null && !string.IsNullOrEmpty(first.PropertyName))
                {
                    if (first.IsValue("Name")) TxtName.Focus();
                    if (first.IsValue("Price")) TxtPrice.Focus();
                    if (first.IsValue("CreatedAt")) TxtCreatedAt.Focus();
                }
                return;
            }
            try
            {
                Cursor = Cursors.WaitCursor;
                ButSave.Toggle();
                if (await RepositoryPeople.CreateOrUpdateAsync(people))
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
            catch (Exception ex)
            {
                MessageCustomBox.Error("Erro ao salvar: " + ex.Message);
                Updated = false;
            }
            finally
            {
                ButSave.Toggle();
                Cursor = Cursors.Default;
            }
        }

        private void SetControlValues(string name = "", string price = "0,00", string? createdAt = null, bool active = false)
        {
            TxtName.Text = name;
            TxtPrice.Text = price;
            TxtCreatedAt.Text = createdAt ?? DateTime.Now.ToTextDateTime();
            ChkActive.Checked = active;
        }


    }
}

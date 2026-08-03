using FluentValidation.Results;
using Mask;
using WinForm.DataAccess;
using WinForm.Models;
using WinForm.Models.Validations;
using WinForm.Repositories;

namespace WinForm;

public abstract class Methods<T> where T : class, new()
{
    public abstract void SetControls(T? p = null);
    public abstract void FocusControl(ValidationResult validation);
    public abstract bool ValidationControls();
}

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
        PeopleValidation = new();
        Id = id;
    }

    private async void FrmPeopleUpdate_Load(object sender, EventArgs e)
    {
        Updated = false;
        this.EnterAsTab();
        CancelButton = (Button)ButEnd;
        TxtPrice.MaskCurrency();
        ChkActive.SetLayoutFocus();
        SetControls();
        if (Id > 0)
        {
            People? people = await RepositoryPeople.GetAsync(Id);
            if (people != null)
            {
                SetControls(people);
            }
        }
        TxtName.Focus();
    }

    #region Events
    private async void ButSave_Click(object sender, EventArgs e)
    {
        Updated = false;
        if (!ValidationControls(out decimal price, out DateTime createdAt))
        {
            return;
        }
        People people = new(Id, TxtName.Text.Trim(), price, ChkActive.Checked, createdAt);
        ValidationResult validation = PeopleValidation.Validate(people);
        if (validation.IsValid == false)
        {
            MessageCustomBox.Error(validation.Errors.GetErrors());
            FocusControl(validation);
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
            }
        }
        catch (Exception)
        {
            MessageCustomBox.Error("Erro ao salvar o registro!");
        }
        finally
        {
            ButSave.Toggle();
            Cursor = Cursors.Default;
        }
    }

    private void ButEnd_OnPressed(object sender, EventArgs e)
    {
        Close();
    }

    #endregion

    #region Methods_Default
    private void SetControls(People? p = null)
    {
        TxtName.Text = p?.Name ?? "";
        TxtPrice.Text = p?.Price.ToTextDecimal() ?? "0,00";
        TxtCreatedAt.Text = p?.CreatedAt.ToTextDateTime() ?? DateTime.Now.ToTextDateTime();
        ChkActive.Checked = p?.Active ?? false;
    }

    private void FocusControl(ValidationResult validation)
    {
        ValidationFailure? first = validation.Errors.FirstOrDefault();
        if (first == null) return;
        switch (first.PropertyName)
        {
            case nameof(People.Name): TxtName.Focus(); break;
            case nameof(People.Price): TxtPrice.Focus(); break;
            case nameof(People.CreatedAt): TxtCreatedAt.Focus(); break;
        }
    }

    private bool ValidationControls(out decimal price, out DateTime createdAt)
    {
        price = 0;
        createdAt = DateTime.MinValue;

        if (TxtName.Text.Trim().Length == 0)
        {
            MessageCustomBox.Error("Nome é obrigatório.");
            TxtName.Focus();
            TxtName.SelectAll();
            return false;
        }
        if (TxtPrice.TryGetDecimalCurrency(out price) == false)
        {
            MessageCustomBox.Error("Preço deve ser maior ou igual a zero.");
            TxtPrice.Focus();
            return false;
        }
        if (TxtCreatedAt.TryGetDateTime(out createdAt) == false)
        {
            MessageCustomBox.Error("Data de criação inválida.");
            TxtCreatedAt.Focus();
            return false;
        }
        return true;
    }
    #endregion
}
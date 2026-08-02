using FluentValidation;
using System.Globalization;
namespace WinForm.Models.Validations
{
    internal class PeopleValidation : AbstractValidator<People>
    {
        public PeopleValidation()
        {
            RuleFor(p => p.Name)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Nome é obrigatório")
                .MaximumLength(100).WithMessage("Nome com 100 caracteres");

            RuleFor(p => p.Price)
                .Cascade(CascadeMode.Stop)
                .GreaterThanOrEqualTo(0).WithMessage("Preço deve ser maior ou igual a zero");

            RuleFor(p => p.CreatedAt)
                .Cascade(CascadeMode.Stop)
                .Must(BeValidateCreatedAt).WithMessage("Data de criação inválida.");
        }

        private bool BeValidateCreatedAt(DateTime time)
        {
            return time >= DateTime.Parse("01/01/1900 00:00:00", CultureInfo.GetCultureInfo("pt-BR"), DateTimeStyles.None);
        }
    }
}

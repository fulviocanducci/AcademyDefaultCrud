using Academy.Models;
using Academy.Validations.Utils;
using FluentValidation;
namespace Academy.Validations
{
    public class StudentValidation : AbstractValidator<Student>
    {
        public StudentValidation()
        {
            RuleFor(x => x.Id)
                .Cascade(CascadeMode.Stop)
                .NotNull()
                .WithMessage("Código inválido");
            RuleFor(x => x.Name)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Nome é obrigatório")
                .MaximumLength(50).WithMessage("Nome com até 50 caracteres")
                .MinimumLength(1).WithMessage("Nome com no minimo 1 caracter");
            RuleFor(x => x.DateBirthday)
                .Cascade(CascadeMode.Stop)
                .Must(ValidationCustom.IsDateTimeOrDefault).WithMessage("Data inválida");
        }
    }
}

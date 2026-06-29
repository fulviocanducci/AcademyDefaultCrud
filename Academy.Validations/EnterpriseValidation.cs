using Academy.Models;
using FluentValidation;
namespace Academy.Validations
{
    public class EnterpriseValidation : AbstractValidator<Enterprise>
    {
        public EnterpriseValidation()
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
        }
    }
}

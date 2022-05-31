using FluentValidation;

namespace TestsGenerator.Domain.AlternativeModule
{
    public class AlternativeValidator : AbstractValidator<Alternative>
    {
        public AlternativeValidator()
        {

            RuleFor(x => x.Letter)
                .NotEmpty()
                .WithMessage("Campo 'Letra' é obrigatório.");


            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("Campo 'Descrição' é obrigatório.");
        }
    }
}
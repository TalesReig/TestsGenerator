using FluentValidation;

namespace TestsGenerator.Domain.DisciplineModule
{
    public class DisciplineValidator : AbstractValidator<Discipline>
    {
        public DisciplineValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Campo 'Nome' é obrigatório.");
        }
    }
}
using FluentValidation;

namespace TestsGenerator.Domain.MateriaModule
{
    public class MateriaValidator : AbstractValidator<Materia>
    {
        public MateriaValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Campo 'Nome' é obrigatório.");

            RuleFor(x => x.Grade)
                .NotEmpty()
                .WithMessage("Campo 'Série' é obrigatório.");

            RuleFor(x => x.Bimester)
                .NotEmpty()
                .WithMessage("Campo 'Bimestre' é obrigatório.");

            RuleFor(x => x.Discipline)
                .NotNull()
                .WithMessage("Campo 'Disciplina é obrigatório.'");
        }
    }
}
using FluentValidation;

namespace TestsGenerator.Domain.TestModule
{
    public class TestValidator : AbstractValidator<Test>
    {
        public TestValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage("Campo 'Título' é obrigatório.");

            RuleFor(x => x.Grade)
                .NotEmpty()
                .WithMessage("Campo 'Série' é obrigatório.");

            RuleFor(x => x.Bimester)
                .NotEmpty()
                .WithMessage("Campo 'Bimestre' é obrigatório.");

            RuleFor(x => x.Discipline)
                .NotEmpty()
                .WithMessage("Campo 'Disciplina' é obrigatório.");

            RuleFor(x => x.Materia)
                .NotEmpty()
                .WithMessage("Campo 'Matéria' é obrigatório.");

            RuleFor(x => x.Questions)
                .Must(list => list.Count < 5)
                .WithMessage("É necessário ter ao menos 5 questões para cadastrar um teste.");
            
        }
    }
}
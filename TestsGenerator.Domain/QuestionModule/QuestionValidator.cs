using FluentValidation;

namespace TestsGenerator.Domain.QuestionModule
{
    public class QuestionValidator : AbstractValidator<Question>
    {
        public QuestionValidator()
        {
            RuleFor(x => x.Discipline)
                .NotNull()
                .WithMessage("Campo 'Disciplina' é obrigatório.");

            RuleFor(x => x.Grade)
                .NotEmpty()
                .WithMessage("Campo 'Série' é obrigatório.");

            RuleFor(x => x.Bimester)
                .NotEmpty()
                .WithMessage("Campo 'Bimestre' é obrigatório.");

            RuleFor(x => x.Materia)
                .NotEmpty()
                .WithMessage("Campo 'Matéria' é obrigatório.");

            RuleFor(x => x.Description)
                .NotEmpty()
                .WithMessage("Campo 'Enunciado' é obrigatório.");
        }
    }
}
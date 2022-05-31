using FluentValidation;
using FluentValidation.Results;
using TestsGenerator.Domain.QuestionModule;
using TestsGenerator.Infra.Shared;

namespace TestsGenerator.Infra.QuestionModule
{
    public class QuestionRepository : BaseRepository<Question>
    {
        public QuestionRepository(DataContext dataContext) : base(dataContext) { }

        public override void UpdateCounter()
        {
            if (_dataContext.Questions.Count > 0)
                counter = _dataContext.Questions.Max(x => x.Id);
        }

        public override List<Question> GetRegisters()
        {
            return _dataContext.Questions;
        }

        public override AbstractValidator<Question> GetValidator()
        {
            return new QuestionValidator();
        }

        public override ValidationResult Update(Question t)
        {
            AbstractValidator<Question> validator = GetValidator();

            ValidationResult validationResult = validator.Validate(t);

            if (validationResult.IsValid == false)
                return validationResult;

            List<Question> registers = GetRegisters();

            bool existsName = registers.Select(x => x.Description).Contains(t.Description, StringComparer.OrdinalIgnoreCase);

            if (existsName && t.Id == 0)
                validationResult.Errors.Add(new ValidationFailure("", "Uma questão com este enunciado já está cadastrada."));

            if (validationResult.IsValid)
            {
                registers.ForEach(x =>
                {
                    if (x.Id == t.Id)
                        x.Update(t);
                });
            }

            return validationResult;
        }
    }
}
using FluentValidation;
using FluentValidation.Results;
using TestsGenerator.Domain.MateriaModule;
using TestsGenerator.Infra.Shared;

namespace TestsGenerator.Infra.MateriaModule
{
    public class MateriaRepository : BaseRepository<Materia>
    {
        public MateriaRepository(DataContext dataContext) : base(dataContext) { }

        public override void UpdateCounter()
        {
            if (_dataContext.Materias.Count > 0)
                counter = _dataContext.Materias.Max(x => x.Id);
        }

        public override List<Materia> GetRegisters()
        {
            return _dataContext.Materias;
        }

        public override AbstractValidator<Materia> GetValidator()
        {
            return new MateriaValidator();
        }

        public override ValidationResult Update(Materia t)
        {
            AbstractValidator<Materia> validator = GetValidator();

            ValidationResult validationResult = validator.Validate(t);

            if (validationResult.IsValid == false)
                return validationResult;

            List<Materia> registers = GetRegisters();

            bool existsName = registers.Select(x => x.Name).Contains(t.Name, StringComparer.OrdinalIgnoreCase);

            if (existsName && t.Id == 0)
                validationResult.Errors.Add(new ValidationFailure("", "Nome já está cadastrado"));

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
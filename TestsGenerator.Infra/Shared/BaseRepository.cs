using FluentValidation;
using FluentValidation.Results;
using TestsGenerator.Domain.Shared;

namespace TestsGenerator.Infra.Shared
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity<T>
    {
        protected DataContext _dataContext;
        protected int counter;

        public BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
            UpdateCounter();
        }

        public abstract void UpdateCounter();

        public abstract List<T> GetRegisters();

        public abstract AbstractValidator<T> GetValidator();

        public virtual ValidationResult Insert(T t)
        {
            AbstractValidator<T> validator = GetValidator();

            ValidationResult validationResult = validator.Validate(t);

            if (validationResult.IsValid)
            {
                t.Id = ++counter;

                List<T> registers = GetRegisters();

                registers.Add(t);
            }

            return validationResult;
        }

        public abstract ValidationResult Update(T t);

        public ValidationResult Delete(T t)
        {
            ValidationResult validationResult = GetValidator().Validate(t);

            if (GetRegisters().Remove(t) == false)
                validationResult.Errors.Add(new ValidationFailure("", "Não foi possível remover o registro."));

            return validationResult;
        }

        public T GetByIndex(int index)
        {
            return GetRegisters().ElementAtOrDefault(index);
        }
    }
}
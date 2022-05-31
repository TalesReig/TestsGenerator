using FluentValidation;
using FluentValidation.Results;
using TestsGenerator.Domain.Shared;

namespace TestsGenerator.Infra.Database.Shared
{
    public interface IRepository<T> where T: BaseEntity<T>
    {
        ValidationResult Insert(T Entity);
        ValidationResult Update(T Entity);
        ValidationResult Delete(T Entity);
        List<T> GetAll();
        AbstractValidator<T> GetValidator();
    }
}
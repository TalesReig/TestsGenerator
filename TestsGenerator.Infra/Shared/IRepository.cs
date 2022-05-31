using FluentValidation.Results;
using TestsGenerator.Domain.Shared;

namespace TestsGenerator.Infra.Shared
{
    public interface IRepository<T> where T : BaseEntity<T>
    { 
        ValidationResult Insert(T t);
        ValidationResult Delete(T t);
        T GetByIndex(int index);
    }
}
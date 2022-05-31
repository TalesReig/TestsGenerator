using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestsGenerator.Domain.TestModule;
using TestsGenerator.Infra.Shared;

namespace TestsGenerator.Infra.TestModule
{
    public class TestRepository : BaseRepository<Test>
    {
        public TestRepository(DataContext dataContext) : base(dataContext) { }

        public override void UpdateCounter()
        {
            if (_dataContext.Tests.Count > 0)
                counter = _dataContext.Tests.Max(x => x.Id);
        }

        public override List<Test> GetRegisters()
        {
            return _dataContext.Tests;
        }

        public override AbstractValidator<Test> GetValidator()
        {
            return new TestValidator();
        }

        public override ValidationResult Update(Test t)
        {
            AbstractValidator<Test> validator = GetValidator();

            ValidationResult validationResult = validator.Validate(t);

            if (validationResult.IsValid == false)
                return validationResult;

            List<Test> registers = GetRegisters();

            bool existsName = registers.Select(x => x.Title).Contains(t.Title, StringComparer.OrdinalIgnoreCase);

            if (existsName && t.Id == 0)
                validationResult.Errors.Add(new ValidationFailure("", "Um teste com este título já está cadastrado."));

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
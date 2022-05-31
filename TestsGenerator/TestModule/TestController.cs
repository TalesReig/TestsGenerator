using TestsGenerator.Domain.TestModule;
using TestsGenerator.Infra.Database.DisciplineModule;
using TestsGenerator.Infra.Database.MateriaModule;
using TestsGenerator.Infra.Database.QuestionModule;
using TestsGenerator.Infra.TestModule;
using TestsGenerator.Shared;

namespace TestsGenerator.TestModule
{
    public class TestController : BaseController
    {
        private readonly TestRepository _testRepository;
        private readonly QuestionRepository _questionRepository;
        private readonly MateriaRepository _materiaRepository;
        private readonly DisciplineRepository _disciplineRepository;

        private readonly TestControl testControl;

        public TestController(TestRepository testRepository, QuestionRepository questionRepository, MateriaRepository materiaRepository, DisciplineRepository disciplineRepository)
        {
            _testRepository = testRepository;
            _questionRepository = questionRepository;
            _materiaRepository = materiaRepository;
            _disciplineRepository = disciplineRepository;
            testControl = new(this);
        }

        public override void Insert()
        {
            RegisterTestForm screen = new(_disciplineRepository.GetAll(), _materiaRepository.GetAll(), _questionRepository.GetAll());

            screen.Test = new();
            screen.SaveRecord = _testRepository.Insert;

            DialogResult dialogResult = screen.ShowDialog();

            if (dialogResult == DialogResult.OK)
                LoadTests();
        }

        // to-do?
        public override void Update() { }

        public override void Delete()
        {
            Test selectedTest = GetTest();

            if (selectedTest == null)
            {
                MessageBox.Show("Selecione um teste primeiro.", "Exclusão de Teste", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Deseja realmente excluir este registro?", "Exclusão de Teste", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                _testRepository.Delete(selectedTest);
                LoadTests();
            }
        }

        public override UserControl GetControl()
        {
            LoadTests();

            return testControl;
        }

        public void GeneratePdf()
        {
            Test selectedTest = GetTest();

            if (selectedTest == null)
            {
                MessageBox.Show("Selecione um teste primeiro.", "Gerar PDF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GeneratePdfForm screen = new(selectedTest);

            DialogResult dialogResult = screen.ShowDialog();

            if (dialogResult == DialogResult.OK)
                LoadTests();
        }

        public void Duplicate()
        {
            Test selectedTest = GetTest();

            if (selectedTest == null)
            {
                MessageBox.Show("Selecione um teste primeiro.", "Duplicar Teste", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // to-do
        }

        private void LoadTests()
        {
            List<Test> tests = _testRepository.GetRegisters();

            testControl.UpdateGrid(tests);
        }

        public Test GetTest()
        {
            if (testControl.GetGrid().CurrentCell != null && testControl.GetGrid().CurrentCell.Selected == true)
            {
                int index = testControl.GetSelectedRow();
                return _testRepository.GetByIndex(index);
            }

            return null;
        }
    }
}
using TestsGenerator.Domain.TestModule;

namespace TestsGenerator.TestModule
{
    public partial class TestControl : UserControl
    {
        private readonly TestController _testController;

        public TestControl(TestController testController)
        {
            InitializeComponent();

            _testController = testController;
        }

        public void UpdateGrid(List<Test> tests)
        {
            GridTests.Rows.Clear();

            tests.ForEach(test =>
            {
                GridTests.Rows.Add(
                    test.Id,
                    test.Title,
                    test.Grade,
                    test.Bimester,
                    test.Materia.Name,
                    test.Discipline.Name);
            });

            GridTests.ClearSelection();
        }

        public int GetSelectedRow()
        {
            return GridTests.CurrentCell.RowIndex;
        }

        public DataGridView GetGrid()
        {
            return GridTests;
        }

        private void BtnRegisterTest_Click(object sender, EventArgs e)
        {
            _testController.Insert();
        }

        private void BtnDeleteTest_Click(object sender, EventArgs e)
        {
            _testController.Delete();
        }

        private void BtnGeneratePDF_Click(object sender, EventArgs e)
        {
            _testController.GeneratePdf();
        }

        private void BtnDuplicate_Click(object sender, EventArgs e)
        {
            _testController.Duplicate();
        }
    }
}
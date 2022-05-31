using TestsGenerator.Domain.DisciplineModule;

namespace TestsGenerator.DisciplineModule
{
    public partial class DisciplineControl : UserControl
    {
        private readonly DisciplineController _disciplineController;

        public DisciplineControl(DisciplineController disciplineController)
        {
            InitializeComponent();

            _disciplineController = disciplineController;
        }

        public void UpdateGrid(List<Discipline> disciplines)
        {
            GridDisciplines.Rows.Clear();

            disciplines.ForEach(discipline =>
            {
                GridDisciplines.Rows.Add(
                    discipline.Id,
                    discipline.Name);
            });

            GridDisciplines.ClearSelection();
        }

        public int GetSelectedRow()
        {
            return GridDisciplines.CurrentCell.RowIndex;
        }

        public DataGridView GetGrid()
        {
            return GridDisciplines;
        }

        private void DisciplineControl_Load(object sender, EventArgs e)
        {
            GridDisciplines.ClearSelection();
        }

        private void BtnRegisterDiscipline_Click(object sender, EventArgs e)
        {
            _disciplineController.Insert();
        }

        private void BtnEditDiscipline_Click(object sender, EventArgs e)
        {
            _disciplineController.Update();
        }

        private void BtnDeleteDiscipline_Click(object sender, EventArgs e)
        {
       
            _disciplineController.Delete();
        }
    }
}
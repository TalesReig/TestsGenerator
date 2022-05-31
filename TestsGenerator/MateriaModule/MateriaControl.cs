using TestsGenerator.Domain.MateriaModule;

namespace TestsGenerator.MateriaModule
{
    public partial class MateriaControl : UserControl
    {
        private readonly MateriaController _materiaController;

        public MateriaControl(MateriaController materiaController)
        {
            InitializeComponent();

            _materiaController = materiaController;
        }

        public void UpdateGrid(List<Materia> materias)
        {
            GridMaterias.Rows.Clear();

            materias.ForEach(materia =>
            {
                GridMaterias.Rows.Add(
                    materia.Id,
                    materia.Name,
                    materia.Grade,
                    materia.Bimester,
                    materia.Discipline.Name);
            });

            GridMaterias.ClearSelection();
        }

        public int GetSelectedRow()
        {
            return GridMaterias.CurrentCell.RowIndex;
        }

        public DataGridView GetGrid()
        {
            return GridMaterias;
        }

        private void MateriaControl_Load(object sender, EventArgs e)
        {
            GridMaterias.ClearSelection();
        }

        private void BtnRegisterMateria_Click(object sender, EventArgs e)
        {
            _materiaController.Insert();
        }

        private void BtnEditMateria_Click(object sender, EventArgs e)
        {
            _materiaController.Update();
        }

        private void BtnDeleteMateria_Click(object sender, EventArgs e)
        {
            _materiaController.Delete();
        }
    }
}
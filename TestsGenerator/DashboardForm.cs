using TestsGenerator.DisciplineModule;
using TestsGenerator.Infra.Database.DisciplineModule;
using TestsGenerator.Infra.Database.MateriaModule;
using TestsGenerator.Infra.Database.QuestionModule;
using TestsGenerator.Infra.Shared;
using TestsGenerator.Infra.TestModule;
using TestsGenerator.MateriaModule;
using TestsGenerator.QuestionModule;
using TestsGenerator.Shared;
using TestsGenerator.TestModule;

namespace TestsGenerator
{
    public partial class DashboardForm : Form
    {
        private BaseController controller;
        private readonly Dictionary<string, BaseController> controllers;
        private readonly DataContext _dataContext;

        public DashboardForm(DataContext dataContext)
        {
            InitializeComponent();

            _dataContext = dataContext;

            TestRepository testRepository = new(_dataContext);
            QuestionRepository questionRepository = new(testRepository);
            MateriaRepository materiaRepository = new();
            DisciplineRepository disciplineRepository = new();

            controllers = new Dictionary<string, BaseController>
            {
                { "Disciplinas", new DisciplineController(disciplineRepository, materiaRepository) },
                { "Matérias", new MateriaController(materiaRepository, disciplineRepository) },
                { "Questões", new QuestionController(questionRepository, materiaRepository, disciplineRepository) },
                { "Testes", new TestController(testRepository, questionRepository, materiaRepository, disciplineRepository) }
            };
        }

        private void ShowControl(Button selectedControl)
        {
            if (PanelContent.Controls.Count > 0)
                PanelContent.Controls.Clear();

            if (selectedControl.Text == "Dashboard")
            {
                PanelContent.Controls.Add(PnlGreetings);
                PanelContent.Tag = PnlGreetings;

                PnlGreetings.Show();
                return;
            }

            controller = controllers[selectedControl.Text];

            UserControl control = controller.GetControl();

            control.Dock = DockStyle.Fill;

            PanelContent.Controls.Add(control);
            PanelContent.Tag = control;

            control.Show();
        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _dataContext.Save();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            ShowControl(BtnDashboard); 
        }

        private void BtnTests_Click(object sender, EventArgs e)
        {
            ShowControl(BtnTests);
        }

        private void BtnQuestions_Click(object sender, EventArgs e)
        {
            ShowControl(BtnQuestions);
        }

        private void BtnDisciplines_Click(object sender, EventArgs e)
        {
            ShowControl(BtnDisciplines);
        }

        private void BtnMaterias_Click(object sender, EventArgs e)
        {
            ShowControl(BtnMaterias);
        }
    }
}
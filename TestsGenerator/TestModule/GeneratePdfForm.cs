using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using TestsGenerator.Domain.QuestionModule;
using TestsGenerator.Domain.TestModule;

namespace TestsGenerator.TestModule
{
    public partial class GeneratePdfForm : Form
    {

        private readonly Test _test;

        public GeneratePdfForm(Test test)
        {
            InitializeComponent();

            _test = test;
        }

        private void GenerateTest()
        {
            PdfWriter writer = new(TxbPath.Text + "/" + _test.Id + ".pdf");
            PdfDocument pdf = new(writer);
            Document document = new(pdf);

            document.Add(new LineSeparator(new SolidLine(1f)));
            document.Add(new Paragraph(""));

            Paragraph info = new Paragraph("• Aluno:")
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(13);

            info.Add($"\n• Série: {_test.Grade}");
            info.Add($"\n• Bimestre: {_test.Bimester}");
            info.Add($"\n• Matéria: {_test.Materia.Name}");

            document.Add(info);
            document.Add(new Paragraph(""));
            document.Add(new LineSeparator(new SolidLine(1f)));
            document.Add(new Paragraph("\n"));

            Paragraph title = new Paragraph(_test.Title)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(21)
                .SetBold();

            document.Add(title);
            document.Add(new Paragraph("\n"));

            int i = 1;
            _test.Questions.ForEach(x =>
            {
                Paragraph question = new Paragraph($"{i}) {x.Description}")
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontSize(11)
                    .SetBold();

                document.Add(question);

                i++;

                x.Alternatives.ForEach(y =>
                {
                    Paragraph alternative = new Paragraph(y.ToString())
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(9);

                    document.Add(alternative);
                });

                document.Add(new Paragraph("\n"));

            });

            document.Close();
        }

        private void GenerateGabarito()
        {
            PdfWriter writer = new(TxbPath.Text + "/" + _test.Id + "_gabarito" + ".pdf");
            PdfDocument pdf = new(writer);
            Document document = new(pdf);

            Paragraph header = new Paragraph("Gabarito do teste:")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(21);

            Paragraph subheader = new Paragraph(_test.Title)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(18)
                .SetBold();

            document.Add(header);
            document.Add(subheader);

            document.Add(new LineSeparator(new SolidLine(1f)));
            document.Add(new Paragraph(""));

            int i = 1;
            _test.Questions.ForEach(x =>
            {
                Paragraph question = new Paragraph($"{i}) ")
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontSize(11)
                    .SetBold();

                x.Alternatives.Where(x => x.IsCorrect == true).ToList().ForEach(y => question.Add(new Text(y.ToString())));

                document.Add(question);

                i++;
            });

            document.Add(new Paragraph(""));
            document.Add(new LineSeparator(new SolidLine(1f)));

            document.Close();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            GenerateTest();
            GenerateGabarito();

            MessageBox.Show("PDF gerado com sucesso!", "Gerar PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new();

            if (folder.ShowDialog() == DialogResult.OK)
                TxbPath.Text = folder.SelectedPath;
        }
    }
}
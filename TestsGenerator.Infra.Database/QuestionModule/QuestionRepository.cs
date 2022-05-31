using FluentValidation;
using FluentValidation.Results;
using System.Data.SqlClient;
using TestsGenerator.Domain.AlternativeModule;
using TestsGenerator.Domain.DisciplineModule;
using TestsGenerator.Domain.QuestionModule;
using TestsGenerator.Domain.Shared;
using TestsGenerator.Infra.Database.Shared;
using TestsGenerator.Infra.TestModule;

namespace TestsGenerator.Infra.Database.QuestionModule
{
    public class QuestionRepository : IRepository<Question>
    {
        private const string connectionString = "Data Source=(LocalDB)\\MSSqlLocalDB;Initial Catalog=TestesDb;Integrated Security=True;Pooling=False";

        private SqlConnection? conn = null;

        private readonly TestRepository _testRepository;

        public QuestionRepository(TestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        public ValidationResult Insert(Question question)
        {
            ValidationResult validationResult = GetValidator().Validate(question);

            if (validationResult.IsValid == false)
                return validationResult;

            using (conn = new(connectionString))
            {
                string query =
                    @"INSERT INTO [TBQUESTIONS]
                        (
                            [DESCRICAO],
                            [SERIE],
                            [BIMESTRE],
                            [MATERIA_ID]
                        )
                        
                        VALUES
            
                        (
                            @DESCRICAO,
                            @SERIE,
                            @BIMESTRE,
                            @MATERIA_ID
                        )
                        
                        SELECT SCOPE_IDENTITY()";

                using SqlCommand command = new(query, conn);

                conn.Open();

                command.Parameters.AddWithValue("DESCRICAO", question.Description);
                command.Parameters.AddWithValue("SERIE", question.Grade);
                command.Parameters.AddWithValue("BIMESTRE", question.Bimester);
                command.Parameters.AddWithValue("MATERIA_ID", question.Materia.Id);

                question.Id = Convert.ToInt32(command.ExecuteScalar());

                return validationResult;
            }
        }

        public ValidationResult Update(Question question)
        {
            ValidationResult validationResult = GetValidator().Validate(question);

            if (validationResult.IsValid == false)
                return validationResult;

            using (conn = new(connectionString))
            {
                string query =
                    @"UPDATE [TBQUESTAO]
                        SET
                            [DESCRICAO] = @DESCRICAO,
                            [SERIE] = @SERIE,
                            [BIMESTRE] = @BIMESTRE,
                            [MATERIA_ID] = @MATERIA_ID
                        WHERE
                            [ID] = @ID";

                using SqlCommand command = new(query, conn);

                conn.Open();

                command.Parameters.AddWithValue("ID", question.Id);
                command.Parameters.AddWithValue("DESCRICAO", question.Description);
                command.Parameters.AddWithValue("SERIE", question.Grade);
                command.Parameters.AddWithValue("BIMESTRE", question.Bimester);
                command.Parameters.AddWithValue("MATERIA_ID", question.Materia.Id);

                command.ExecuteNonQuery();

                return validationResult;
            }
        }

        public ValidationResult Delete(Question question)
        {
            using (conn = new(connectionString))
            {
                string query = @"DELETE FROM [TBQUESTIONS] WHERE [ID] = @ID";

                using SqlCommand command = new(query, conn);

                conn.Open();

                command.Parameters.AddWithValue("ID", question.Id);

                ValidationResult validationResult = new();

                _testRepository.GetRegisters().Select(x => x.Questions).ToList().ForEach(x =>
                {
                    if (x.Contains(question))
                        validationResult.Errors.Add(new ValidationFailure("", "Não é possível remover esta questão, pois ela está relacionada a um teste."));
                });

                question.Alternatives.ForEach(x => DeleteAlternative(x));
                question.Alternatives.Clear();
                command.ExecuteNonQuery();

                return validationResult;
            }
        }

        public List<Question> GetAll()
        {
            using (conn = new(connectionString))
            {
                string sqlSelecionarTodos =
                    @"SELECT
	                        QT.ID,
	                        QT.DESCRICAO,
	                        QT.SERIE,
	                        QT.BIMESTRE,
	                        QT.MATERIA_NUMERO,

	                        MT.NOME MATERIA_NOME,
	                        MT.SERIE MATERIA_SERIE,
	                        MT.BIMESTRE MATERIA_BIMESTRE,

	                        D.ID DISCIPLINA_NUMERO,
	                        D.NAME DISCIPLINA_NOME

                        FROM [TBQUESTAO] QT 

	                        INNER JOIN 
	                        [TBMATERIA] MT 

                        ON 
	                        QT.MATERIA_ID = MT.ID 

	                        INNER JOIN 
	                        [TBDISCIPLINA] D 

                        ON 
	                        MT.DISCIPLINA_NUMERO = D.ID";

                using SqlCommand command = new(sqlSelecionarTodos, conn);

                conn.Open();

                using SqlDataReader reader = command.ExecuteReader();

                List<Question> questions = new();

                while (reader.Read())
                {
                    Discipline discipline = new()
                    {
                        Id = Convert.ToInt32(reader["DISCIPLINA_NUMERO"]),
                        Name = Convert.ToString(reader["DISCIPLINA_NOME"])
                    };

                    Question question = new()
                    {
                        Id = Convert.ToInt32(reader["ID"]),
                        Description = Convert.ToString(reader["DESCRICAO"]),
                        Grade = Convert.ToString(reader["SERIE"]),
                        Bimester = (Bimester)reader["BIMESTRE"],
                        Discipline = discipline,

                        Materia = new()
                        {
                            Id = Convert.ToInt32(reader["MATERIA_ID"]),
                            Name = Convert.ToString(reader["MATERIA_NAME"]),
                            Grade = Convert.ToString(reader["MATERIA_SERIE"]),
                            Bimester = (Bimester)reader["MATERIA_BIMESTRE"],
                            Discipline = discipline
                        }
                    };

                    questions.Add(question);

                    LoadQuestionAlternatives(question);
                }

                return questions;
            }
        }

        public AbstractValidator<Question> GetValidator()
        {
            return new QuestionValidator();
        }

        private void LoadQuestionAlternatives(Question question)
        {
            using (conn = new(connectionString))
            {
                string query =
                    @"SELECT 
	                        [ID],
	                        [LETRA],
	                        [ISCORRECT],
                            [DESCRICAO],
	                        [QUESTAO_NUMERO]
                        FROM 
	                        [TBQUESTIONSALTERNATIVES]
                        WHERE
	                        [QUESTAO_NUMERO] = @QUESTAO_NUMERO";

                using SqlCommand command = new(query, conn);

                command.Parameters.AddWithValue("QUESTAO_NUMERO", question.Id);

                conn.Open();

                using SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Alternative alternative = new()
                    {
                        Id = Convert.ToInt32(reader["ID"]),
                        Letter = Convert.ToString(reader["LETRA"]),
                        IsCorrect = Convert.ToBoolean(reader["ISCORRECT"]),
                        Description = Convert.ToString(reader["DESCRICAO"])
                    };

                    question.AddAlternative(alternative);
                }
            }
        }

        public void AddAlternatives(Question question, List<Alternative> alternatives)
        {
            using (conn = new(connectionString))
            {
                conn.Open();

                string query =
                    @"INSERT INTO TBQUESTIONSALTERNATIVES
                        (
                            [LETRA],
                            [ISCORRECT],
                            [DESCRICAO],
                            [QUESTAO_NUMERO]
                        )
                        
                        VALUES
                
                        (
                            @LETRA,
                            @ISCORRECT,
                            @DESCRICAO,
                            @QUESTAO_NUMERO
                        )
                        
                        SELECT SCOPE_IDENTITY()";

                foreach (Alternative alternative in alternatives)
                {
                    if (alternative.Id > 0)
                        continue;

                    question.AddAlternative(alternative);

                    using SqlCommand command = new(query, conn);

                    command.Parameters.AddWithValue("LETRA", alternative.Letter);
                    command.Parameters.AddWithValue("ISCORRECT", alternative.IsCorrect);
                    command.Parameters.AddWithValue("DESCRICAO", alternative.Description);
                    command.Parameters.AddWithValue("QUESTAO_NUMERO", alternative.Question.Id);

                    alternative.Id = Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public void UpdateAlternative(Alternative alternative)
        {
            using (conn = new(connectionString))
            {
                string query =
                    @"UPDATE [TBQUESTIONSALTERNATIVES]
                        SET
                            [LETRA] = @LETRA,
                            [ISCORRECT] = @ISCORRECT,
                            [DESCRICAO] = @DESCRICAO,
                            [QUESTAO_NUMERO] = @QUESTAO_NUMERO
                        WHERE
                            [ID] = @ID";

                using SqlCommand command = new(query, conn);

                conn.Open();

                command.Parameters.AddWithValue("ID", alternative.Id);
                command.Parameters.AddWithValue("LETRA", alternative.Letter);
                command.Parameters.AddWithValue("ISCORRECT", alternative.IsCorrect);
                command.Parameters.AddWithValue("DESCRICAO", alternative.Description);
                command.Parameters.AddWithValue("QUESTAO_NUMERO", alternative.Question.Id);

                command.ExecuteNonQuery();
            }
        }

        public void DeleteAlternative(Alternative alternative)
        {
            using (conn = new(connectionString))
            {
                string query = @"DELETE FROM [TBQUESTIONSALTERNATIVES] WHERE [ID] = @ID";

                using SqlCommand command = new(query, conn);

                conn.Open();

                command.Parameters.AddWithValue("ID", alternative.Id);

                command.ExecuteNonQuery();
            }
        }
    }
}
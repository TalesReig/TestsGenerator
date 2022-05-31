using FluentValidation;
using FluentValidation.Results;
using System.Data.SqlClient;
using TestsGenerator.Domain.DisciplineModule;
using TestsGenerator.Domain.MateriaModule;
using TestsGenerator.Domain.Shared;
using TestsGenerator.Infra.Database.QuestionModule;
using TestsGenerator.Infra.Database.Shared;

namespace TestsGenerator.Infra.Database.MateriaModule
{
    public class MateriaRepository : IRepository<Materia>
    {
        private const string enderecoBanco = "Data Source=(LocalDB)\\MSSqlLocalDB;Initial Catalog=TestesDb;Integrated Security=True;Pooling=False";

        private const string sqlInserir =
        @"INSERT INTO [TBMATERIA]
                (
                    [NOME],
                    [SERIE],
                    [BIMESTRE],
                    [DISCIPLINA_NUMERO]
                )
                VALUES
                (
                    @NOME,
                    @SERIE,
                    @BIMESTRE,
                    @DISCIPLINA_NUMERO
                )";

        private const string sqlEditar =
        @"UPDATE [TBMATERIA]
                SET
                    [NOME] = @NOME,
                    [SERIE] = @SERIE,
                    [BIMESTRE] = @BIMESTRE,
                    [DISCIPLINA_NUMERO] = @DISCIPLINA_NUMERO
                WHERE 
                    [ID] = @ID";

        private const string sqlExcluir = @"DELETE FROM [TBMATERIA] WHERE [ID] = @ID";

        private const string sqlSelecionarTodos =
        @"SELECT
	            MT.ID,
	            MT.NOME,
	            MT.SERIE,
                MT.BIMESTRE,
	            MT.DISCIPLINA_NUMERO,
	            D.NOME AS DISCIPLINA_NOME

                FROM 
	            [TBMATERIA] AS MT INNER JOIN
	            [TBDISCIPLINA] AS D ON MT.DISCIPLINA_NUMERO = D.ID";

        private const string sqlSelecionarPorID =
        @"SELECT
	                MT.ID,
	                MT.NOME,
	                MT.SERIE,
                    MT.BIMESTRE,
	                MT.DISCIPLINA_NUMERO,
	                D.NOME AS DISCIPLINA_NOME

                    FROM 
	                [TBMATERIA] AS MT INNER JOIN
	                [TBDISCIPLINA] AS D ON MT.DISCIPLINA_NUMERO = D.ID

                    WHERE
                    MT.ID = @ID";

        public ValidationResult Insert(Materia Entity)
        {
            //validação
            //var validaor = MateriaValidator();

            //var resultadoValidacao = validaor.Validate(Entity);

            //if (resultadoValidacao.IsValid == false)
            //    return resultadoValidacao;

            //abre a conexão com o banco
            SqlConnection conexao = new SqlConnection(enderecoBanco);
            conexao.Open();

            //cria o comando de inserção usando os parametros:
            //string de inserção(comand text e o endereço do banco )
            SqlCommand comandoInsercao = new SqlCommand(sqlInserir, conexao);
            ConfigurarParametros(Entity, comandoInsercao);


            //executa o comando de inserção
            var id = comandoInsercao.ExecuteScalar();//retorna o valor da coluna id
            Entity.Id = Convert.ToInt32(id);

            //fecha a conexão
            conexao.Close();

            return new ValidationResult();
        }

        public ValidationResult Update(Materia Entity)
        {
            //validação
            var validaor = new MateriaValidator();

            var resultadoValidacao = validaor.Validate(Entity);

            if (resultadoValidacao.IsValid == false)
                return resultadoValidacao;

            //abre a conexão com o banco
            SqlConnection conexao = new SqlConnection(enderecoBanco);
            conexao.Open();

            //cria o comando de edição usando os parametros:
            //string de edição(comand text e o endereço do banco )
            SqlCommand comandoEdicao = new SqlCommand(sqlEditar, conexao);
            ConfigurarParametros(Entity, comandoEdicao);

            //executa o comando de inserção
            comandoEdicao.ExecuteNonQuery();//retorna a qnt de linhas editadas

            //fecha a conexão
            conexao.Close();

            return resultadoValidacao;
        }

        public ValidationResult Delete(Materia Entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Materia Entity)
        {
            throw new NotImplementedException();
        }

        public List<Materia> GetAll()
        {
            //abre a conexão com o banco
            SqlConnection conexao = new SqlConnection(enderecoBanco);
            conexao.Open();

            //cria o comando de selecionar todos usando os parametros:
            //string de selecionar todos(comand text e o endereço do banco )
            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarTodos, conexao);

            SqlDataReader leitorDisciplina = comandoSelecao.ExecuteReader();//retorna as informações do banco linha a linha(utilizando o método read);

            List<Materia> materias = new List<Materia>();
            while (leitorDisciplina.Read())//vai retornar falso quando a linha estiver vazia
            {
                Materia materia = ConverterParaMateria(leitorDisciplina);

                materias.Add(materia);
            }

            conexao.Close();
            return materias;
        }

        public Materia? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Materia? GetByIndex(int index)
        {
            //abre a conexão com o banco
            SqlConnection conexao = new SqlConnection(enderecoBanco);
            conexao.Open();

            //cria o comando de selecionar por ID usando os parametros:
            //string de selecionar por ID(comand text e o endereço do banco )
            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarPorID, conexao);
            comandoSelecao.Parameters.AddWithValue("ID", index); //passando o parâmetro que o método usa

            SqlDataReader leitorDisciplina = comandoSelecao.ExecuteReader();//retorna as informações do banco linha a linha(utilizando o método read);

            Materia materia = null;

            if (leitorDisciplina.Read())
            {
                materia = ConverterParaMateria(leitorDisciplina);
            }

            conexao.Close();

            return materia;
        }

        public AbstractValidator<Materia> GetValidator()
        {
            throw new NotImplementedException();
        }
        private static void ConfigurarParametros(Materia Entity, SqlCommand comandoEdicao)
        {
            comandoEdicao.Parameters.AddWithValue("ID", Entity.Id);
            comandoEdicao.Parameters.AddWithValue("DISCIPLINA_NUMERO", Entity.Discipline.Id);
            comandoEdicao.Parameters.AddWithValue("NOME", Entity.Name);
            comandoEdicao.Parameters.AddWithValue("SERIE", Entity.Grade);
            comandoEdicao.Parameters.AddWithValue("BIMESTRE", Entity.Bimester);
            comandoEdicao.Parameters.AddWithValue("DISCIPLINA_NOME", Entity.Discipline.Name);
        }
        private static Materia ConverterParaMateria(SqlDataReader reader)
        {
            var Id = Convert.ToInt32(reader["ID"]);
            var Name = Convert.ToString(reader["NOME"]);
            var Grade = Convert.ToString(reader["SERIE"]);
            var Bimester = (Bimester)(reader["BIMESTRE"]);

            int IdDisciplina = Convert.ToInt32(reader["DISCIPLINA_NUMERO"]);
            string NomeDisciplina = Convert.ToString(reader["DISCIPLINA_NOME"]);

            var materia = new Materia
            {
                Id = Id,
                Name = Name,
                Grade = Grade,
                Bimester = (Bimester)Bimester,
                Discipline = new Discipline //objeto discipline contido em matéria
                {
                    Id = IdDisciplina,
                    Name = NomeDisciplina,
                }
            };//tudo dentro dessas chaves pertencem a materia instânciada

            return materia;
        }

    }
}
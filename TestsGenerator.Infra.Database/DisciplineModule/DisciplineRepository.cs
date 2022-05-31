using FluentValidation;
using FluentValidation.Results;
using System.Data.SqlClient;
using TestsGenerator.Domain.DisciplineModule;
using TestsGenerator.Infra.Database.MateriaModule;
using TestsGenerator.Infra.Database.Shared;

namespace TestsGenerator.Infra.Database.DisciplineModule
{
    public class DisciplineRepository : IRepository<Discipline>
    {
        private const string enderecoBanco = "Data Source=(LocalDB)\\MSSqlLocalDB;Initial Catalog=TestesDb;Integrated Security=True;Pooling=False";

        private const string sqlInserir =
            @"INSERT INTO [TBDISCIPLINA]
                (
                    [NOME]
                )
                VALUES
                (
                    @NOME
                )";

        private const string sqlEditar =
            @"UPDATE [TBDISCIPLINA]
                SET
                    [NOME] = @NOME
                WHERE
                    [ID] = @ID";

        private const string sqlExcluir =
            @"DELETE FROM [TBDISCIPLINA]
                WHERE
                    [ID] = @ID";

        private const string sqlSelecionarTodos =
            @"SELECT
                    [ID],
                    [NOME]
                FROM
                    [TBDISCIPLINA]";

        private const string sqlSelecionarPorID =
            @"SELECT
                    [ID],
                    [NOME]
                FROM
                    [TBDISCIPLINA]
                WHERE
                    [ID] = @ID";

        public ValidationResult Insert(Discipline Entity)
        {
            //validação
            var validaor = new DisciplineValidator();

            var resultadoValidacao = validaor.Validate(Entity);

            if (resultadoValidacao.IsValid == false)
                return resultadoValidacao;

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

            return resultadoValidacao;
        }

        public ValidationResult Update(Discipline Entity)
        {
            //validação
            var validaor = new DisciplineValidator();

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

        public ValidationResult Delete(Discipline Entity)
        {
            //abre a conexão com o banco
            SqlConnection conexao = new SqlConnection(enderecoBanco);
            conexao.Open();

            //cria o comando de exclusão usando os parametros:
            //string de exclusão(comand text e o endereço do banco )
            SqlCommand comandoExclusao = new SqlCommand(sqlExcluir, conexao);
            comandoExclusao.Parameters.AddWithValue("ID", Entity.Id); //passando o parâmetro que o método usa

            //executa o comando de inserção
            int numeroRegistroExcluidos = comandoExclusao.ExecuteNonQuery();//retorna a qnt de linhas editadas

            //validação da exclusão
            var resultadovalidacao = new ValidationResult();
            if (numeroRegistroExcluidos == 0)
            {
                resultadovalidacao.Errors.Add(new ValidationFailure("", "Não foi possível excluir o resgistro"));
            }

            //fecha a conexão
            conexao.Close();

            return resultadovalidacao;
        }

        public bool Exists(Discipline Entity)
        {
            throw new NotImplementedException();
        }

        public List<Discipline> GetAll()
        {
            //abre a conexão com o banco
            SqlConnection conexao = new SqlConnection(enderecoBanco);
            conexao.Open();

            //cria o comando de selecionar todos usando os parametros:
            //string de selecionar todos(comand text e o endereço do banco )
            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarTodos, conexao);

            SqlDataReader leitorDisciplina = comandoSelecao.ExecuteReader();//retorna as informações do banco linha a linha(utilizando o método read);

            List<Discipline> disciplines = new List<Discipline>();
            while (leitorDisciplina.Read())//vai retornar falso quando a linha estiver vazia
            {
                Discipline discipline = ConverterParaDisciplina(leitorDisciplina);

                disciplines.Add(discipline);
            }

            conexao.Close();
            return disciplines;
        }

        public Discipline? GetById(int id)
        {
            //abre a conexão com o banco
            SqlConnection conexao = new SqlConnection(enderecoBanco);
            conexao.Open();

            //cria o comando de selecionar por ID usando os parametros:
            //string de selecionar por ID(comand text e o endereço do banco )
            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarPorID, conexao);
            comandoSelecao.Parameters.AddWithValue("ID", id); //passando o parâmetro que o método usa

            SqlDataReader leitorDisciplina = comandoSelecao.ExecuteReader();//retorna as informações do banco linha a linha(utilizando o método read);

            Discipline discipline = null;

            if (leitorDisciplina.Read())
            {
                discipline = ConverterParaDisciplina(leitorDisciplina);
            }

            conexao.Close();

            return discipline;
        }

        public Discipline? GetByIndex(int index)
        {
            //abre a conexão com o banco
            SqlConnection conexao = new SqlConnection(enderecoBanco);
            conexao.Open();

            //cria o comando de selecionar por ID usando os parametros:
            //string de selecionar por ID(comand text e o endereço do banco )
            SqlCommand comandoSelecao = new SqlCommand(sqlSelecionarPorID, conexao);
            comandoSelecao.Parameters.AddWithValue("ID", index); //passando o parâmetro que o método usa

            SqlDataReader leitorDisciplina = comandoSelecao.ExecuteReader();//retorna as informações do banco linha a linha(utilizando o método read);

            Discipline discipline = null;

            if (leitorDisciplina.Read())
            {
                discipline = ConverterParaDisciplina(leitorDisciplina);
            }

            conexao.Close();

            return discipline;
        }

        public AbstractValidator<Discipline> GetValidator()
        {
            throw new NotImplementedException();
        }

        private static void ConfigurarParametros(Discipline Entity, SqlCommand comandoInsercao)
        {
            comandoInsercao.Parameters.AddWithValue("ID", Entity.Id);
            comandoInsercao.Parameters.AddWithValue("NOME", Entity.Name);
        }

        private static Discipline ConverterParaDisciplina(SqlDataReader leitorContato)
        {
            int id = Convert.ToInt32(leitorContato["ID"]);
            string nome = Convert.ToString(leitorContato["NOME"]);

            var disciplina = new Discipline
            {
                Id = id,
                Name = nome,
            };

            return disciplina;
        }

    }
}
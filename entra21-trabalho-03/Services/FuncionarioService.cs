using entra21_trabalho_03.Database;
using entra21_trabalho_03.Models;
using System.Data;

namespace entra21_trabalho_03.Services
{
    internal class FuncionarioService : IFuncionarioService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM funcionarios WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Funcionario funcionario)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"INSERT INTO funcionarios (id_profissao, nome, cpf, data_nascimento, cep, endereco, numero, data_admissao, salario)
VALUES (@ID_PROFISSAO, @NOME, @CPF, @DATA_NASCIMENTO, @CEP, @ENDERECO, @NUMERO, @DATA_ADMISSAO, @SALARIO)";
            comando.Parameters.AddWithValue("ID_PROFISSAO", funcionario.Profissao.Id);
            comando.Parameters.AddWithValue("@NOME", funcionario.NomeCompleto);
            comando.Parameters.AddWithValue("@CPF", funcionario.Cpf);
            comando.Parameters.AddWithValue("@DATA_NASCIMENTO", funcionario.DataNascimento);
            comando.Parameters.AddWithValue("@CEP", funcionario.Cep);
            comando.Parameters.AddWithValue("@ENDERECO", funcionario.Endereco);
            comando.Parameters.AddWithValue("@NUMERO", funcionario.Numero);
            comando.Parameters.AddWithValue("@DATA_ADMISSAO", funcionario.DataAdmissao);
            comando.Parameters.AddWithValue("@SALARIO", funcionario.Salario);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Editar(Funcionario funcionario)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"UPDATE funcionarios SET id_profissao = @ID_PROFISSAO, nome = @NOME, cpf = @CPF, data_nascimento = @DATA_NASCIMENTO,
cep = @CEP, endereco = @ENDERECO, numero = @NUMERO, data_admissao = @DATA_ADMISSAO, salario = @SALARIO WHERE id = @ID";
            comando.Parameters.AddWithValue("ID_PROFISSAO", funcionario.Profissao.Id);
            comando.Parameters.AddWithValue("@NOME", funcionario.NomeCompleto);
            comando.Parameters.AddWithValue("@CPF", funcionario.Cpf);
            comando.Parameters.AddWithValue("@DATA_NASCIMENTO", funcionario.DataNascimento);
            comando.Parameters.AddWithValue("@CEP", funcionario.Cep);
            comando.Parameters.AddWithValue("@ENDERECO", funcionario.Endereco);
            comando.Parameters.AddWithValue("@NUMERO", funcionario.Numero);
            comando.Parameters.AddWithValue("@DATA_ADMISSAO", funcionario.DataAdmissao);
            comando.Parameters.AddWithValue("@SALARIO", funcionario.Salario);
            comando.Parameters.AddWithValue("@ID", funcionario.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Funcionario ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, id_profissao, nome, cpf, data_nascimento, cep, endereco, numero, data_admissao, salario FROM funcionarios WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var primeiroRegistro = tabelaEmMemoria.Rows[0];

            var funcionario = new Funcionario();

            funcionario.Id = Convert.ToInt32(primeiroRegistro["id"]);

            funcionario.Profissao = new Profissao();
            funcionario.Profissao.Id = Convert.ToInt32(primeiroRegistro["id_profissao"]);

            funcionario.NomeCompleto = primeiroRegistro["nome"].ToString();
            funcionario.Cpf = primeiroRegistro["cpf"].ToString();
            funcionario.DataNascimento = Convert.ToDateTime(primeiroRegistro["data_nascimento"]);
            funcionario.Cep = primeiroRegistro["cep"].ToString();
            funcionario.Endereco = primeiroRegistro["endereco"].ToString();
            funcionario.Numero = Convert.ToInt32(primeiroRegistro["numero"]);
            funcionario.DataAdmissao = Convert.ToDateTime(primeiroRegistro["data_admissao"]);
            funcionario.Salario = Convert.ToDouble(primeiroRegistro["salario"]);

            comando.Connection.Close();

            return funcionario;
        }

        public List<Funcionario> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT
f.id AS 'id',
f.nome AS 'nome',
f.cpf AS 'cpf',
f.data_nascimento AS 'data_nascimento',
f.cep AS 'cep',
f.endereco AS 'endereco',
f.numero AS 'numero',
f.data_admissao AS 'data_admissao',
f.salario AS 'salario',
p.id AS 'profissao_id',
p.cargo AS 'profissao_cargo'
FROM funcionarios AS f
INNER JOIN profissoes AS p ON(f.id_profissao = p.id)";

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var funcionarios = new List<Funcionario>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var funcionario = new Funcionario();
                funcionario.Id = Convert.ToInt32(registro["id"].ToString());
                funcionario.NomeCompleto = registro["nome"].ToString();
                funcionario.Cpf = registro["cpf"].ToString();
                funcionario.DataNascimento = Convert.ToDateTime(registro["data_nascimento"]);
                funcionario.Cep = registro["cep"].ToString();
                funcionario.Endereco = registro["endereco"].ToString();
                funcionario.Numero = Convert.ToInt32(registro["numero"].ToString());
                funcionario.DataAdmissao = Convert.ToDateTime(registro["data_admissao"]);
                funcionario.Salario = Convert.ToDouble(registro["salario"]);

                funcionario.Profissao = new Profissao();
                funcionario.Profissao.Id = Convert.ToInt32(registro["profissao_id"]);
                funcionario.Profissao.Cargo = registro["profissao_cargo"].ToString();

                funcionarios.Add(funcionario);
            }

            return funcionarios;
        }
    }
}
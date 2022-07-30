using entra21_trabalho_03.Database;
using entra21_trabalho_03.Models;
using System.Data;
using System.Data.SqlClient;

namespace entra21_trabalho_03.Services
{
    internal class ProfissaoService : IProfissaoService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM profissoes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Profissao profissao)
        {
            var conexao = new Conexao().Conectar();
            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText = "INSERT INTO profissoes (cargo) Values(@CARGO)";
            comando.Parameters.AddWithValue("@CARGO", profissao.Cargo);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Editar(Profissao profissao)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "UPDATE profissoes SET cargo = @CARGO WHERE id = @ID";
            comando.Parameters.AddWithValue("@CARGO", profissao.Cargo);
            comando.Parameters.AddWithValue("@ID", profissao.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Profissao ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, cargo FROM profissoes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var primeiroRegistro = tabelaEmMemoria.Rows[0];

            var profissao = new Profissao();
            profissao.Id = Convert.ToInt32(primeiroRegistro["id"]);
            profissao.Cargo = primeiroRegistro["cargo"].ToString();

            comando.Connection.Close();

            return profissao;
        }

        public List<Profissao> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, cargo FROM profissoes";

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var profissoes = new List<Profissao>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];

                var profissao = new Profissao();
                profissao.Id = Convert.ToInt32(linha["id"].ToString());
                profissao.Cargo = linha["cargo"].ToString();

                profissoes.Add(profissao);
            }

            comando.Connection.Close();

            return profissoes;
        }
    }
}
using entra21_trabalho_03.Database;
using entra21_trabalho_03.Models;
using System.Data;
using System.Data.SqlClient;

namespace entra21_trabalho_03.Services
{
    internal class TipoProdutoService : ITipoProdutoService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM tipos_produto WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(TipoProduto1 tipoProduto)
        {
            var conexao = new Conexao().Conectar();

            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText =
                "INSERT INTO tipo_produto (nome) Values(@NOME)";
            comando.Parameters.AddWithValue("@NOME", tipoProduto.Nome);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Editar(TipoProduto1 tipoProduto)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText =
            "UPDATE tipo_produto SET nome = @NOME WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", tipoProduto.Nome);
            comando.Parameters.AddWithValue("@ID", tipoProduto.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public TipoProduto1 ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText =
                "SELECT id, nome FROM tipos_produto WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var primeiroRegistro = tabelaEmMemoria.Rows[0];

            var tipoProduto = new TipoProduto1();

            tipoProduto.Id = Convert.ToInt32(primeiroRegistro["id"]);

            tipoProduto.Nome = primeiroRegistro["nome"].ToString();

            comando.Connection.Close();

            return tipoProduto;
        }
        
        public List<TipoProduto1> ObterTodos()
        {

            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome FROM tipo_produto";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var tipoProdutos = new List<TipoProduto1>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];

                var tipoProduto = new TipoProduto1();
                tipoProduto.Id = Convert.ToInt32(linha["id"].ToString());
                tipoProduto.Nome = linha["nome"].ToString();

                tipoProdutos.Add(tipoProduto);
            }

            comando.Connection.Close();

            return tipoProdutos;
        }
    }
}

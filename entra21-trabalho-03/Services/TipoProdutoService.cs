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
        public void Cadastrar(TipoProduto tipoProduto)
        {
            var conexao = new Conexao().Conectar();

            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText =
                "INSERT INTO tipo_produto (nome, observacao) Values(@NOME, @OBSERVACAO)";
            comando.Parameters.AddWithValue("@NOME", tipoProduto.Nome);
            comando.Parameters.AddWithValue("@OBSERVACAO", tipoProduto.Observacao);

            comando.ExecuteNonQuery();

            conexao.Close();
        }
        public TipoProduto ObterPorId(int id)
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

            var tipoProduto = new TipoProduto();

            tipoProduto.Id = Convert.ToInt32(primeiroRegistro["id"]);

            tipoProduto.Nome = primeiroRegistro["nome"].ToString();

            comando.Connection.Close();

            return tipoProduto;
        }
    }
}

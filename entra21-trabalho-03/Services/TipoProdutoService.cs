using entra21_trabalho_03.Database;
using entra21_trabalho_03.Models;
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
                "INSERT INTO tipo_produto (nome) Values(@NOME)";
            comando.Parameters.AddWithValue("@NOME", tipoProduto.Nome);

            comando.ExecuteNonQuery();

            conexao.Close();
        }
    }
}

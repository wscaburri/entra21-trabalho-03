using entra21_trabalho_03.Database;
using entra21_trabalho_03.Models;

namespace entra21_trabalho_03.Services
{
    internal class ProdutoService : IProdutoService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM produto WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }
        public void Cadastrar(Produto1 produto)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = 
                "INSERT INTO produto (id_tipo_produto, nome, data_vencimento, preco) VALUES (@ID_TIPO_PRODUTO, @NOME, @DATA_VENCIMENTO, PRECO);";

            comando.Parameters.AddWithValue("@ID_TIPO_PRODUTO", produto.TipoProduto.Id);
            comando.Parameters.AddWithValue("@NOME", produto.Nome);
            comando.Parameters.AddWithValue("@DATA_VENCIMENTO", produto.DataValidade);
            comando.Parameters.AddWithValue("@PRECO", produto.Preco);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }
    }
}

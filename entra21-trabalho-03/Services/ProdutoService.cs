using entra21_trabalho_03.Database;
using entra21_trabalho_03.Models;
using System.Data;

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
            comando.Parameters.AddWithValue("@DATA_VENCIMENTO", produto.DataVencimento);
            comando.Parameters.AddWithValue("@PRECO", produto.Preco);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(Produto1 produto)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = 
                "UPDATE produto SET id_tipo_produto = @ID_TIPO_PRODUTO, nome = @NOME, data_vencimento = @DATA_VENCIMENTO, preco = @PRECO WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID_TIPO_PRODUTO", produto.TipoProduto.Id);
            comando.Parameters.AddWithValue("@ID", produto.Id);
            comando.Parameters.AddWithValue("@NOME", produto.Nome);
            comando.Parameters.AddWithValue("@DATA_VENCIMENTO", produto.DataVencimento);
            comando.Parameters.AddWithValue("@PRECO", produto.Preco);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Produto1 ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, id_tipo_produto, nome, data_vencimento, preco FROM produto WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var dataTable = new DataTable();

            dataTable.Load(comando.ExecuteReader());

            if (dataTable.Rows.Count == 0)
                return null;

            var registro = dataTable.Rows[0];
            var produto = new Produto1();
            produto.Id = Convert.ToInt32(registro["id"]);

            produto.TipoProduto = new TipoProduto1();
            produto.TipoProduto.Id = Convert.ToInt32(registro["id_tipo_produto"]);

            produto.Nome = registro["nome"].ToString();

            conexao.Close();

            return produto;
        }

        public List<Produto1> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"SELECT 
p.id AS 'id',
p.nome AS 'nome',
tp.id AS 'tipo_produto_id',
tp.tipo AS 'tipo_produto_nome',
FROM produto AS p
INNER JOIN tipos_produto AS tp ON(p.id_tipo_produto = tp.id)";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var produtos = new List<Produto1>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var produto = new Produto1();
                produto.Id = Convert.ToInt32(registro["id"]);
                produto.Nome = registro["nome"].ToString();

                produto.TipoProduto = new TipoProduto1();
                produto.TipoProduto.Id = Convert.ToInt32(registro["tipo_personagem_id"]);
                produto.TipoProduto.Nome = registro["tipo_personagem_tipo"].ToString();

                produtos.Add(produto);
            }
            return produtos;
        }
    }
}

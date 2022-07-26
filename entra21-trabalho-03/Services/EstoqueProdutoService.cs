using entra21_trabalho_03.Database;
using entra21_trabalho_03.Models;
using System.Data;

namespace entra21_trabalho_03.Services
{
    internal class EstoqueProdutoService : IEstoqueProdutoService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM estoque_produto WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(EstoqueProduto estoqueProduto)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"INSERT INTO estoque_produto(id_farmacia, id_tipo_produto, nome,
quantidade_produto, validade_produto, data_produto_entrada_estoque) VALUES
(@ID_FARMACIA, @ID_TIPO_PRODUTO, @NOME, @QUANTIDADE_PRODUTO, @VALIDADE_PRODUTO, @DATA_PRODUTO_ENTRADA_ESTOQUE);";

            comando.Parameters.AddWithValue("@ID_FARMACIA", estoqueProduto.Farmacia.Id);
            comando.Parameters.AddWithValue("@ID_TIPO_PRODUTO", estoqueProduto.TipoProduto.Id);
            comando.Parameters.AddWithValue("@NOME", estoqueProduto.Nome);
            comando.Parameters.AddWithValue("@QUANTIDADE_PRODUTO", estoqueProduto.QuantidadeProduto);
            comando.Parameters.AddWithValue("@VALIDADE_PRODUTO", estoqueProduto.ValidadeProduto);
            comando.Parameters.AddWithValue("@DATA_PRODUTO_ENTRADA_ESTOQUE", estoqueProduto.EntradaProdutoEstoque);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(EstoqueProduto estoqueProduto)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"UPDATE estoque_produto SET id_farmacia = @ID_FARMACIA,
id_tipo_produto = @ID_TIPO_PRODUTO,
nome = @NOME,
quantidade_produto = @QUANTIDADE_PRODUTO,
validade_produto = @VALIDADE_PRODUTO,
data_entrada_produto_estoque = @DATA_ENTRADA_PRODUTO_ESTOQUE
WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID_FARMACIA", estoqueProduto.Farmacia.Id);
            comando.Parameters.AddWithValue("@ID_TIPO_PRODUTO", estoqueProduto.TipoProduto.Id);
            comando.Parameters.AddWithValue("@NOME", estoqueProduto.Nome);
            comando.Parameters.AddWithValue("@QUANTIDADE_PRODUTO", estoqueProduto.QuantidadeProduto);
            comando.Parameters.AddWithValue("@VALIDADE_PRODUTO", estoqueProduto.ValidadeProduto);
            comando.Parameters.AddWithValue("@DATA_ENTRADA_PRODUTO_ESTOQUE", estoqueProduto.EntradaProdutoEstoque);
            comando.Parameters.AddWithValue("@ID", estoqueProduto.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public EstoqueProduto ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"SELECT id, id_farmacia, id_tipo_produto, nome, quantidade_produto,
validade_produto, data_entrada_produto_estoque FROM estoque_produto
WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            var dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());

            if (dataTable.Rows.Count == 0)
                return null;

            var registro = dataTable.Rows[0];
            var estoqueProduto = new EstoqueProduto();
            estoqueProduto.Id = Convert.ToInt32(registro[0]);
            estoqueProduto.Farmacia = new Farmacia();
            estoqueProduto.Farmacia.Id = Convert.ToInt32(registro["id_farmacia"]);
            estoqueProduto.TipoProduto = new TipoProduto();
            estoqueProduto.TipoProduto.Id = Convert.ToInt32(registro["id_tipo_produto"]);
            estoqueProduto.Nome = registro["nome"].ToString();
            estoqueProduto.QuantidadeProduto = Convert.ToInt32(registro["quantidade_produto"]);
            estoqueProduto.ValidadeProduto = Convert.ToDateTime(registro["validade_produto"]);
            estoqueProduto.EntradaProdutoEstoque = Convert.ToDateTime(registro["data_entrada_produto_estoque"]);

            conexao.Close();

            return estoqueProduto;
        }

        public List<EstoqueProduto> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"SELECT
ep.id AS 'id',
ep.nome AS 'nome',
ep.quantidade_produto AS 'quantidade_produto',
ep.validade_produto AS 'validade_produto',
ep.data_produto_entrada_estoque AS 'data_produto_entrada_estoque',
f.id AS 'farmacia_id',
f.nome AS 'farmacia_nome',
tp.id AS 'tipo_produto_id',
tp.nome AS 'tipo_produto_nome'
FROM estoque_produto AS ep
INNER JOIN farmacia AS f ON(ep.id_farmacia = f.id)
INNER JOIN tipo_produto AS tp ON(ep.id_tipo_produto = tp.id)";

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var estoqueProdutos = new List<EstoqueProduto>();

            for(int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var estoqueProduto = new EstoqueProduto();
                estoqueProduto.Id = Convert.ToInt32(registro["id"]);
                estoqueProduto.Nome = registro["nome"].ToString();
                estoqueProduto.QuantidadeProduto = Convert.ToInt32(registro["quantidade_produto"]);
                estoqueProduto.ValidadeProduto = Convert.ToDateTime(registro["validade_produto"]);
                estoqueProduto.Farmacia = new Farmacia();
                estoqueProduto.Farmacia.Id = Convert.ToInt32(registro["farmacia_id"]);
                estoqueProduto.Farmacia.Nome = registro["farmacia_nome"].ToString();
                estoqueProduto.TipoProduto = new TipoProduto();
                estoqueProduto.TipoProduto.Id = Convert.ToInt32(registro["tipo_produto_id"]);
                estoqueProduto.TipoProduto.Nome = registro["tipo_produto_nome"].ToString();
                estoqueProduto.EntradaProdutoEstoque = Convert.ToDateTime(registro["data_produto_entrada_estoque"]);

                estoqueProdutos.Add(estoqueProduto);
            }

            return estoqueProdutos;
        }
    }
}
//TODO: Refatora codigo EstoqueProdutoService
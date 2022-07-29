using entra21_trabalho_03.Database;
using entra21_trabalho_03.Models;
using System.Data;

namespace entra21_trabalho_03.Services
{
    internal class PedidoService : IPedidoService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM pedido WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Pedido pedido)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"INSERT INTO pedido (id_cliente, id_farmacia, id_estoque_produto, data_compra, valor_pedido)
VALUES (@ID_CLIENTE, @ID_FARMACIA, @ID_ESTOQUE_PRODUTO, @DATA_COMPRA, @VALOR_PEDIDO);";

            comando.Parameters.AddWithValue("@ID_CLIENTE", pedido.Cliente.Id);
            comando.Parameters.AddWithValue("@ID_FARMACIA", pedido.Distribuidora.Id);
            comando.Parameters.AddWithValue("@ID_ESTOQUE_PRODUTO", pedido.EstoqueProduto.Id);
            comando.Parameters.AddWithValue("DATA_COMPRA", pedido.DataCompra);
            comando.Parameters.AddWithValue("@VALOR_PEDIDO", pedido.ValorPedido);

            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public void Editar(Pedido pedido)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"UPDATE pedido SET id_cliente = @ID_CLIENTE, id_farmacia = @ID_FARMACIA, id_estoque_produto = @ID_ESTOQUE_PRODUTO,
data_compra = @DATA_COMPRA, valor_pedido = @VALOR_PEDIDO WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID_CLIENTE", pedido.Cliente.Id);
            comando.Parameters.AddWithValue("@ID_FARMACIA", pedido.Distribuidora.Id);
            comando.Parameters.AddWithValue("@ID_ESTOQUE_PRODUTO", pedido.EstoqueProduto.Id);
            comando.Parameters.AddWithValue("DATA_COMPRA", pedido.DataCompra);
            comando.Parameters.AddWithValue("@VALOR_PEDIDO", pedido.ValorPedido);
            comando.Parameters.AddWithValue("@ID", pedido.Id);

            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public Pedido ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, id_cliente, id_farmacia, id_estoque_produto, data_compra, valor_pedido FROM pedido WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());

            if (dataTable.Rows.Count == 0)
                return null;

            var registro = dataTable.Rows[0];

            var pedido = new Pedido();
            pedido.Id = Convert.ToInt32(registro["id"]);

            pedido.Cliente = new Cliente();
            pedido.Cliente.Id = Convert.ToInt32(registro["id_cliente"]);

            pedido.Distribuidora = new Distribuidora();
            pedido.Distribuidora.Id = Convert.ToInt32(registro["id_farmacia"]);

            pedido.EstoqueProduto = new EstoqueProduto();
            pedido.Distribuidora.Id = Convert.ToInt32(registro["id_estoque_produto"]);

            pedido.DataCompra = Convert.ToDateTime(registro["data_compra"]);

            pedido.ValorPedido = Convert.ToDouble(registro["valor_pedido"]);

            conexao.Close();

            return pedido;
        }

        public List<Pedido> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
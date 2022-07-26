using entra21_trabalho_03.Database;
using entra21_trabalho_03.Models;
using System.Data;
using System.Data.SqlClient;

namespace entra21_trabalho_03.Services
{
    internal class ClienteService : IClienteService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM clientes WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Cliente cliente)
        {
            var conexao = new Conexao().Conectar();
            SqlCommand comando = conexao.CreateCommand();

            comando.CommandText = @"INSERT INTO clientes (nome, cpf, data_nascimento, cep, endereco, numero)
VALUES (@NOME, @CPF, @DATA_NASCIMENTO, @CEP, @ENDERECO, @NUMERO)";
            comando.Parameters.AddWithValue("@NOME", cliente.NomeCompleto);
            comando.Parameters.AddWithValue("@CPF", cliente.Cpf);
            comando.Parameters.AddWithValue("@DATA_NASCIMENTO", cliente.DataNascimento);
            comando.Parameters.AddWithValue("@CEP", cliente.Cep);
            comando.Parameters.AddWithValue("@ENDERECO", cliente.Endereco);
            comando.Parameters.AddWithValue("@NUMERO", cliente.Numero);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Editar(Cliente cliente)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"UPDATE clientes SET
nome = @NOME, cpf = @CPF, data_nascimento = @DATA_NASCIMENTO, cep = @CEP, endereco = @ENDERECO, numero = @NUMERO WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", cliente.NomeCompleto);
            comando.Parameters.AddWithValue("@CPF", cliente.Cpf);
            comando.Parameters.AddWithValue("@DATA_NASCIMENTO", cliente.DataNascimento);
            comando.Parameters.AddWithValue("@CEP", cliente.Cep);
            comando.Parameters.AddWithValue("@ENDERECO", cliente.Endereco);
            comando.Parameters.AddWithValue("@NUMERO", cliente.Numero);
            comando.Parameters.AddWithValue("@ID", cliente.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Cliente ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome, cpf, data_nascimento, cep, endereco, numero FROM cidades WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var primeiroRegistro = tabelaEmMemoria.Rows[0];

            var cliente = new Cliente();

            cliente.Id = Convert.ToInt32(primeiroRegistro["id"]);
            cliente.NomeCompleto = primeiroRegistro["nome"].ToString();
            cliente.Cpf = primeiroRegistro["cpf"].ToString();
            cliente.DataNascimento = Convert.ToDateTime(primeiroRegistro["data_nascimento"]);
            cliente.Cep = primeiroRegistro["cep"].ToString();
            cliente.Endereco = primeiroRegistro["endereco"].ToString();
            cliente.Numero = Convert.ToInt32(primeiroRegistro["numero"]);

            comando.Connection.Close();

            return cliente;
        }

        public List<Cliente> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome, cpf, data_nascimento, cep, endereco, numero FROM clientes";

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var clientes = new List<Cliente>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var cliente = new Cliente();
                cliente.Id = Convert.ToInt32(registro["id"].ToString());
                cliente.NomeCompleto = registro["nome"].ToString();
                cliente.Cpf = registro["cpf"].ToString();
                cliente.DataNascimento = Convert.ToDateTime(registro["data_nascimento"].ToString());
                cliente.Cep = registro["cep"].ToString();
                cliente.Endereco = registro["endereco"].ToString();
                cliente.Numero = Convert.ToInt32(registro["numero"].ToString);

                clientes.Add(cliente);
            }

            return clientes;
        }
    }
}
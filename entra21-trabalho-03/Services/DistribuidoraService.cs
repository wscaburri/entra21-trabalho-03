using entra21_trabalho_03.Database;
using entra21_trabalho_03.Models;
using System.Data;

namespace entra21_trabalho_03.Services
{
    internal class DistribuidoraService : IDistribuidoraService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"DELETE FROM distribuidora WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }
        public void Cadastrar(Distribuidora Distribuidora)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"INSERT INTO distribuidora(nome, cnpj, estado, cidade, bairro, logradouro, numero)
VALUES(
@NOME, @CNPJ, @ESTADO, @CIDADE, @BAIRRO, @LOGRADOURO, @NUMERO);";

            comando.Parameters.AddWithValue("@NOME", Distribuidora.Nome);
            comando.Parameters.AddWithValue("@CNPJ", Distribuidora.Cnpj);
            comando.Parameters.AddWithValue("@ESTADO", Distribuidora.Estado);
            comando.Parameters.AddWithValue("@CIDADE", Distribuidora.Cidade);
            comando.Parameters.AddWithValue("@BAIRRO", Distribuidora.Bairro);
            comando.Parameters.AddWithValue("@LOGRADOURO", Distribuidora.Logradouro);
            comando.Parameters.AddWithValue("@NUMERO", Distribuidora.Numero);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }
        public void Editar(Distribuidora Distribuidora)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"UPDATE distribuidora SET nome = @NOME, cnpj = @CNPJ, estado = @ESTADO, cidade = @CIDADE, 
bairro = @BAIRRO, logradouro = @LOGRADOURO, numero = @NUMERO
                    WHERE id = @ID";

            comando.Parameters.AddWithValue("@NOME", Distribuidora.Nome);
            comando.Parameters.AddWithValue("@CNPJ", Distribuidora.Cnpj);
            comando.Parameters.AddWithValue("@ESTADO", Distribuidora.Estado);
            comando.Parameters.AddWithValue("@CIDADE", Distribuidora.Cidade);
            comando.Parameters.AddWithValue("@BAIRRO", Distribuidora.Bairro);
            comando.Parameters.AddWithValue("@LOGRADOURO", Distribuidora.Logradouro);
            comando.Parameters.AddWithValue("@NUMERO", Distribuidora.Numero);
            comando.Parameters.AddWithValue("@ID", Distribuidora.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }
        public Distribuidora ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"SELECT id, nome, cnpj, estado, cidade, bairro, logradouro, numero 
FROM distribuidora
WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var registro = tabelaEmMemoria.Rows[0];

            var distribuidora = new Distribuidora();
            distribuidora.Id = Convert.ToInt32(registro["id"]);
            distribuidora.Nome = registro["nome"].ToString();
            distribuidora.Cnpj = registro["cnpj"].ToString();
            distribuidora.Estado = registro["estado"].ToString();
            distribuidora.Cidade = registro["cidade"].ToString();
            distribuidora.Bairro = registro["bairro"].ToString();
            distribuidora.Logradouro = registro["logradouro"].ToString();
            distribuidora.Numero = Convert.ToInt32(registro["numero"]);

            comando.Connection.Close();

            return distribuidora;
        }
        public List<Distribuidora> ObterTodas()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"SELECT id, nome, cnpj, estado, cidade, bairro, logradouro, numero 
                            FROM distribuidora";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var distribuidoras = new List<Distribuidora>();

            for(int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var distribuidora = new Distribuidora();
                distribuidora.Id = Convert.ToInt32(registro["id"].ToString());
                distribuidora.Nome = registro["nome"].ToString();
                distribuidora.Cnpj = registro["cnpj"].ToString();
                distribuidora.Estado = registro["estado"].ToString();
                distribuidora.Cidade = registro["cidade"].ToString();
                distribuidora.Bairro = registro["bairro"].ToString();
                distribuidora.Logradouro = registro["logradouro"].ToString();
                distribuidora.Numero = Convert.ToInt32(registro["numero"].ToString());

                distribuidoras.Add(distribuidora);
            }

            conexao.Close();

            return distribuidoras;
        }
    }
}

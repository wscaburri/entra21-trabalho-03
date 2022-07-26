using entra21_trabalho_03.Database;
using entra21_trabalho_03.Models;
using System.Data;

namespace entra21_trabalho_03.Services
{
    internal class FarmaciaService : IFarmaciaService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"DELETE FROM farmacia WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }
        public void Cadastrar(Farmacia farmacia)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"INSERT INTO farmacia(nome, cnpj, cidade, bairro, logradouro, numero)
VALUES(
@NOME, @CNPJ, @CIDADE, @BAIRRO, @LOGRADOURO, @NUMERO);";

            comando.Parameters.AddWithValue("@NOME", farmacia.Nome);
            comando.Parameters.AddWithValue("@CNPJ", farmacia.Cnpj);
            comando.Parameters.AddWithValue("@CIDADE", farmacia.Cidade);
            comando.Parameters.AddWithValue("@BAIRRO", farmacia.Bairro);
            comando.Parameters.AddWithValue("@LOGRADOURO", farmacia.Logradouro);
            comando.Parameters.AddWithValue("@NUMERO", farmacia.Numero);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }
        public void Editar(Farmacia farmacia)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"UPDATE farmacia SET nome = @NOME, cnpj = @CNPJ, cidade = @CIDADE, bairro = @BAIRRO,
                logradouro = @LOGRADOURO, numero = @NUMERO
                    WHERE id = @ID";

            comando.Parameters.AddWithValue("@NOME", farmacia.Nome);
            comando.Parameters.AddWithValue("@CNPJ", farmacia.Cnpj);
            comando.Parameters.AddWithValue("@CIDADE", farmacia.Cidade);
            comando.Parameters.AddWithValue("@BAIRRO", farmacia.Bairro);
            comando.Parameters.AddWithValue("@LOGRADOURO", farmacia.Logradouro);
            comando.Parameters.AddWithValue("@NUMERO", farmacia.Numero);
            comando.Parameters.AddWithValue("@ID", farmacia.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }
        public Farmacia ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"SELECT id, nome, cnpj, cidade, bairro, logradouro, numero 
FROM farmacia
WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            if (tabelaEmMemoria.Rows.Count == 0)
                return null;

            var registro = tabelaEmMemoria.Rows[0];

            var farmacia = new Farmacia();
            farmacia.Id = Convert.ToInt32(registro["id"]);
            farmacia.Nome = registro["nome"].ToString();
            farmacia.Cnpj = registro["cnpj"].ToString();
            farmacia.Cidade = registro["cidade"].ToString();
            farmacia.Bairro = registro["bairro"].ToString();
            farmacia.Logradouro = registro["logradouro"].ToString();
            farmacia.Numero = Convert.ToInt32(registro["numero"]);

            comando.Connection.Close();

            return farmacia;
        }
        public List<Farmacia> ObterTodas()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"SELECT id, nome, cnpj, cidade, bairro, logradouro, numero 
                            FROM farmacia";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var farmacias = new List<Farmacia>();

            for(int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var farmacia = new Farmacia();
                farmacia.Id = Convert.ToInt32(registro["id"].ToString());
                farmacia.Nome = registro["nome"].ToString();
                farmacia.Cnpj = registro["cnpj"].ToString();
                farmacia.Cidade = registro["cidade"].ToString();
                farmacia.Bairro = registro["bairro"].ToString();
                farmacia.Logradouro = registro["logradouro"].ToString();
                farmacia.Numero = Convert.ToInt32(registro["numero"].ToString());

                farmacias.Add(farmacia);
            }

            conexao.Close();

            return farmacias;
        }
    }//TODO: Refatorar a Classe FarmaciaService com novo exemplo professor
    //TODO: FarmaciaService atualizar metodo ObertTodas()
}

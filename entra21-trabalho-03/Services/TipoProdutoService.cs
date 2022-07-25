﻿using entra21_trabalho_03.Database;
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

        public void Editar(TipoProduto tipoProduto)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText =
            "UPDATE tipo_produto SET nome = @NOME, observacao = @OBSERVACAO WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", tipoProduto.Nome);
            comando.Parameters.AddWithValue("@OBSERVACAO", tipoProduto.Observacao);
            comando.Parameters.AddWithValue("@ID", tipoProduto.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
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
        
        public List<TipoProduto> ObterTodos()
        {

            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome, observacao FROM tipo_produto";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var tipoProdutos = new List<TipoProduto>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];

                var tipoProduto = new TipoProduto();
                tipoProduto.Id = Convert.ToInt32(linha["id"].ToString());
                tipoProduto.Nome = linha["nome"].ToString();
                tipoProduto.Observacao = linha["observacao"].ToString();

                tipoProdutos.Add(tipoProduto);
            }

            comando.Connection.Close();

            return tipoProdutos;
        }
    }
}

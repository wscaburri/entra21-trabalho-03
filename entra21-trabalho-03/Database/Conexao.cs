﻿using System.Data.SqlClient;

namespace entra21_trabalho_03.Database
{
    internal class Conexao
    {
        public SqlConnection Conectar()
        {
            var conexao = new SqlConnection();

            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amand\source\repos\entra21-trabalho-03\entra21-trabalho-03\Database\BancoDadosAmanda.mdf;Integrated Security=True;Connect Timeout=30";

            conexao.ConnectionString = connectionString;

            conexao.Open();

            return conexao;//TODO: Atualizar conexão para forma mais recente ensinada pelo professor
        }
    }
}
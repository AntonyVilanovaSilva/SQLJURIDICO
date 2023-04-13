using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SLNListaDB1.Models.DAL
{
    public class SerieDAO
    {
        private SqlConnection conexao;

        public SerieDAO()
        {
            conexao = ConexaoBD.getConexao();
        }
        public List<Serie> getTodosSerie()
        {
            string sql = "select * from Serie";
            var dados7 = (List<Serie>)conexao.Query<Serie>(sql);
            return dados7;
        }
        public void insertSerie(Serie pserie)
        {
            string query = "insert Serie (SERNOME, SEREPISODIO) values (@SERNOME, @SEREPISODIO)";

            var qtdInserida = conexao.Execute(query, pserie);

        }
    }
}

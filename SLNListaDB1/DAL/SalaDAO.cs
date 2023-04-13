using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SLNListaDB1.Models.DAL
{
    public class SalaDAO
    {
        private SqlConnection conexao;

        public SalaDAO()
        {
            conexao = ConexaoBD.getConexao();
        }
        public List<SalaDAO> getTodosSalas()
        {
            string sql = "select * from Sala";
            var dados3 = (List<SalaDAO>)conexao.Query<SalaDAO>(sql);
            return dados3;
        }
        public void insertSala(Sala psala)
        {
            string query = "insert Sala (SALADESCRICAO, SALANUMERO) values (@SALADESCRICAO, @SALANUMERO)";

            int qtdInserida = conexao.Execute(query, psala);

        }
    }
}

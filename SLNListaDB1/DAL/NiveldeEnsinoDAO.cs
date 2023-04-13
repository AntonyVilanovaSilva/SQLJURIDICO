using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SLNListaDB1.Models.DAL
{
    public class NiveldeEnsinoDAO
    {
        private SqlConnection conexao;

        public NiveldeEnsinoDAO()
        {
            conexao = ConexaoBD.getConexao();
        }
        public List<NiveldeEnsinoDAO> getTodosNiveldeEnsino()
        {
            string sql = "select * from NiveldeEnsino";
            var dados7 = (List<NiveldeEnsinoDAO>)conexao.Query<NiveldeEnsinoDAO>(sql);
            return dados7;
        }
    }
}

using Dapper;
using System.Data.SqlClient;

namespace BDAtleta.Models.DAL
{
    public class AtletaDAO
    {
        private SqlConnection conexao;

        public AtletaDAO()
        {
            conexao = AtletaBD.getConexao();
        }

        public List<Atleta> getTodosAtletas()
        {
            string sql = "select * from ATLETA";
            var dados = (List<Atleta>)conexao.Query<Atleta>(sql);
            return dados;
        }
        
    }
}
   


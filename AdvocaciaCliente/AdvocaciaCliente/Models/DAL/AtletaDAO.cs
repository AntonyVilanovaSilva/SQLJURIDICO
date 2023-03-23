using Dapper;
using System.Data.SqlClient;

namespace AdvocaciaCliente.Models.DAL
{
    public class AtletaDAO
    {
        private SqlConnection _conexao;

        public AtletaDAO()
        {
            _conexao = AtletaBD.getConexao();
        }

        public List<Atleta> getTodosAtletas()
        {
            string sql = "select * from ATLETA";
            var dados = (List<Atleta>)_conexao.Query<Atleta>(sql);
            return dados;
        }
    }
}

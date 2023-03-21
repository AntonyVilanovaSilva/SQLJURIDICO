using Dapper;
using System.Data.SqlClient;

namespace AdvocaciaCliente.Models.DAL
{
    public class CategoriaDocumentoDAO
    {
        private SqlConnection _conexao;
        public CategoriaDocumentoDAO()
        {
            _conexao = ConexãoBD.getConexao();
        }

        public List<CategoriaDocumento> GetALlCategoriaDocumento()
        {
            string sql = "select * from CategoriaDocumento";

            var dados = (List<CategoriaDocumento>)_conexao.Query<CategoriaDocumento>(sql);
            return dados;
        }
    }
}

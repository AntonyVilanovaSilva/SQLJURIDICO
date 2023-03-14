using Dapper;
using System.Data.SqlClient;

namespace AdvocaciaCliente.Models.DAL
{
    public class ClienteDAO
    {
        private SqlConnection _conexao;

        public ClienteDAO()
        {
            _conexao = ConexãoBD.getConexao();
        }

        public List<Cliente> getTodosClientes()
        {
            string sql = "select * from Cliente";
            var dados = (List<Cliente>)_conexao.Query<Cliente>(sql);
            return dados;
        }
    }
}

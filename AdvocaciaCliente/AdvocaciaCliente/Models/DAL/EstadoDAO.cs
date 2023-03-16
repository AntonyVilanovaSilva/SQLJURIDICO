using Dapper;
using System.Data.SqlClient;

namespace AdvocaciaCliente.Models.DAL
{
    public class EstadoDAO
    {
        private SqlConnection _conexao;

        public EstadoDAO()
        {
            _conexao = ConexãoBD.getConexao();
        }

        public List<Estado> getTodosClientes()
        {
            string sql = "select * from Estado";
            var dados = (List<Estado>)_conexao.Query<Estado>(sql);
            return dados;
        }
        public bool inserirCliente(Cliente cliente)
        {
            try
            {
                string sql = "INSERT INTO [dbo].[Estado]  ([ESTADODESCRIÇÃO],[ESTSIGLA ] " +
                    "VALUES  (@ESTADODESCRIÇÃO, @ESTSIGLA,) ";
                int qtdInserida = _conexao.Execute(sql, cliente);
                if (qtdInserida > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {

                return false;
            }


        }
    }
}
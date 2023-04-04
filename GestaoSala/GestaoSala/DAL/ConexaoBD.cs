using System.Data.SqlClient;

namespace GestaoSala.DAL
{
    public class ConexaoBD
    {
        static SqlConnection _conexao;

        public static SqlConnection getConexao()
        {
            if (_conexao == null)
            {
                _conexao = new SqlConnection(@"Server=.\SENAI2022; Database=BDGestaoSala; User id =sa; Password=senai.123;");
            }
            return _conexao;
        }

    }
}

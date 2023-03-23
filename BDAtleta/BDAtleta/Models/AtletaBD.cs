using System.Data.SqlClient;

namespace BDAtleta.Models
{
    public class AtletaBD
    {
        private static SqlConnection banco;

        public static SqlConnection getConexao()
        {
            if (banco == null)
            {
                banco = new SqlConnection(@"Server=.\SENAI2022; Database=BDATLETA; User Id =sa; Password=senai.123;");
            }

            return banco;
        }
    }
}

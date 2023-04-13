using System.Data.SqlClient;

namespace SLNListaDB1.Models.DAL
{
    public class ConexaoBD
    {
        private static SqlConnection banco;

        public static SqlConnection getConexao()
        {
            if (banco == null)
            {
                banco = new SqlConnection(@"Server=.\SENAI2022; Database=ListaDB; User Id =sa; Password=senai.123;");
            }

            return banco;
        }
    }
}

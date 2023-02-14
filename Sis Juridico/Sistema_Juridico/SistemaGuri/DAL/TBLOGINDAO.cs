using Dapper;
using SistemaGuri.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGuri.DAL
{
     public class TBLOGINDAO
    {
        SqlConnection conexao;

        public TBLOGINDAO()
        {
            conexao = new SqlConnection("Server = .\SENAI2022; Database = BDJURIDICO; User Id = sa; Password = senai.123; ");
        }
        public List<TBLOGIN> getTodosLogins()
        {
            
           

            string sql = "select * from TBLOGIN";
            var dados = (List<TBLOGIN>) conexao.Query<List<TBLOGIN>>(sql);
            return dados;
        }
         public bool setInserirLogin(TBLOGIN plogin)
        {
            string sql = "insert TBLOGIN (LOGNOME, LOGSENHA) values (@LOGNOME,@LOGSENHA)";
            var dados = conexao.Execute(sql, plogin);

            if (dados > 0)
                return true;
            else
                return false;

            
        }

    }
}

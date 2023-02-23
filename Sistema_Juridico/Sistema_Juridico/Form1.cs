using Dapper;
using System.Data.SqlClient;

namespace Sistema_Juridico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(@"Server=.\SENAI2022; Database=BDJURIDICO; User Id =sa; Password=senai.123;");

            conexao.Open();

            var sql = "SELECT * FROM ESTADO";
            var dados = conexao.Query<Estado>(sql).ToList();

            foreach (var item in dados)
            {
                listView1.Items.Add(item.ESTID + " | " + item.ESTDESCRICAO + " | " + item.ESTSIGLA);
            }
        }
    }
}
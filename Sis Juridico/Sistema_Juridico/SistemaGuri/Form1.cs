using SistemaGuri.DAL;
using SistemaGuri.Model;
using SistemaGuri.View;

namespace SistemaGuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBLOGINDAO tabela = new TBLOGINDAO();
            List<TBLOGIN> lista = tabela.getTodosLogins();
            bool logou = true;
            foreach (var item in lista)
            {
                
                if (item.LOGNOME == txtLogin.Text)
                {
                    if (item.LOGSENHA == txtSenha.Text)
                    {
                        logou = true;
                        FormUsuario frm = new FormUsuario();
                        frm.Show();
                        MessageBox.Show("Logado com sucesso");
                    }
                }
            }
            if (logou == false)
            {
                MessageBox.Show("Login ou senha invalido");
            }
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
   
}
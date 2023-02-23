using SistemaGuri.DAL;
using SistemaGuri.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGuri.View
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            TBLOGINDAO tabela = new TBLOGINDAO();
            dataGridView1.DataSource = tabela.getTodosLogins();

            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Login";
            dataGridView1.Columns[2].HeaderText = "Senha";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TBLOGINDAO tabela = new TBLOGINDAO();

            TBLOGIN novousuario = new TBLOGIN();
            novousuario.LOGNOME = txtLogin.Text;
            novousuario.LOGSENHA = txtSenha.Text;

            if (tabela.setInserirLogin(novousuario)) 
            {
                MessageBox.Show("Usuário cadastrado com sucesso");
                dataGridView1.DataSource = tabela.getTodosLogins();
            }
            else
            {
                MessageBox.Show("Não foi possivel inserir o usuário");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetilTeste
{
    public partial class TelaConnect : Form
    {
        
        public TelaConnect()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string Mensagem;
            try
            {
                Conexao.CriarConexao(boxServidor.Text, BoxNome.Text, boxSenha.Text);
                Conexao.conectar();
                Mensagem = "Conexão foi Estabelecida";
                Cadastro.CadastroUsuario(BoxNome.Text, "Email");

            }
            catch (Exception)
            {
                Mensagem = "Conexão Falhou";

            }
            StatusConnect.Visible = true;
            StatusConnect.Text = Mensagem;

        }

        private void btnSeguir_Click(object sender, EventArgs e)
        {

            TelaInicial TI = new TelaInicial();
            TI.Show();
            this.Close();

        }
    }
}

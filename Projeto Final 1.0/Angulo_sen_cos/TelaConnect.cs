using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Tela inicial de conexão com BD
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

        //Botão que faz conexão com o banco de dados
        private void btnConnect_Click(object sender, EventArgs e)
        {
            //Variavel que devolve a resposta se foi possivel conectar
            string Mensagem;
            try
            {
                //Busca o nome do servidor, do usuario e a senha para conectar ao BD
                Conexao.CriarConexao(boxServidor.Text, BoxNome.Text, boxSenha.Text);
                //Testa a conexão
                Conexao.conectar();
                Mensagem = "Conexão foi Estabelecida";
                //Cria um usuario para seguir para a proxima parte
                Cadastro.CadastroUsuario(BoxNome.Text, "Email");

            }
            catch (Exception)
            {
                Mensagem = "Conexão Falhou";

            }
            //Mostra a mensagem
            StatusConnect.Visible = true;
            StatusConnect.Text = Mensagem;

        }

        private void btnSeguir_Click(object sender, EventArgs e)
        {
            //Segue para a tela inicial
            TelaInicial TI = new TelaInicial();
            TI.Show();
            this.Close();

        }
    }
}

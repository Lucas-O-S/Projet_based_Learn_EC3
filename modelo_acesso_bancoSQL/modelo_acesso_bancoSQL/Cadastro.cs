using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_acesso_bancoSQL
{
    class Cadastro
    {
        //instancia da classe de comando par gerar comando Sql
        SqlCommand cmd = new SqlCommand();
        //instancia da classe de conexão para conexão com banco de dados
        Conexao conexao = new Conexao();
        //variavel que guarda a mensagem de erro ou sucesso
        public String mensagem = "";

        //metodos de cadastro dos dados do Meteoro
        public CadastroMeteoro(float posicaoInicialX, float posicaoFinalX, float posicaoInicialY, float posicaoFinalY)
        {
            //Comando SQL de chamada da SP para cadastro dos dados
            cmd.CommandText = "exec SP_INSERT_DADOS_METEORO 'dados separado por virgla'";
            //Parametros
            cmd.Parameters.AddWithValue("@valorPosicaoinicialX",variavelposicaoinicialX);
            cmd.Parameters.AddWithValue("@valorPosicaoFinalX",variavelposicaoFinalX);
            cmd.Parameters.AddWithValue("@valorPosicaoinicialY",variavelposicaoinicialY);
            cmd.Parameters.AddWithValue("@valorPosicaoFinalX",variavelposicaoFinalX);

            try
            {
                //conectar com banco de dados
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso
                this.mensagem = "Cadastro de dados Meteoro com sucesso!!";
            }catch (SqlException e)
            {
                this.mensagem = "erro ao tentar se conectar com o banco de Dados";
            }
        }
        //metodos de cadastro dos dados usuario
        public CadastroUsuario(string nome, string email)
        {
            //Comando SQL de chamada da SP para cadastro dos dados
            cmd.CommandText = "exec SP_INSERT_USUARIO 'dados separado por virgla'";
            //Parametros
            cmd.Parameters.AddWithValue("@valornome",variavelnome);
            cmd.Parameters.AddWithValue("@valoremail",variavelemail);
            
            try
            {
                //conectar com banco de dados
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso
                this.mensagem = "Cadastro de dados Usuario com sucesso!!";
            }catch (SqlException e)
            {
                this.mensagem = "erro ao tentar se conectar com o banco de Dados";
            }
        }
        //metodo de cadastro de Projetil e lançamento
        public CadastroLP(float velInicial, Int32 angulo, float posicaoInicialX, float posicaoFinalX, float posicaoInicialY, float posicaoFinalY, Int32 tempo, )
        {
            //Comando SQL de chamada da SP para cadastro dos dados
            cmd.CommandText = "exec SP_INSERT_DADOS_LP 'dados separado por virgla'";
            //Parametros
            cmd.Parameters.AddWithValue("@valorVelInicial",variavelVelInicial);
            cmd.Parameters.AddWithValue("@valorAngulo",variavelAngulo);
            cmd.Parameters.AddWithValue("@valorPosicaoinicialX",variavelposicaoinicialX);
            cmd.Parameters.AddWithValue("@valorPosicaoFinalX",variavelposicaoFinalX);
            cmd.Parameters.AddWithValue("@valorPosicaoinicialY",variavelposicaoinicialY);
            cmd.Parameters.AddWithValue("@valorPosicaoFinalX",variavelposicaoFinalX);
            cmd.Parameters.AddWithValue("@valorTempo", variavelTempo);

            try
            {
                //conectar com banco de dados
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso
                this.mensagem = "Cadastro de dados Usuario e Projetil com sucesso!!";
            }catch (SqlException e)
            {
                this.mensagem = "erro ao tentar se conectar com o banco de Dados";
            }
        }
        //metodo para busca de dados
           
    }
}

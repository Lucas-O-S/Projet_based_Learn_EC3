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

        public Cadastro(String nome, String telefone)
        {
            //1. Comando Sql ---para escrever o comando se precisa de uma classe especifica de escrever comando --SqlCommand
            cmd.CommandText = "insert into ex (nome, telefone) values (@nome, @telefone) ";

            //parametros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@telefone", telefone);

            try
            {
                //conectar com banco --Conexão
                cmd.Connection = conexao.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                //mostrar mensagem de erro ou sucesso -- variavel
                this.mensagem = "Cadastro com sucesso!!";
            }
            catch (SqlException e)
            {
                this.mensagem = "erro ao tentar se conectar com o banco de Dados";
            }
            
            
            
        }
    }
}

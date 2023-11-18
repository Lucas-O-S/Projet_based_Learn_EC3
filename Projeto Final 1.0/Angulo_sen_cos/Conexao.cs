using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetilTeste
{
    static class Conexao
    {
        //Variavel de conexão
        static SqlConnection con = new SqlConnection();

        //Variavel que define se esta ou não liberada a conexão com o BD
        public static bool Liberada = false;

        //Cria uma conexão com o BD com base no nome do server, nome do usuario e senha
        static public void CriarConexao(string NServer, string NNome, string NSenha)
        {
            string TextConexao = $"Data Source={NServer}; Initial Catalog=LancamentoBalistico;Integrated Security=false ;User ID={NNome};Password={NSenha}";
            con.ConnectionString = TextConexao;
            //Caso dê certo libera as outras funções
            Liberada = true;
        }


        //Metodo Conectar
        static public SqlConnection conectar()
        {

            if (con.State == System.Data.ConnectionState.Closed)
            {
               con.Open();
             
            }

            return con;
     


        }
        //Metodo Desconectar
        static public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }





    }
}

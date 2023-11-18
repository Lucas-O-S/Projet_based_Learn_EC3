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
        static SqlConnection con = new SqlConnection();

        public static bool Liberada = false;
        static public void CriarConexao(string NServer, string NNome, string NSenha)
        {
            string TextConexao = $"Data Source={NServer}; Initial Catalog=LancamentoBalistico;Integrated Security=false ;User ID={NNome};Password={NSenha}";
            con.ConnectionString = TextConexao;
            Liberada = true;
        }
        //metodo para busca de dados
        //***//


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

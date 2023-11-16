using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_acesso_bancoSQL
{
    class Conexao
    {
        SqlConnection con = new SqlConnection();

        //construtor

        public Conexao()
        {
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DBProjetoInterdisciplinar.mdf;Integrated Security=True;Connect Timeout=30;ApplicationIntent=ReadOnly";
      
        }
        //metodo para busca de dados
        //***//


        //Metodo Conectar
        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //Metodo Desconectar
        public void desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}

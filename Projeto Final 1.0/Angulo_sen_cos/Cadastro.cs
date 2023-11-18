using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjetilTeste
{
    static class Cadastro
    {
        //instancia da classe de comando par gerar comando Sql
        static SqlCommand cmd = new SqlCommand();
        //instancia da classe de conexão para conexão com banco de dados
        //variavel que guarda a mensagem de erro ou sucesso
        public static String mensagem = "";

        public static void CadastroUsuario(string nome, string email)
        {
            try
            {
                if(Conexao.Liberada){
                    cmd.Connection = Conexao.conectar();
                    //conectar com banco de dados

                    //Comando SQL de chamada da SP para cadastro dos dados
                    cmd.CommandText = $"exec SP_INSERT_USUARIO '{nome}', '{email}' ";


                    //executar comando
                    cmd.ExecuteNonQuery();

                    //desconectar
                    Conexao.desconectar();
                    //mostrar mensagem de erro ou sucesso
                    mensagem = "Cadastro de dados Usuario com sucesso!!";
                }
   
            }
            catch (SqlException)
            {
                mensagem = "erro ao tentar se conectar com o banco de Dados";
            }

            Console.WriteLine(mensagem);

        }
        //metodo de cadastro de Projetil e lançamento

        public static void CadastroMeteoro(double posicaoInicialX, double posicaoFinalX, double posicaoInicialY, double posicaoFinalY)
        {

        

            try
            {
                if (Conexao.Liberada)
                {
                    //conectar com banco de dados
                    cmd.Connection = Conexao.conectar();

                    //Comando SQL de chamada da SP para cadastro dos dados
                    cmd.CommandText = $"exec SP_INSERT_DADOS_METEORO {posicaoInicialX}, {posicaoFinalX}, {posicaoInicialY}, {posicaoFinalY}";
                    //Parametros

                    //executar comando
                    cmd.ExecuteNonQuery();
                    //desconectar
                    Conexao.desconectar();
                    //mostrar mensagem de erro ou sucesso
                    mensagem = "Cadastro de dados Meteoro com sucesso!!";

                }
      
            }
            catch (SqlException )
            {
                mensagem = "erro ao tentar se conectar com o banco de Dados";
            }
            Console.WriteLine(mensagem);

        }

        public static void CadastroLP(Double velInicial, Int32 angulo, double posicaoInicialX, double posicaoFinalX, double posicaoInicialY, double posicaoFinalY, Int32 tempo)
        {


            try
            {
                if (Conexao.Liberada)
                {
                    //conectar com banco de dados
                    cmd.Connection = Conexao.conectar();
                    //Comando SQL de chamada da SP para cadastro dos dados
                    cmd.CommandText = $"exec SP_INSERT_DADOS_LP {velInicial}, {angulo}, {posicaoInicialX}, {posicaoFinalX}, {posicaoInicialY}, {posicaoFinalY}, {tempo}";

                    //executar comando
                    cmd.ExecuteNonQuery();
                    //desconectar
                    Conexao.desconectar();
                    //mostrar mensagem de erro ou sucesso
                    mensagem = "Cadastro de dados Usuario e Projetil com sucesso!!";
                }

 
            }
            catch (SqlException )
            {
                mensagem = "erro ao tentar se conectar com o banco de Dados";
            }
            Console.WriteLine(mensagem);

        }

        //Função que ativa SPs de busca com base em angulo ou velocidade
        public static DataTable BuscarDados(string valor, string TipoBusca)
        {
            //Procedure selecionado
            string Procedure;
            //Tabela que sera devolvida
            DataTable Tabela;
            //Angulo pedido
            int angulo = int.Parse(valor); ;
            //Velocidade Pedida
            double Velocidade = double.Parse(valor);

            //Abre conexão
            cmd.Connection = Conexao.conectar();

            //Ativa a SP de busca com base no angulo
            if (TipoBusca == "Angulo")
            {
                Procedure = "sp_ex_dados_angulo";

                cmd.CommandText = $"{Procedure} {angulo}";
            }

            //Ativa a SP de busca com base na velocidade
            else
            {
                Procedure = "sp_ex_dados_velocidade";
                cmd.CommandText = $"{Procedure} {Velocidade}";

            }

            //Função que faz a busca
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Tabela = dataTable;



            }

            //Retorna a tabela
            return Tabela;
            



        }

    }
}

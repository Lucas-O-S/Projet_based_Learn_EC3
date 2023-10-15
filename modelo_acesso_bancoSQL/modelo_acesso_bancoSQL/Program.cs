using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_acesso_bancoSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando as váriaveis que recebem os dados
            string nome="";
            string telefone="";
            //variavel exemplo para enviar dados para banco de dados
            string mandarBanco;
            
            //Abre a tela de cadastro e solicita os dados
            Console.WriteLine("============== Cadastro em Banco de dados ==============/n/n");
            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o telefone: ");
            telefone = Console.ReadLine();
            //Submete os dados ao cadastro caso queira
            Console.WriteLine("Tem certeza que deseja incluir no banco de dados? (s/n) ");
            mandarBanco = Console.ReadLine().ToLower();
            //laço condicional que aciona o cadastro
            try
            {
                if (mandarBanco == "s")
                {
                    //instanciando a conexão
                    Cadastro cadastroNoBancoDadosSql = new Cadastro(nome, telefone);
                }
            }catch (Exception)
            {
                //mensagem de erro para caso não seja valido a resposta
                Console.WriteLine( "Opção não válida.");
            }
            
            
        }
    }
}

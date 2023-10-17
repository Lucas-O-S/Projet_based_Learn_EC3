using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetilTeste
{

    //Classe que busca mostrar os resultados do projetl sendo atirado contra o meteoro
    public static class Encontro
    {
        //Intervalo de tempo desejado para calcular
        private static double intervalo = 0.5;

        //Precisao
        private static double pres = Math.Pow(10, -5);

        //verifica se acertou e se esta subindo
        public static bool Acertou = false, subindo = true;

        //Tempo de subida e descida até o fim
        public static double temposubida=0, Tempodescida=0,tempo = 0;




        //Cria objeto meteoro com velocidade inicial,
        //posição x e y inicial
        private static Meteoro meteoro = new Meteoro(50, 1000, 1000);

        //Cria objeto Projetil com velocidade inicial, angulo e presição
        private static Projetil projetil = new Projetil(0, 0, pres);

        private static Gerenciador gerenciador = new Gerenciador();

        //Variavel para saber se o projetil começou a descer
        private static double projetilPosicaoYantes = projetil.posicaoY0;


        //Pergunta os valores da velocidade e do angulo do projetil 
        private static void PerguntarValor()
        {

            Console.Write("Digite a velocidade desejada: ");
            double velocidadeInicial = double.Parse(Console.ReadLine());
            Console.Write("Digite o angulor desejado: ");
            int angulo = Convert.ToInt32( Console.ReadLine());

            //Muda os valores do projetil
            projetil.MudarValores(velocidadeInicial,angulo,pres);


        }

        //Mostra resultado dos valores colocados
        public static void resultado()
        {
            //Se deve repetir
            bool Continuar=true;
            
            //chama a função para perguntar valores
            PerguntarValor();

            //Loop que se repeti até atingir o meteoro ou um dos dois cairem
            while (Continuar)
            {
                
                //Conta o tempo até o fim
                tempo += intervalo;

                //Calcula o movimento dos objetos
                meteoro.MovY(tempo);
                projetil.MovY(tempo);
                projetil.MovX(tempo);

                //Chama a função que verifica se o projetil está subindo ou descendo

                
                    VerificarSubida();
                

                //Verifica as condições para terminar o Loop
                Continuar = VerificarFim();

                
            }

            //Devolve as informações do teste
            Console.WriteLine($"Metero: ({meteoro.posicaoX0}; {meteoro.posicaoAtualY})");
            Console.WriteLine($"Projetil: ({projetil.posicaoAtualX}; {projetil.posicaoAtualY})");
            Console.WriteLine($"Tempo Total: {tempo}");
            Console.WriteLine($"Tempo subida: {temposubida}");
            Console.WriteLine($"Tempo descida: {Tempodescida}");

            //Manda as informações para o Gerenciador
            gerenciador.Set(projetil.VelocidadeInicial,projetil.AnguloLancamento,tempo,
                temposubida,Tempodescida,Acertou,subindo,meteoro.posicaoAtualX,
                meteoro.posicaoAtualY,projetil.posicaoAtualX,projetil.posicaoAtualY);

        }

        //Função para verificar se o projetil está subindo ou descendo
        private static void VerificarSubida()
        {

            //Se posição no momento anterior for menorr que agora considera que esta descendo
            if (projetilPosicaoYantes >= projetil.posicaoAtualY)
            {
                subindo = false;
            }

            //Salva posição anterior
            projetilPosicaoYantes = projetil.posicaoAtualY;

            //Salva o tempo de subida
            if (subindo)
            {
                temposubida += intervalo;
            }

            //Salva o tempo de descida
            else
            {
                Tempodescida += intervalo;
            }


        }

        //Condições para acabar o teste
        private static bool VerificarFim()
        {

            //Se o projetil atingir o solo acaba
            if (projetil.posicaoAtualY <= 0)
            {
                projetil.posicaoAtualY = 0;
                Console.WriteLine("Você errou, projetil tocou o solo antes do meteoro cair");
                return false;

            }

            //Se o meteoro atingir o solo acaba
            else if (meteoro.posicaoAtualY <= 0)
            {
                meteoro.posicaoAtualY = 0;
                Console.WriteLine("Você errou, meteoro caiu antes do projetil chegar");
                return false;

            }

            //Se a posição arredondada de ambos forem a mesma acaba 
            else if (Math.Round(meteoro.posicaoX0) == Math.Round(projetil.posicaoAtualX) &&
                Math.Round(meteoro.posicaoAtualY) == Math.Round(projetil.posicaoAtualY))
            {

                //Mensagem final

                
                if (subindo)
                {
                    //Caso esteja subindo
                    Console.WriteLine("Parabens! O meteoro foi destruindo enquanto o projetil subia");
                }

                else
                {
                    //Caso esteja descendo
                    Console.WriteLine("Parabens! O meteoro foi destruindo enquanto o projetil descia");

                }
                //Devolve que acertou
                Acertou = true;

                //Retorna para parar
                return false;


            }

            else
            {
                //Caso nenhuma condição aconteça continua
                return true;
            }


        }
    }
}

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

        //Precisao
        public static double pres = Math.Pow(10, -5);

        //verifica se acertou e se esta subindo
        public static bool Acertou = false, subindo = true;

        //Tempo de subida e descida até o fim
        public static double Temposubida=0, Tempodescida=0,tempo = 0;

        
        //Cria objeto meteoro com velocidade inicial,
        private static Meteoro meteoro = new Meteoro(40, 4000, 5000);
        

        //Cria objeto Projetil com velocidade inicial, angulo e presição
        private static Projetil projetil = new Projetil(400, 35, pres);

        //Chama o gerenciador
        private static Gerenciador gerenciador = new Gerenciador();

        //Variavel para saber se o projetil começou a descer
        private static double projetilPosicaoYantes = projetil.posicaoY0, projetilPosicaoXantes = projetil.posicaoX0,
            MeteoroPosicaoYantes = meteoro.posicaoY0, VelocidadeInicial;
        
        //Angulo utilizado e proporçao de quanto 1px vale
        private static int AnguloAtual, proporcao = 10;


        //Defini a velocidade, angulo e reseta os valores
        public static void Definir(double velocidade, int angulo)
        {
            VelocidadeInicial = velocidade;
            AnguloAtual = angulo;
  
            Recomecar();
        }

        //recomeça tudo
        public static void Recomecar()
        {

            //Muda os valores do projetil
            projetil.MudarValores(VelocidadeInicial,AnguloAtual,pres);
            projetilPosicaoXantes = projetil.posicaoX0;
            projetilPosicaoYantes = projetil.posicaoY0;
            meteoro.ResetarPosicao();
            MeteoroPosicaoYantes = meteoro.posicaoY0;
            Temposubida = 0;
            Tempodescida = 0;
            tempo = 0;


        }

        //Arruma o meteoro para ser enviado para o simulador
        public static (int,int) PrepMeteoro()
        {

            return (Convert.ToInt32(Math.Round(meteoro.posicaoX0/proporcao)), Convert.ToInt32(meteoro.posicaoY0/proporcao));
        }

        //Devolve o valor de quanto deve andar o projetil em Y
        public static double ProjPosY(double TempoRecebido)
        {

            projetil.MovY(TempoRecebido);

            double diferenca = projetil.posicaoAtualY - projetilPosicaoYantes ;

            //salva o tempo de subida ou descida
            if (diferenca >= 0)
            {
                Temposubida += 1;
            }

            else if (diferenca < 0 && projetilPosicaoYantes >= 0)
            {
                Tempodescida += 1;
                subindo = false;

            }

            //Salva a posição atual
            projetilPosicaoYantes = projetil.posicaoAtualY;

            // Devolve 0 caso valor não seja o suficiente
            if (projetil.posicaoAtualY <= 0)
            {
                projetil.posicaoAtualY = 0;

                return 0;
            }

            //Devolve valor de Y 
            return Math.Round(diferenca/proporcao);

        }



        public static double ProjPosX(double TempoRecebido)
        {
            projetil.MovX(TempoRecebido);
            double diferenca = projetil.posicaoAtualX - projetilPosicaoXantes;
            projetilPosicaoXantes = projetil.posicaoAtualX;
            if (projetil.posicaoAtualY <= 0)
            {
                return 0;
            }
            return Math.Round(diferenca/proporcao);

        }

        //Devolve o valor de quanto deve andar o projetil em X
        public static double MetPosY(double TempoRecebido)
        {
            meteoro.MovY(TempoRecebido);

            tempo += 1;

            double diferenca = MeteoroPosicaoYantes - meteoro.posicaoAtualY;
            MeteoroPosicaoYantes = meteoro.posicaoAtualY;
            if (meteoro.posicaoAtualY <= 0)
            {
                meteoro.posicaoAtualY = 0;
                return 0;
            }
            return Math.Round(diferenca / proporcao);

        }

        //Mostra resultado dos valores colocados
        public static void resultado()
        {
            Acertou = true;
            //Manda as informações para o Gerenciador
            gerenciador.Set(projetil.VelocidadeInicial,projetil.AnguloLancamento,tempo,
                Temposubida,Tempodescida,Acertou,subindo,meteoro.posicaoAtualX,
                meteoro.posicaoAtualY,projetil.posicaoAtualX,projetil.posicaoAtualY);

        }

  

        //Devolve se meteoro caiu
        public static bool MetCaiu()
        {
            if (meteoro.posicaoAtualY <= 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        //Devolve se Projetil caiu
        public static bool ProjCaiu()
        {
            if (projetil.posicaoAtualY <= 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        //Os proximos apenas devolvem uma string de posição
        public static string getPosicaoProjX()
        {
            return $"{Math.Round(projetil.posicaoAtualX,6)}m";
        }

        public static string getPosicaoProjY()
        {
            return $"{Math.Round(projetil.posicaoAtualY, 6)}m";
        }

        public static string getPosicaoMetX()
        {
            return $"{Math.Round(meteoro.posicaoAtualX, 6)}m";
        }

        public static string getPosicaoMetY()
        {
            return $"{Math.Round(meteoro.posicaoAtualY, 6)}m";
        }

        //Acabou essa parte


        //Teste para buscar angulos ideais de teste
        public static List<string> TesteBtnAngulo()
        {
            //Cria uma lista de valores ideais de velocidade
            List<string> listaValoresValido = new List<string> {};

            //Raio define o quão acima do meio do
            int raio = 125, tempo = 0;

            //Loop que testa velocidade de 0 a 1000 m/s de 10 em 10
            for (int vel = 0; vel <= 1000; vel += 10)
            {

                //Verifica se vai alcançar pelo menos a posição x do meteoro
                if (FormulasFisica.AlcanceHorizontal(vel, AnguloAtual, pres) > meteoro.posicaoX0)
                {
                    //Loop que testa se possivel acertar o meteoro com determinada velocidade conforme o tempo
                    do
                    {

                        //Arruma as variaveis
                        tempo += 1;

                        projetil.VelocidadeInicial = vel;
                        projetil.vX = FormulasFisica.VX0(vel, AnguloAtual);
                        projetil.MovX(tempo);
                        projetil.MovY(tempo);

                        meteoro.MovY(tempo);

                        //Testa se a diferença da posição do meteoro e do projetil em x e y é menor ou
                        //igual ao raio dele significa que o projetil está dentro do meteoro
                        if (Math.Abs(projetil.posicaoAtualY - meteoro.posicaoAtualY)  <= raio
                            && Math.Abs(projetil.posicaoAtualX - meteoro.posicaoAtualX) <= raio)
                        {

                            //Salva o valor da velocidade
                            listaValoresValido.Add(Convert.ToString(vel));






                        }




                    } while (meteoro.posicaoAtualY >= 1);

                    //Reset
                    meteoro.ResetarPosicao();
                    projetil.ResetarPosicao();


                    tempo = 0;

                    }
                meteoro.ResetarPosicao();
                projetil.ResetarPosicao();



            }
            
            //Caso não salve nenhum valor devolve uma resposta
            if (listaValoresValido.Count()==0)
            {
                listaValoresValido.Add("Valor não é suficiente, tente ourto");
            }

            //Retorna a lista
            return listaValoresValido;

            

        }

        //Verifica se ouve o contato entre os dois do mesmo jeito que o de cima
        public static bool Contato()
        {
            if (tempo > 0)
            {
                int Diameto = 125;

                if (Math.Abs(projetil.posicaoAtualY - meteoro.posicaoAtualY) <= Diameto
                   && Math.Abs(projetil.posicaoAtualX - meteoro.posicaoAtualX) <= Diameto)
                {


                    return true;
                }
                else
                {
                    return false;

                }
            }
            else
            {
                return false;
            }

        }
    }


}

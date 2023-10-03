using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angulo_sen_cos
{

    //Classe que calcula seno e cosseno utilizando serie de maclaurin
    public static class Angulo
    {
        //O metodo que calcula cosseno com base em um angulo e a precisão escolhida
        public static double Cos(int angulo, double precisao)
        {
            double cos = 0, teste;
            int iteracoes = 0, ResultadoDerivada;


            while (true){

                //Verifica qual o valor da derivada com x = 0

                //Impar derivada = 0
                if (iteracoes%2 != 0)
                {
                    ResultadoDerivada = 0;
                }
                else
                {
                    //Par

                    //Quando multiplo de 4 a derivada com x =0 é 1
                    if (iteracoes%4==0)
                    {
                        ResultadoDerivada = 1;
                    }

                    //Se não for multiplo de 4 dara -1
                    else
                    {
                        ResultadoDerivada = -1;
                    }
                }

                //Formula da serie de maclaurin
                cos += (ResultadoDerivada * Math.Pow(angulo, iteracoes)) / fatorial(iteracoes);

                //Formula de teste de precisão
                teste = (1 / fatorial(iteracoes + 1)) * (Math.Pow(angulo, iteracoes+1));


                //Teste para verificar precisão
                if (teste < precisao)
                {
                    break;

                }
                else
                {
                    iteracoes += 1;

                }


            }


            //Retorna o cosseno
            return cos;
        }

        //O metodo que calcula Seno com base em um angulo e a precisão escolhida
        public static double Sen(int angulo, double precisao)
        {
            double sen = 0, teste;
            int iteracoes = 0, ResultadoDerivada;

            //Verifica qual o valor da derivada com x = 0

            //Par derivada = 0
            while (true)
            {
                if (iteracoes % 2 == 0)
                {
                    ResultadoDerivada = 0;
                }
                else
                {
                    //Impar

                    //Caso a iteração tenha resto de divisão 1 será 1 a derivada com x = 0
                    if (iteracoes % 4 ==1)
                    {
                        ResultadoDerivada = 1;
                    }

                    //Caso o resto seja 2, será -1, mas usei um else mesmo
                    else 
                    {
                        ResultadoDerivada = -1;
                    }
                }

                //Formula da serie de maclaurin
                sen += (ResultadoDerivada * Math.Pow(angulo, iteracoes)) / fatorial(iteracoes);
                
                //Formula de teste de precisão
                teste = (1 / fatorial(iteracoes + 1)) * (Math.Pow(angulo, iteracoes + 1));

                Console.WriteLine(ResultadoDerivada);

                //Teste para verificar precisão
                if (teste < precisao)
                {
                    break;

                }
                else
                {
                    iteracoes += 1;

                }


            }


            //Retorna o seno procurado
            return sen;
        }

        //Como não há uma função de fatorial pronta eu mesmo fiz esse função 
        private static double fatorial(int iteracoes)
        {
            double resposta = 1;
            for(int  i = 1; i<iteracoes+1; i++)
            {
                resposta = resposta * i;


            }

            return resposta;

        }
    }


}

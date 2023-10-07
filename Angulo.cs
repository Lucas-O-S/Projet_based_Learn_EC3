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
        public static double Cos(double angulo, double precisao)
        {
            double cos = 0, teste, NovoAngulo = ArrumarAngulo(angulo); ;
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
                cos += (ResultadoDerivada * Math.Pow(NovoAngulo, iteracoes)) / fatorial(iteracoes);

                //Formula de teste de precisão
                teste = (1 / fatorial(iteracoes + 1)) * (Math.Pow(NovoAngulo, iteracoes+1));


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
        public static double Sen(double angulo, double precisao)
        {
            double sen = 0, teste, NovoAngulo = ArrumarAngulo(angulo);
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
                sen += (ResultadoDerivada * Math.Pow(NovoAngulo, iteracoes)) / fatorial(iteracoes);
                
                //Formula de teste de precisão
                teste = (1 / fatorial(iteracoes + 1)) * (Math.Pow(NovoAngulo, iteracoes + 1));


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

   

            //Retorna o seno procurado(O negativo é para corrigir valor)
            return -sen;
        }

        //Calcula a tangente atravez do sen e do cos
        public static double Tan(Double angulo, double precisao)
        {
            double tan;
            if (angulo != 90 && angulo != 270)
            {
                tan = Sen(angulo, precisao) / Cos(angulo, precisao);

            }
            //Como cosseno de 90 é 0 isso evita erro de divisão por 0
            else
            {
                tan = 0;
            }

            //Retorna o resultado
            return tan;

        }



        //Como não há uma função de fatorial pronta eu mesmo fiz esse função 
        static double fatorial(int num)
        {
            if (num == 0)
                return 1;
            double result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }

        //Arruma o angulo com base no circulo trigonometrico colocando o valor equivalente
        private static double ArrumarAngulo(double NovoAngulo)
        {
            while(NovoAngulo > 90)
            {
                NovoAngulo -= 360;
            }

            if (NovoAngulo > 90 && NovoAngulo <= 180)
            {
                NovoAngulo  = 180 - NovoAngulo;
                
            }
            else
            {

                if (NovoAngulo > 180 && NovoAngulo <= 270)
                {
                    NovoAngulo = 180 - NovoAngulo;

                }
                else
                {
                    NovoAngulo = 360 - NovoAngulo;
                }
            } 


            //Tranforma o angulo em radianos
            return NovoAngulo * Math.PI / 180;
        }

    }




}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetilTeste
{
    public static class FormulasFisica
    {
        private const Double G = 9.8;





        //Ajusta a velocidade inicial de x 
        public static double VX0(double V0, double Cos)
        {
            Double vx0 = V0 * Cos;

            return vx0;

            /*
            vx0 = Valocidade Inicial X 
            V0 = Velocade inicial
            Cos = Cosseno
              
              
            */
            
            
        }

        //Ajusta a velocidade inicial de x 
        public static double VY0(double Velocidade0, double Sen)
        {
            Double vy0 = Velocidade0 * Sen;

            return vy0;

            /*
            vY0 = Valocidade Inicial Y
            V0 = Velocade inicial
            Sen = Seno


            */

        }

        //Função horaria do espaço no eixo X
        public static double MovX(double SX0, double tempo, double VX0)
        {
            double posicaoX = SX0 + VX0* tempo;
            return posicaoX;

            /*
            posicaoX = Posição no eixo X
            VX0 = Velocade inicial em X
              
              
            */

        }

        //Função horaria do espaço no eixo Y
        public static double MovY(double SY0, double tempo, double VY0)
        {
            double posicaoY = SY0 + VY0*tempo - (G/2)* Math.Pow(tempo,2);
            return posicaoY;

            /*
            posicaoY = Posição no eixo Y
            VY0 = Valocidade Inicial Y
            SY0 = Espaço inicial de Y
              
              
            */
        }

        //Função horaria da velocidade no eixo Y
        public static double VelocY(double SY0, double tempo, double VY0)
        {
            double VelocY = VY0 - G * tempo;
            return VelocY;

            /*
            VelocY = Velocidade em Y
            VY0 = Velocade inicial em Y
              
              
            */
        }

        //Equação de Torricelli no eixo Y
        public static Double TorriVY(double SY0, Double VY0, double DeltaY)
        {
            double VelocY = Math.Sqrt(Math.Pow(VY0,2) - 2*G * DeltaY);
            return VelocY;

            /*
            VelocY = Velocidade em Y
            VY0 = Velocade inicial em Y
            DeltaY = Variação do espaço
              
              
            */
        }

        //Tempo de subida usando VY0
        public static double TempoSubida1(double VY0)
        {
            double tempoSubida = VY0 / G;
            return tempoSubida;


            /*
            VY0 = Velocade inicial em Y
              
              
            */
        }

        //Tempo de subida usando V0
        public static double TempoSubida2(double V0, double Sen)
        {
            double TS = (V0* Sen)/ G;
            return TS;

            /*
            V0 = Velocade inicial
            sen = seno
              
              
            */

        }

        //Tempo de Descida
        public static double TempoDescida(double V0, double Sen)
        {
            double TS = (V0 * Sen) / G;
            return TS;

            /*
            V0 = Velocade inicial
            sen = seno
              
              
            */
        }

        //Calcula altura maxima com vy0
        public static double Hmax1(double VY0)
        {
            double hmax = Math.Pow(VY0, 2)/2*G;
            return hmax;

            /*
            hmax = Altura maxima 
            VY0 = Velocidade inicial de Y
              
              
            */
        }

        //Calcula altura maxima com v0 e sen
        public static double Hmax2(double V0, double sen)
        {
            double hmax = Math.Pow( (V0*sen) , 2) / 2*G;
            return hmax;


            /*
            hmax = Altura maxima 
            V0 = Velocidade inicial
              
              
            */
        }

        //Calcula o Alcance Horizontal do prejetil
        public static double AlcanceHorizontal(double V0, int angulo, double precisao)
        {
            double AlX = (Math.Pow(V0, 2) / G) * Angulo.Sen(2 * angulo, precisao);
            return AlX;

            /*
            AlX = Alcance Horizontal do prejetil
            V0 = Velocidade inical 
              
              
            */
        }

        //Equação da trajetoria 
        public static double EquTrajetoria(double tan,double SX, double V0, double cos)
        {
            double SY = tan * SX - (G / (2 * Math.Pow(V0, 2) * Math.Pow(cos, 2))) * Math.Pow(SX,2) ;
            return SY;
            /*
            SY = Trajetoria
            Tan = Tangente
            SX = posição em X
            V0 = Velocidade inicial
            Cos = cosseno
            
              
              
            */

        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetilTeste
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Precisao
            double pres = Math.Pow(10, -5);

            //Cria objeto meteoro com velocidade inicial(Negativa, pois esta caindo),
            //posição x e y inicial
            RascunhoMeteoro RM = new RascunhoMeteoro(-10,100,1000);

            //Cria objeto Projetil com velocidade inicial, angulo e presição
            RascunhoProjetil RP = new RascunhoProjetil(100,45,pres);

            //Tire o comentario para testar queda do meteoro
            // RM.queda();

            //Tire o comentario para testar movimento do proejetil
            //RP.teste();

            Console.ReadKey();
        }
    }
}

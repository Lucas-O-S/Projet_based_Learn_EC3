using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetilTeste
{
    public class RascunhoMeteoro : Objeto
    {



        //COnstrutor de meteoro
        public RascunhoMeteoro(double velocidadeInicial, Double PosicaoX0, double PosicaoY0)
            : base(velocidadeInicial)
        {
            this.PosicaoX0 = PosicaoX0;
            this.PosicaoY0 = PosicaoY0;
            this.velocidadeInicial = velocidadeInicial;

        }


        //Função para testar o movimento de queda antes da versão final
        public void queda()
        {

            tempo = 1;
            PosicaoAtualY = PosicaoY0;

            while (PosicaoAtualY >= 0)
            {

                PosicaoAtualY = FormulasFisica.MovY(PosicaoY0,tempo,velocidadeInicial);
                Console.WriteLine($"Instante: {tempo}s");
                Console.WriteLine($"Posição: {PosicaoAtualY}");
                if (PosicaoAtualY < 0)
                {
                    Console.WriteLine("Metero atingiu o solo");
                }
                tempo += 1;

            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetilTeste
{
    public class Meteoro : Objeto
    {



        //COnstrutor de meteoro
        public Meteoro(double velocidadeInicial, Double PosicaoX0, double PosicaoY0)
            : base(velocidadeInicial)
        {
            this.PosicaoX0 = PosicaoX0;
            this.PosicaoY0 = PosicaoY0;
            this.velocidadeInicial = velocidadeInicial;
            PosicaoAtualX = PosicaoX0;

        }


        //Movimento de queda do meteoro
        public void MovY(double tempo)
        {
       
            PosicaoAtualY = FormulasFisica.MovYDescendo(PosicaoY0, tempo, velocidadeInicial);

        }

       


    }
}

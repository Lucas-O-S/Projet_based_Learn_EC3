﻿using System;
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
            this.posicaoX0 = PosicaoX0;
            this.posicaoY0 = PosicaoY0;
            this.VelocidadeInicial = velocidadeInicial;
            posicaoAtualX = PosicaoX0;

        }


        //Movimento de queda do meteoro
        public void MovY(double tempo)
        {
       
            posicaoAtualX = FormulasFisica.MovYDescendo(posicaoY0, tempo, VelocidadeInicial);

        }

       


    }
}

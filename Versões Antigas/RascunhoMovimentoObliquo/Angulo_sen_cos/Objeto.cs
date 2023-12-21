using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetilTeste
{
    public class Objeto
    {
        //Classe pai de meteoro e projetil
        public double tempo;
        public Double velocidadeInicial;
        public Double PosicaoAtualX, PosicaoAtualY, PosicaoX0, PosicaoY0;


        public Objeto(double velocidadeInicial)
        {
            this.velocidadeInicial = velocidadeInicial;

        }
    }
}

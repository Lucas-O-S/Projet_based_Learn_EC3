using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetilTeste
{
    public abstract class Objeto
    {
        //Classe pai de meteoro e projetil
        private Double velocidadeInicial;
        private Double PosicaoAtualX, PosicaoAtualY, PosicaoX0, PosicaoY0;
        private double VX, VY;
        double cos, sen;
        private int angulo;



        //Construtor base
        public Objeto(double velocidadeInicial)
        {
            this.velocidadeInicial = velocidadeInicial;

        }

        public double VelocidadeInicial{ get{return velocidadeInicial;} set { velocidadeInicial = value; } }
        public double posicaoAtualX { get { return PosicaoAtualX; } set { PosicaoAtualX = value; } }
        public double posicaoAtualY { get { return PosicaoAtualY; } set { PosicaoAtualY = value; } }
        public double posicaoX0 { get { return PosicaoX0; } set { PosicaoX0 = value; } }
        public double posicaoY0 { get { return PosicaoY0; } set { PosicaoY0 = value; } }
        public double vX { get { return VX; } set { VX = value; } }
        public double vY { get { return VY; } set { VY = value; } }
        public int AnguloLancamento { get { return angulo; } set { angulo = value; } }
        public double Sen { get { return sen; } set { sen = value; } }
        public double Cos { get { return cos; } set { cos = value; } }


        public void ResetarPosicao()
        {
            posicaoAtualX = PosicaoX0;
            posicaoAtualY = PosicaoY0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetilTeste
{
    class Projetil : Objeto
    {
        private double VX,VY,cos,sen;
        private int angulo;

        public double vX { get { return VX; } set { VX = value; } }

        public double vY { get { return VY; } set { VY = value; } }
        public int AnguloLancamento { get { return angulo; } set { angulo = value; } }


        //Construtor de projetil
        public Projetil(double velocidadeInicial, int angulo, double presicao)
            : base(velocidadeInicial)
        {


            this.VelocidadeInicial = velocidadeInicial;
            this.angulo = angulo;
            posicaoX0 = 0;
            posicaoY0 = 0;
            cos = Angulo.Cos(angulo, presicao);
            sen = Angulo.Sen(angulo, presicao);
            VX = FormulasFisica.VX0(velocidadeInicial, cos);
            VY = FormulasFisica.VY0(velocidadeInicial, sen);




        }

        //Calcula o Movimento de X
        public void MovX (double tempoAgora){
            posicaoAtualX = FormulasFisica.MovX(posicaoX0, tempoAgora, VX);
        }

        //Calcula o Movimento de X
        public void MovY(double tempoAgora)
        {
            posicaoAtualY = FormulasFisica.MovYSubindo(posicaoY0, tempoAgora, vY);
        }


        //Alterar valores 
        public void MudarValores(double velocidadeInicial,int angulo, double presicao)
        {
            this.angulo = angulo;
            this.VelocidadeInicial = velocidadeInicial;
            cos = Angulo.Cos(angulo, presicao);
            sen = Angulo.Sen(angulo, presicao);
            VX = FormulasFisica.VX0(velocidadeInicial, cos);
            VY = FormulasFisica.VY0(velocidadeInicial, sen);

        }

    }
}

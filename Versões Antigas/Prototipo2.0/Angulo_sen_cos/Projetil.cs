using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetilTeste
{
    class Projetil : Objeto
    {
        public double VX,V0Y,VY,cos,sen;
        public int angulo;

        //Construtor de projetil
        public Projetil(double velocidadeInicial, int angulo, double presicao)
            : base(velocidadeInicial)
        {


            this.velocidadeInicial = velocidadeInicial;
            this.angulo = angulo;
            PosicaoX0 = 0;
            PosicaoY0 = 0;
            cos = Angulo.Cos(angulo, presicao);
            sen = Angulo.Sen(angulo, presicao);
            VX = FormulasFisica.VX0(velocidadeInicial, cos);
            V0Y = FormulasFisica.VY0(velocidadeInicial, sen);




        }

        //Calcula o Movimento de X
        public void MovX (double tempoAgora){
            PosicaoAtualX = FormulasFisica.MovX(PosicaoX0, tempoAgora, VX);
        }

        //Calcula o Movimento de X
        public void MovY(double tempoAgora)
        {
            PosicaoAtualY = FormulasFisica.MovYSubindo(PosicaoY0, tempoAgora, V0Y);
        }


        //Alterar valores 
        public void MudarValores(double velocidadeInicial,int angulo, double presicao)
        {
            this.angulo = angulo;
            this.velocidadeInicial = velocidadeInicial;
            cos = Angulo.Cos(angulo, presicao);
            sen = Angulo.Sen(angulo, presicao);
            VX = FormulasFisica.VX0(velocidadeInicial, cos);
            V0Y = FormulasFisica.VY0(velocidadeInicial, sen);

        }

    }
}

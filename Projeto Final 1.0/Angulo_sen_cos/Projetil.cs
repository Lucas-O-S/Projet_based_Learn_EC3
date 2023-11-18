using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetilTeste
{
    class Projetil : Objeto
    {


        //Construtor de projetil
        public Projetil(double velocidadeInicial, int angulo)
            : base(velocidadeInicial)
        {


            this.VelocidadeInicial = velocidadeInicial;
            this.AnguloLancamento = angulo;
            posicaoX0 = 0;
            posicaoY0 = 0;
            posicaoAtualX = posicaoX0;
            this.Cos = Angulo.Cos(angulo, Cerebro.pres);
            this.Sen = Angulo.Sen(angulo, Cerebro.pres);
            this.vX = FormulasFisica.VX0(velocidadeInicial, angulo);
            this.vY = FormulasFisica.VY0(velocidadeInicial, Sen);




        }

        //Calcula o Movimento de X
        public void MovX (double tempoAgora){
            
            posicaoAtualX = FormulasFisica.MovX(posicaoX0, tempoAgora, vX);
        }

        //Calcula o Movimento de Y em relação a X
        public void MovY()
        {
            posicaoAtualY = FormulasFisica.EquTrajetoria(AnguloLancamento,posicaoAtualX,VelocidadeInicial);
        }


        //Alterar valores 
        public void MudarValores(double velocidadeInicial,int angulo, double presicao)
        {
            this.AnguloLancamento = angulo;
            this.VelocidadeInicial = velocidadeInicial;
            Cos = Angulo.Cos(angulo, presicao);
            Sen = Angulo.Sen(angulo, presicao);
            vX = FormulasFisica.VX0(velocidadeInicial, angulo);
            vY = FormulasFisica.VY0(velocidadeInicial, Sen);
            ResetarPosicao();
           

        }

    }
}

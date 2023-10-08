using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetilTeste
{
    class RascunhoProjetil : Objeto
    {
        double VX,V0Y,VY,presicao,cos,sen;
        int angulo;

        //Construtor de projetil
        public RascunhoProjetil(double velocidadeInicial, int angulo, double presicao)
            : base(velocidadeInicial)
        {


            this.velocidadeInicial = velocidadeInicial;
            this.angulo = angulo;
            this.presicao = presicao;
            PosicaoX0 = 0;
            PosicaoY0 = 0;
            this.presicao = presicao;
            cos = Angulo.Cos(angulo, presicao);
            sen = Angulo.Sen(angulo, presicao);
            VX = FormulasFisica.VX0(velocidadeInicial, cos);
            V0Y = FormulasFisica.VY0(velocidadeInicial, sen);




        }

        //Calcula o Movimento de X
        private double MovX (double tempoAgora){
            PosicaoAtualX = FormulasFisica.MovX(PosicaoX0, tempoAgora, VX);
            return PosicaoAtualX;
        }

        //Calcula o Movimento de X
        private double MovY(double tempoAgora)
        {
            PosicaoAtualY = FormulasFisica.MovY(PosicaoY0,tempoAgora,V0Y);
            return PosicaoAtualY;
        }

        //Teste do movimento do projetil
        public void teste() {
            tempo = 1;
            do
            {
                Console.WriteLine($"Instante: {tempo}s");
                Console.WriteLine($"PosiçãoX = {MovX(tempo)}");
                Console.WriteLine($"PosiçãoY = {MovY(tempo)}");
                tempo+=1;

            } while (PosicaoAtualY >0);


        }
    }
}

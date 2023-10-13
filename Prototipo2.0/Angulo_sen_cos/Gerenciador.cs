﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetilTeste
{
    public class Gerenciador
    {
        //gerencidador de valores afim de conectar com o banco de dados

        private string VelocidadeInicial, Angulo,TempoTotal,TempoSubida,TempoDescida,
            Acertou,Trajetoria,CordenadaMeteoro,CordenadaProjetil;

        public void Set(
            Double VelocidadeInicial,
            int Angulo,
            double TempoTotal,
            double TempoSubidal,
            double TempoDescida,
            bool Acertou,
            bool Trajetoria,
            double PosicaoXMeteoro,
            double PosicaoYMeteoro,
            double PosicaoXProjetil,
            double PosicaoYProjetil
            )
        {
            this.VelocidadeInicial = Convert.ToString(VelocidadeInicial);
            this.Angulo = Convert.ToString(Angulo);
            this.TempoTotal = Convert.ToString(TempoTotal);
            this.TempoSubida = Convert.ToString(TempoSubidal);
            this.TempoDescida = Convert.ToString(TempoDescida);
            if (Acertou == true)
            {
                this.Acertou = "S";
            }
            else{
                this.Acertou = "N";

            }

            if (Trajetoria == true)
            {
                this.Trajetoria = "Acendente";
            }
            else
            {
                this.Trajetoria = "Descendente";

            }

            CordenadaMeteoro = $"({Math.Round(PosicaoXMeteoro,5)} ; {Math.Round(PosicaoYMeteoro, 5)})";
            CordenadaProjetil = $"({Math.Round(PosicaoXProjetil, 5)} ; {Math.Round(PosicaoYProjetil, 5)})";

        }

        public (string,string,string,string,string,string,string,string,string) get()
        {
            return (VelocidadeInicial, Angulo,TempoTotal,TempoSubida,TempoDescida,
            Acertou,Trajetoria,CordenadaMeteoro,CordenadaProjetil);
        }
    }
}

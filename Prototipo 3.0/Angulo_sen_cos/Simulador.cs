using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetilTeste
{

    //Forms simulador da parabola
    public partial class Simulador : Form
    {
        //função timer que faz a animação
        private Timer timer;
        //Tempo da simulação e angulo utilizado
        private int tempo = 0, Angulo;
        //Velocidade inicial do progetio
        private double V0;

        //Construtor do forms
        public Simulador(double V0, int Angulo)
        {
            InitializeComponent();
            this.Angulo = Angulo;
            this.V0 = V0;



        }

        //Inicializa a simulação
        public void Rodar()
        {

            timer = new Timer();
            timer.Interval = 100; // Timer que faz rodar a animação
            timer.Tick += new EventHandler(Execucao);
            timer.Start();
        }

        //primeira inicialização do form
        private void Form1_Load(object sender, EventArgs e)
        {
            
            Inicializar();
            Rodar();
        }

        //Reset para começar novamente
        private void Inicializar()
        {
            tempo = 0;
            Reset.Enabled = false;
            BtnVoltar.Enabled = false;

            Resultado.Text = "Resultado:";
            Encontro.Definir(V0,Angulo);
            ImgProj.Location = new Point(Chao.Location.X, Chao.Location.Y );
            ImgMet.Location = new Point(Encontro.PrepMeteoro().Item1 + Chao.Location.X, -Encontro.PrepMeteoro().Item2 + Chao.Location.Y -50 );
            Fundo.Invalidate();
        }


        //Executa a animacao
        private void Execucao(object sender, EventArgs e)
        {
            //Pintar o fundo para mostrar o movimento dos objetos
            Desenhar(ImgProj.Location.X-5, ImgProj.Location.Y, 'P');
            Desenhar(ImgMet.Location.X, ImgMet.Location.Y-5, 'M');

            //Chama a função para desligar a imagem quando sai da tela
            DesligarLigarImg();

            //Verifica se acertou
            AcertouAlvo();

            //Soma tempo total
            tempo += 1;

            //Roda a animação
            animacao();


            //Atualiza o texto
            Mostrartexto();


            //Verifica se meteoro e projetil caiu
            Queda();


        }

        //Reseta ao clicar botão reset
        private void Reset_Click(object sender, EventArgs e)
        {
            Inicializar();
            Rodar();
        }

        //Faz o movimento do meteoro e do projetil
        public void animacao()
        {

            //Soma valor acima do meteoro que faz ele descer
            ImgMet.Top += Convert.ToInt32(Encontro.MetPosY(tempo));



            //Soma valor a esquerda do projetil que empurra a direita
            ImgProj.Left += Convert.ToInt32(Encontro.ProjPosX(tempo));

            //Subtrai o valor de cima do projetil fazendo ele subir
            ImgProj.Top -= Convert.ToInt32(Encontro.ProjPosY(tempo));


        }

        //desliga a imagem caso ela saia da tela
        private void DesligarLigarImg()
        {
            if (LimiteHorizontal.Location.X < ImgProj.Location.X || LimiteSuperior.Location.Y > ImgProj.Location.Y)
            {
                ImgProj.Visible = false;
            }
            else
            {
                ImgProj.Visible = true;

            }


        }

        //Atualiza o texto
        private void Mostrartexto()
        {
            ProjX.Text = Encontro.getPosicaoProjX();
            ProjY.Text = Encontro.getPosicaoProjY();

            MetX.Text = Encontro.getPosicaoMetX();
            MetY.Text = Encontro.getPosicaoMetY();



            TempoTotal.Text = $"Tempo Total: {tempo}";
            TempoSubida.Text = $"Tempo Subida: {Encontro.Temposubida}s";
            TempoDescida.Text = $"Tempo Descida: {Encontro.Tempodescida}s";

        }

        //Verifica se meteoro e projetil caiu
        private void Queda()
        {
            //Se projetil cair arruma a posição de queda
            if (Encontro.ProjCaiu())
            {
                ImgProj.Location = new Point(ImgProj.Location.X, Chao.Location.Y - 10);

            }

            //Se meteoro cair arruma a posição de queda
            if (Encontro.MetCaiu())
            {
                ImgMet.Location = new Point(ImgMet.Location.X, Chao.Location.Y - 10);
                MetY.Text = "0m";

            }

            //Desliga quando os dois caem
            if (Encontro.ProjCaiu() && Encontro.MetCaiu())
            {

                timer.Stop();
                Resultado.Text = "Resultado: Errou o alvo";
                Reset.Enabled = true;
                BtnVoltar.Enabled = true;

            }


        }

        //Verifica se o meteoro foi atingido
        private void AcertouAlvo()
        {

            if (Encontro.Contato())
            {
                timer.Stop();
                Resultado.Text = "Resultado: Acetou o alvo";
                Encontro.resultado();
                Reset.Enabled = true;
                BtnVoltar.Enabled = true;



            }
        }


        //Desenha os pontos do fundo da simulação
        private void Desenhar(int X, int Y, char Item)
        {
            //cria uma area retangular para pintar no ponto escolhido
            Rectangle rect = new Rectangle(X, Y, 5, 5);

            //P é de projetil
            if (Item == 'P'){

                using (Graphics g = Fundo.CreateGraphics())
                    g.FillEllipse(Brushes.Red, rect);
            }

            else if (Item == 'M')
            {
                //Pinta a area escohida
                using (Graphics g = Fundo.CreateGraphics())

                    g.FillEllipse(Brushes.Blue, rect);
            }
 

        }

        //Botão para voltar ao ponto inicial
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            
            TelaInicial TI = new TelaInicial();
            TI.Show();
            this.Close();
        }
    }
}

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
    //Tela 
    public partial class TelaInicial : Form
    {
        double velocidade;
        int angulo;
        public TelaInicial()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Muda para o simulador
        private void btnSimulador_Click(object sender, EventArgs e)
        {
            try
            {
                //Puxa a velocidade e o angulo
                velocidade = double.Parse(boxVelocidade.Text);
                angulo = int.Parse(boxAngulo.Text);

                //Chama a tela simulador e fecha
                Simulador sim = new Simulador(velocidade, angulo);
                sim.Show();
                this.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Algo de errado tente de novo");
            }

  
        }

        //Botão de verificar angulo
        private void btnBuscarVel_Click(object sender, EventArgs e)
        {
            try
            {
                //Limpa a lista caso tenha algo
                Lista.Items.Clear();
                
                //Pega o angulo da caixa de texto
                angulo = int.Parse(boxAngulo.Text);

                //Prepara para o teste
                Cerebro.Definir(velocidade, angulo);
               
                //Busca todos os valores
                foreach (string element in Cerebro.TesteBtnAngulo())
                {
                    Lista.Items.Add(element);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Angulo não é suficiente ou invalido");
            }

        }

        //Ativa o botão que chama a tela que muda a posição do meteoro
        private void BtnMetConfig_Click(object sender, EventArgs e)
        {
            MetConfig MC = new MetConfig();
            MC.Show();
            this.Close();
        }

        //Chama a função que busca angulos possiveis para uma velocidade
        private void btnBucarAng_Click(object sender, EventArgs e)
        {
            try
            {
                //Limpa a lista caso tenha algo
                Lista.Items.Clear();

                //Pega o angulo da caixa de texto
                velocidade = double.Parse(boxVelocidade.Text);
                angulo = 1;

                //Prepara para o teste
                Cerebro.Definir(velocidade, angulo);

                //Busca todos os valores
                foreach (string element in Cerebro.TesteBtnVelocidade())
                {
                    Lista.Items.Add(element);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Velocidade não é valida");
            }

        }
    }
}

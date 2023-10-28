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
                Encontro.Definir(velocidade, angulo);
               
                //Busca todos os valores
                foreach (string element in Encontro.TesteBtnAngulo())
                {
                    Lista.Items.Add(element);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Angulo não é suficiente ou invalido");
            }

        }

    }
}

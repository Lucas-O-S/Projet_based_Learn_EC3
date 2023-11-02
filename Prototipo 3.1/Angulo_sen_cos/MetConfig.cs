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
    public partial class MetConfig : Form
    {
        public MetConfig()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaInicial TI = new TelaInicial();
            TI.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cerebro.MudarPosicaoMeteoro(Double.Parse(BoxMetX.Text),Double.Parse(BoxMetY.Text));

            }
            catch (Exception)
            {
                MessageBox.Show("Valores Invalidos");

            }
        }
    }
}

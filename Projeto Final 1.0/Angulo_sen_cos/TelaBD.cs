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
    public partial class TelaBD : Form
    {
        public TelaBD()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void PreencherGrid(DataTable dataTable)
        {
            Tabela.DataSource = dataTable;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                PreencherGrid(Cadastro.BuscarDados(txtValor.Text, cboxEscolha.Text));
                Console.WriteLine(cboxEscolha.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Há algo de errado, tente novamente de outra maneira");


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar(object sender, EventArgs e)
        {
            TelaInicial TI = new TelaInicial();
            TI.Show();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetilTeste
{
    static class Program
    {
        [STAThread]

        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            TelaInicial TI = new TelaInicial();
            TI.Show();
            Application.Run();
            //Encontro.resultado();
            //Console.ReadKey();

        }
    }
}

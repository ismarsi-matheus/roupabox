using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roupabox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cabecalho vercabecalho = new cabecalho();
            vercabecalho.exibir_cabecalho();

            Menu vermenu = new Menu();
            vermenu.ExibirOpcoesMenu();
        }
    }
}

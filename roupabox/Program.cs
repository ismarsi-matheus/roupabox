using Roupabox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roupaboxx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cabec variavelCabecalho = new cabec();
            variavelCabecalho.cabecalho();

            Produtos varPro = new Produtos();
            Cliente VarCli = new Cliente();

            ExibirMenu VariavelMenu = new ExibirMenu();
            VariavelMenu.Menu(varPro, VarCli);

        }
    }

using Roupabox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roupaboxx
{
    internal class ExibirMenu
    {

        public void Menu(Produtos varPro, Cliente varCli)
        {
            List<ProdutoCad> lista = new List<ProdutoCad>();
            while (true)
            {
                Console.WriteLine("Digite 0 para Sair");
                Console.WriteLine("Digite 1 Cadastro de Clientes");
                Console.WriteLine("Digite 2 Listar Clientes");
                Console.WriteLine("Digite 3 Cadastro de Produtos");
                Console.WriteLine("Digite 4 Listar Produtos");
                int numero = int.Parse(Console.ReadLine());

                switch (numero)
                {
                    case 1:

                        varCli.cadCliente();
                        break;
                    case 2:
                        break;
                    case 3:

                        varPro.cadProduto();
                        break;
                    case 4:
                        varPro.ListarProduto();
                        break;
                }
            }
        }
    }
}
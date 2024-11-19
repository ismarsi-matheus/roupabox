using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roupabox
{
    internal class produto
    {
        public void cadProduto()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Produto");
            Console.WriteLine("\nDigite a Marca do Produto");
            string marcaPro=Console.ReadLine();
            Console.WriteLine("\nDigite o tamanho do Produto");
            int tamPro = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDIgite a Cor do Produto");
           string corPro = Console.ReadLine();
            Console.WriteLine("\nDigite a Descrição do Produto");
            string descPro = Console.ReadLine();
            Console.WriteLine("\nDigite o Valor do Produto");
            double valorPro=double.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o Peso do Produto");
            double pesoPro=double.Parse(Console.ReadLine());
        }


    }
}

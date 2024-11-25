using Roupabox;
using roupaboxx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;



namespace Roupabox
{

    internal class Produtos
    {

        List<ProdutoCad> listaProdutos = new List<ProdutoCad>();

        public ProdutoCad cadProduto()
        {


            Console.Clear();
            Console.WriteLine("Registro de Produto");


            Console.WriteLine("\nDigite a descrição do Produto: ");
            string descPro = Console.ReadLine();


            var Produto = new ProdutoCad(descPro);


            Console.WriteLine("\nDigite o marca do Produto: ");
            string marcaPro = Console.ReadLine();
            Produto.marcaPro = marcaPro;


            Console.WriteLine("\nDigite tamanho (P M G GG XGG do Produto: ");
            string tamPro = Console.ReadLine();
            Produto.tamPro = tamPro;

            Console.WriteLine("\nDigite a cor do Produto: ");
            string corPro = Console.ReadLine();
            Produto.corPro = corPro;

            Console.WriteLine("\nDigite a categoria do Produto: ");
            string catPro = Console.ReadLine();
            Produto.catPro = catPro;


            Console.WriteLine("\nDigite o valor do Produto: ");
            double valPro = double.Parse(Console.ReadLine());
            Produto.valPro = valPro;

            Console.WriteLine("\nDigite o peso do Produto: ");
            double pesoPro = double.Parse(Console.ReadLine());
            Produto.pesoPro = pesoPro;


            listaProdutos.Add(Produto);

            Console.WriteLine($"O Produto foi Cadastrado");


            foreach (var produto in listaProdutos)
            {
                Console.WriteLine($"Descrição: {produto.descPro}, " + $"Valor: {produto.valPro} ");
            }



            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();

            cabec variavelCabecalho = new cabec();
            variavelCabecalho.cabecalho();

            Produtos varPro = new Produtos();
            ExibirMenu variavelMenu = new ExibirMenu();

            return Produto;

        }
    }
}
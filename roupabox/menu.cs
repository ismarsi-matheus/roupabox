using System;
using System.Threading;

namespace roupabox
{
    internal class Menu
    {
        
        // Método para exibir as opções do menu
        public void ExibirOpcoesMenu()
        {
            Console.WriteLine("\nMenu de Opções:");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Cadastro de Clientes");
            Console.WriteLine("2 - Listar Clientes");
            Console.WriteLine("3 - Cadastro de Produtos");
            Console.WriteLine("4 - Listar Produtos");
            Console.Write("\nDigite a opção escolhida: ");

            // Tratamento de entrada inválida
            if (!int.TryParse(Console.ReadLine(), out int opcaoEscolhida))
            {
                Console.WriteLine("Opção inválida! Tente novamente.");
                Thread.Sleep(2000);
                Console.Clear();
                ExibirOpcoesMenu();
                return;
            }

            // Navegação pelo menu
            switch (opcaoEscolhida)
            {
                case 0:
                    Sair();
                    break;
                case 1:
                    cliente varCli = new clientes();
                    varCli.cadClientes();
                    break;
                case 2:
                    ListarClientes();
                    break;
                case 3:
                    CadastroDeProdutos();
                    break;
                case 4:
                    ListarProduto();
                    break;
                default:
                    Console.WriteLine("\nOpção inválida! Tente novamente.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    ExibirOpcoesMenu();
                    break;
            }
        }
        // Método para sair do programa
        public void Sair()
        {
            Console.Clear();
            Console.WriteLine("Encerrando o programa...");
            Console.WriteLine(@"
░██████╗░█████╗░██╗███╗░░██╗██████╗░░█████╗░
██╔════╝██╔══██╗██║████╗░██║██╔══██╗██╔══██╗
╚█████╗░███████║██║██╔██╗██║██║░░██║██║░░██║
░╚═══██╗██╔══██║██║██║╚████║██║░░██║██║░░██║
██████╔╝██║░░██║██║██║░╚███║██████╔╝╚█████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝");
            Thread.Sleep(3000);
        }
    }
}

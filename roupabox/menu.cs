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
                Console.ResetColor();
                return;
            }

            // Navegação pelo menu
            switch (opcaoEscolhida)
            {
                case 0:
                    Sair();
                    break;
                case 1:
                    Clientes varCli = new Clientes();
                    varCli.cadCliente();

                    break;
                case 2:
                    break;
                case 3:
                    produto varPro = new produto();
                    varPro.cadProduto();
                    break;
                case 4:
                    
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

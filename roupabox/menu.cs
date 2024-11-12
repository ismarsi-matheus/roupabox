﻿using System;
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
                    CadastroClientes();
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

        // Métodos para cada opção do menu
        public void CadastroClientes()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Clientes");
            Console.WriteLine("Funcionalidade em desenvolvimento...");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesMenu();
        }

        public void ListarClientes()
        {
            Console.Clear();
            Console.WriteLine("Listar Clientes");
            Console.WriteLine("Funcionalidade em desenvolvimento...");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesMenu();
        }

        public void CadastroDeProdutos()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Produtos");
            Console.WriteLine("Funcionalidade em desenvolvimento...");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesMenu();
        }

        public void ListarProduto()
        {
            Console.Clear();
            Console.WriteLine("Listar Produtos");
            Console.WriteLine("Funcionalidade em desenvolvimento...");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal...");
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesMenu();
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
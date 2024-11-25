using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace roupaboxx
{
    internal class Cliente
    {
        public void cadCliente()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░	██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗	██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║	██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║	██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝	██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░	╚═════╝░╚══════╝
░█████╗░██╗░░░░░██╗███████╗███╗░░██╗████████╗███████╗░██████╗
██╔══██╗██║░░░░░██║██╔════╝████╗░██║╚══██╔══╝██╔════╝██╔════╝
██║░░╚═╝██║░░░░░██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░╚█████╗░
██║░░██╗██║░░░░░██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░░╚═══██╗
╚█████╔╝███████╗██║███████╗██║░╚███║░░░██║░░░███████╗██████╔╝
░╚════╝░╚══════╝╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═════╝░");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite o seu nome completo:");
            Console.ResetColor();

            // Lê a entrada do usuário
            string nomeCli = Console.ReadLine();

            // Verifica se todos os caracteres são letras
            if (nomeCli.All(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Nome válido.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: O nome deve conter apenas letras e espaços.");
            }

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite o seu CPF (apenas 11 caracteres numéricos):");
            Console.ResetColor();

            // Lê a entrada do usuário
            string cpfCli = Console.ReadLine().Trim(); // Remove espaços extras

            // Verifica se o CPF tem exatamente 11 caracteres e se todos são numéricos
            if (cpfCli.Length != 11 || !cpfCli.All(Char.IsDigit))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: O CPF deve ter exatamente 11 caracteres numéricos.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("CPF válido.");
                Console.ResetColor();
            }


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite o seu telefone:");
            Console.ResetColor();
            // Lê a entrada do usuário
            string num = Console.ReadLine();

            // Verifica se o CPF tem exatamente 6 caracteres
            if (cpfCli.Length != 11)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: O numero deve ter exatamente 11 caracteres.");
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("numero  válido.");
                Console.ResetColor();
            }


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite a sua idade:");
            Console.ResetColor();
            int idadeCli = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite o seu e-mail:");
            Console.ResetColor();

            // Lê a entrada do usuário
            string emailCli = Console.ReadLine();

            // Expressão regular para validar o formato do e-mail
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Verifica se o e-mail corresponde ao padrão
            if (Regex.IsMatch(emailCli, pattern))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("E-mail válido.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: O e-mail inserido não é válido.");
            }

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite o seu sexo:");
            Console.ResetColor();
            string sexoCli = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite a sua rua:");
            Console.ResetColor();
            string ruaCli = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite o complemento:");
            Console.ResetColor();
            string compCli = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite o número da sua casa:");
            Console.ResetColor();
            int numCli = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite o seu bairro:");
            Console.ResetColor();
            string bairroCli = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite a sua cidade:");
            Console.ResetColor();
            string cidCli = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite o seu estado:");
            Console.ResetColor();
            string estCli = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nDigite o seu CEP:");
            Console.ResetColor();
            int cepCli = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cadastrado realizado com sucesso");
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.Clear();


            cabec cabecalho = new cabec();
            cabecalho.cabecalho();

            ExibirMenu menu = new ExibirMenu();
            //menu.Menu();

            foreach (var cliente in )
            {

            }

        }
    }


}
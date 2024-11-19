using roupabox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roupabox
{
    internal class Clientes
    {
        public void cadCliente()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Clientes");
            Console.WriteLine("\nDigite o nome completo do cliente: ");
            string nomeCli = Console.ReadLine();

            Console.WriteLine("\n Digite o CPF do cliente: ");
            string cpfCli = Console.ReadLine();

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

            Console.WriteLine("\n Digite o telefone do cliente: ");
            long telCli = long.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite a idade do cliente: ");
            int idadeCli = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite o e-mail do cliente: ");
            string emailCli = Console.ReadLine();
            Console.WriteLine("\n Digite o sexo do cliente: ");
            string sexoCli = Console.ReadLine();

            Console.WriteLine("\n Digite a rua/avenida do cliente: ");
            string ruaCli = Console.ReadLine();

            Console.WriteLine("\n Digite o complemento da rua, caso tenha: ");
            string compCli = Console.ReadLine();

            Console.WriteLine("\n Digite o número da casa do cliente: ");
            int numCli = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite o bairro do cliente: ");
            string bairroCli = Console.ReadLine();

            Console.WriteLine("\n Digite a cidade do cliente: ");
            string cidCli = Console.ReadLine();

            Console.WriteLine("\n Digite o estado do cliente: ");
            string estCli = Console.ReadLine();

            Console.WriteLine("\n Digite o CEP do cliente: ");
            int cepCli = int.Parse(Console.ReadLine());

            Console.WriteLine("\nCliente cadastrado com sucesso!!!");
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
            Console.ReadLine();

            Cabec variavelCabecalho = new Cabec();
            variavelCabecalho.exibir_cabecalho();

            ExibirMenu varmenu = new ExibirMenu();
            //varmenu.Menu();

        }
    }
}
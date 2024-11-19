using System;
using System.Linq;
using System.Threading;

namespace roupabox
{

    internal class Clientes
    {
        public void cadCliente()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Clientes");
            Console.WriteLine("\nDigite o Nome Completo do Cliente: ");
            string nomeCli = Console.ReadLine();
            Console.WriteLine("\nDigite o CPF do Cliente");

            string cpfCli = Console.ReadLine();
            while(cpfCli.Length !=11 || !cpfCli.All(char.IsDigit))
            {
                Console.WriteLine("CPF invalido ,tente novamente!");
                cpfCli = Console.ReadLine();
            }
            
            
            Console.WriteLine("\nDigite o Telefone do Cliente: ");
            long telCli = long.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite a idade do Cliente: ");
            string idadeCli =Console.ReadLine();
            Console.WriteLine("\nDigite o E-mail do Clinte: ");
            string emailCli = Console.ReadLine();
            while (!emailCli.Contains("@"))
            {
                Console.WriteLine("o endereço de e-mail noa é valido ,tente novamente !");
                emailCli=Console.ReadLine();
            }
            Console.WriteLine("\n Digite o Sexo do Cliente:  ");
            string sexoCli = Console.ReadLine();
            Console.WriteLine("\nDigite a Rua/AVenida do Cliente: ");
            string ruaCli = Console.ReadLine();
            Console.WriteLine("\nDigite o complemento do Cliente: ");
            string comCli = Console.ReadLine();
            Console.WriteLine("\nDIgite o número da casa: ");
            long numCli = long.Parse(Console.ReadLine());
            Console.WriteLine("\n Digite o Bairro: ");
            string bairroCli = Console.ReadLine();
            Console.WriteLine("\nDigite a Cidade do cliente: ");
            string cidCli = Console.ReadLine();
            Console.WriteLine("\nDigite o Estado do Cliente: ");
            string estCli = Console.ReadLine();
            Console.WriteLine("\nDIgite o CEP do Cliente: ");
            long cepCli = long.Parse(Console.ReadLine());
            Console.WriteLine("\nCliente cadastrado com sucesso!!");



        }
    }
}
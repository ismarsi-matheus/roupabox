using System;
using System.Threading;

namespace roupabox
{

	internal class Clientes
	{
		public void cadClinte() 
		{ 
			Console.Clear();
            Console.WriteLine("Cadastro de Clientes");
			Console.WriteLine("\nDigite o Nome Completo do Cliente: ");
			string nomeCli =Console.ReadLine();
			Console.WriteLine("\nDigite o CPF do Cliente");
			int cpfCli = int.Parse(Console.ReadLine());
			Console.WriteLine("\nDigite o Telefone do Cliente: ");
			int telCli = int.Parse(Console.ReadLine());
			Console.WriteLine("\nDigite a idade do Cliente: ");
			int idadeCli = int.Parse(Console.ReadLine());
			Console.WriteLine("\nDigite o E-mail do Clinte: ");
			string emailCli = Console.ReadLine();
			Console.WriteLine("\n Digite o Sexo do Cliente:  ");
			string sexoCli= Console.ReadLine();
			Console.WriteLine("\nDigite a Rua/AVenida do Cliente: ");
			string ruaCli= Console.ReadLine();
            Console.WriteLine("\nDigite o complemento do Cliente: ");
			string comCli= Console.ReadLine();
            Console.WriteLine("\nDIgite o número da casa: ");
			int numCli=int.Parse(Console.ReadLine());
            Console.WriteLine("\n Digite o Bairro: ");
			string bairroCli =Console.ReadLine();
            Console.WriteLine("\nDigite a Cidade do cliente: ");
			string cidCli = Console.ReadLine();
            Console.WriteLine("\nDigite o Estado do Cliente: ");
			string estCli= Console.ReadLine();
            Console.WriteLine("\nDIgite o CEP do Cliente: ");
			long cepCli=	int.Parse(Console.ReadLine());
			Console.WriteLine("\nCliente cadastrado com sucesso!!");
            


        }
	}
}
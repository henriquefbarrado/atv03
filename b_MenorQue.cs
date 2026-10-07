using System;

namespace ExB_MenorQue
{
	class Program
	{
		public static void Main(string[] args)
		{
			// le os dois numeros
			Console.Write("Digite o primeiro numero inteiro: ");
			int n1 = int.Parse(Console.ReadLine());
			Console.Write("Digite o segundo numero inteiro: ");
			int n2 = int.Parse(Console.ReadLine());

			// ve se o primeiro e menor
			if (n1 < n2)
				Console.WriteLine("O primeiro numero (" + n1 + ") e menor que o segundo (" + n2 + ").");
			else
				Console.WriteLine("O primeiro numero (" + n1 + ") NAO e menor que o segundo (" + n2 + ").");

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}

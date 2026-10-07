using System;

namespace ExG_MenorOuIgual
{
	class Program
	{
		public static void Main(string[] args)
		{
			// leitura dos dois decimais (com virgula)
			Console.Write("Digite o primeiro numero decimal: ");
			double n1 = double.Parse(Console.ReadLine());
			Console.Write("Digite o segundo numero decimal: ");
			double n2 = double.Parse(Console.ReadLine());

			// <= cobre menor ou igual
			if (n1 <= n2)
				Console.WriteLine("O primeiro numero (" + n1 + ") e menor ou igual ao segundo (" + n2 + ").");
			else
				Console.WriteLine("O primeiro numero (" + n1 + ") e maior que o segundo (" + n2 + ").");

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}

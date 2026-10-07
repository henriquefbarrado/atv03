using System;

namespace ExE_MaiorOuIgual
{
	class Program
	{
		public static void Main(string[] args)
		{
			// double guarda numeros com virgula (use virgula ao digitar, ex: 3,5)
			Console.Write("Digite o primeiro numero decimal: ");
			double n1 = double.Parse(Console.ReadLine());
			Console.Write("Digite o segundo numero decimal: ");
			double n2 = double.Parse(Console.ReadLine());

			// >= cobre os dois casos: maior ou igual
			if (n1 >= n2)
				Console.WriteLine("O primeiro numero (" + n1 + ") e maior ou igual ao segundo (" + n2 + ").");
			else
				Console.WriteLine("O primeiro numero (" + n1 + ") e menor que o segundo (" + n2 + ").");

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}

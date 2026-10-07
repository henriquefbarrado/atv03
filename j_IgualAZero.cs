using System;

namespace ExJ_IgualAZero
{
	class Program
	{
		public static void Main(string[] args)
		{
			// le o decimal (use virgula ao digitar)
			Console.Write("Digite um numero decimal: ");
			double n = double.Parse(Console.ReadLine());

			// verifica se e exatamente zero
			if (n == 0)
				Console.WriteLine("O numero e igual a zero.");
			else
				Console.WriteLine("O numero " + n + " e diferente de zero.");

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}

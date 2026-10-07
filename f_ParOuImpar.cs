using System;

namespace ExF_ParOuImpar
{
	class Program
	{
		public static void Main(string[] args)
		{
			// le o numero
			Console.Write("Digite um numero inteiro: ");
			int n = int.Parse(Console.ReadLine());

			// se o resto da divisao por 2 for zero, o numero e par
			if (n % 2 == 0)
				Console.WriteLine("O numero " + n + " e PAR.");
			else
				Console.WriteLine("O numero " + n + " e IMPAR.");

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}

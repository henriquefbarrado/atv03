using System;

namespace ExH_PositivoOuNegativo
{
	class Program
	{
		public static void Main(string[] args)
		{
			// le o numero digitado
			Console.Write("Digite um numero inteiro: ");
			int n = int.Parse(Console.ReadLine());

			// o zero nao e positivo nem negativo, entao trato ele separado
			if (n > 0)
				Console.WriteLine("O numero " + n + " e POSITIVO.");
			else if (n < 0)
				Console.WriteLine("O numero " + n + " e NEGATIVO.");
			else
				Console.WriteLine("O numero e zero (nem positivo nem negativo).");

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}

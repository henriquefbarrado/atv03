using System;

namespace ExA_MaiorQue
{
	class Program
	{
		public static void Main(string[] args)
		{
			// pega os dois valores digitados pelo usuario
			Console.Write("Digite o primeiro numero inteiro: ");
			int n1 = int.Parse(Console.ReadLine());
			Console.Write("Digite o segundo numero inteiro: ");
			int n2 = int.Parse(Console.ReadLine());

			// compara e mostra o resultado na tela
			if (n1 > n2)
				Console.WriteLine("O primeiro numero (" + n1 + ") e maior que o segundo (" + n2 + ").");
			else
				Console.WriteLine("O primeiro numero (" + n1 + ") NAO e maior que o segundo (" + n2 + ").");

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}

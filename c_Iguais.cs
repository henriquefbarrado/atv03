using System;

namespace ExC_Iguais
{
	class Program
	{
		public static void Main(string[] args)
		{
			// entrada dos dois valores
			Console.Write("Digite o primeiro numero inteiro: ");
			int n1 = int.Parse(Console.ReadLine());
			Console.Write("Digite o segundo numero inteiro: ");
			int n2 = int.Parse(Console.ReadLine());

			// atencao: pra comparar usa == (um = so atribui valor)
			if (n1 == n2)
				Console.WriteLine("Os numeros sao iguais.");
			else
				Console.WriteLine("Os numeros sao diferentes.");

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}

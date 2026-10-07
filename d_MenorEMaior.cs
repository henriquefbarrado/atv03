using System;

namespace ExD_MenorEMaior
{
	class Program
	{
		public static void Main(string[] args)
		{
			// aqui sao tres numeros
			Console.Write("Digite o primeiro numero inteiro: ");
			int n1 = int.Parse(Console.ReadLine());
			Console.Write("Digite o segundo numero inteiro: ");
			int n2 = int.Parse(Console.ReadLine());
			Console.Write("Digite o terceiro numero inteiro: ");
			int n3 = int.Parse(Console.ReadLine());

			// as duas condicoes precisam ser verdadeiras ao mesmo tempo, por isso o &&
			if (n1 < n2 && n1 > n3)
				Console.WriteLine("Sim: " + n1 + " e menor que " + n2 + " e maior que " + n3 + ".");
			else
				Console.WriteLine("Nao: " + n1 + " nao e menor que " + n2 + " e maior que " + n3 + " ao mesmo tempo.");

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}

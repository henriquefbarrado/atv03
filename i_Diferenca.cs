using System;

namespace ExI_Diferenca
{
	class Program
	{
		public static void Main(string[] args)
		{
			// pede os dois numeros
			Console.Write("Digite o primeiro numero inteiro: ");
			int n1 = int.Parse(Console.ReadLine());
			Console.Write("Digite o segundo numero inteiro: ");
			int n2 = int.Parse(Console.ReadLine());

			// Math.Abs tira o sinal, assim nao importa qual numero e o maior
			int diferenca = Math.Abs(n1 - n2);

			if (diferenca <= 10)
				Console.WriteLine("A diferenca (" + diferenca + ") e menor ou igual a 10.");
			else
				Console.WriteLine("A diferenca (" + diferenca + ") e maior que 10.");

			Console.Write("\nPressione qualquer tecla para sair...");
			Console.ReadKey(true);
		}
	}
}

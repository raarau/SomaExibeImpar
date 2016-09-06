using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP0338017
{
	class Program
	{



		static void Main(string[] args)
		{
			int cont = 0;
			int numeroUsr;
			int soma = 0;
			

			for (int i = 0; i <= 9; i++)
			{
				Console.WriteLine("Por favor, digite um número: ");
				numeroUsr = int.Parse(Console.ReadLine());

				if (numeroUsr % 2 != 0)
				{
					cont++;
					soma = soma + numeroUsr;
					
				}
				
			}

			Console.WriteLine("O resultado das soma é: " + soma);
			Console.WriteLine("A quantidade de números impares são: " + cont);

			Console.ReadKey();

		}


	}
}

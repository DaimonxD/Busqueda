using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Program program = new Program();
			int resultado = program.Buscar();
			Console.WriteLine("Resultado: " + resultado);
		}
		public int Buscar()
		{
			var target = 5;
			var vec = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			var i = 0;
			while (i <= vec.Count)
			{
				if (vec[i] == target)
				{
					return i;
				}
				i++;
			}
			return -1;
		}

	}
}
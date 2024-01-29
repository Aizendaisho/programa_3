using System;

namespace programa_3 // Note: actual namespace depends on the project name.
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				int numero1 = 0;
				int numero2 = 0;
				int numero3 = 0;
				int numero4 = 0;

				Console.WriteLine("Este programa debes ingresar 4 numeros,\nte informara la suma de los 4 numeros y su promedio,\nacontinuacion ingrese el primer numero: ");
				numero1 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Ingrese el segundo numero: ");
				numero2 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Ingrese el tercer numero: ");
				numero3 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Ingrese el cuarto numero: ");
				numero4 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine($"la suma de los numeros es {numero1 + numero2 + numero3 + numero4}.");
				Console.WriteLine($"el promedio de los numeros es {(numero1 + numero2 + numero3 + numero4) /4}");

			}
			catch (Exception ex)
			{
				Console.WriteLine($"a ocurrido un error: {ex.Message}");
			}
		}
	}
}
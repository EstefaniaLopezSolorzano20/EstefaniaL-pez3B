//Ejercicio 8
//Escribir un programa que escriba todos los múltiplos de 3 del número 1 al 3000 
using System;
class Ejercicio8
{
    static void Main(string[] args)
	{
		int multiplo= 0;
		int conta = 0;

		do{
			Console.WriteLine("Los múltiplos de tres son: {0}", multiplo);
			multiplo = multiplo + 3;
			conta = conta + 1;
		}while (multiplo < 3000);

		Console.WriteLine("los multiplos de 3 son: {0}", conta);
	}
}

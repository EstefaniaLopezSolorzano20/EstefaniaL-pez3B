//Ejercicio 2 
//Crear un programa que lea un número e indique si es par o no 
using System;
class Ejercicio2
{

    static void Main(string[] args)
    {
        Console.Write("El numero es: ");
        double num = double.Parse(Console.ReadLine());
         Console.Write("El numero viene siendo un numero: ");
        if (num % 2 == 0)
            Console.Write("NumeroPar");
        else
            Console.Write("NumeroImpar");

        Console.ReadKey();
    }
}
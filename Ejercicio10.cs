//Ejercicio 10
//Programa que lea un número entero por teclado y que calcule su factorial.
using System;
class Ejercicio10
{
    static void Main(string[] args)
    {
        byte numero, x;
        long TOTAL = 1;
        string linea;
        Console.Write("Ingrese un número: "); linea = Console.ReadLine();
        numero = byte.Parse(linea);
        
        for (x = 2; x <= numero; x++)
        {
            TOTAL=TOTAL*x;
        }
        Console.WriteLine(" El calculo del factorial es  " + TOTAL);
    }
}
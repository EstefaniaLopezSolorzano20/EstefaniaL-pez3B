//Ejercicio 9
//Programa que lea una serie de números (leer hasta que llegue el cero por ejemplo) y que calcule su media aritmética 

using System;
class Ejercicio9
{
    static void Main(string[] args)
    {
        byte calculo, x;
        int numero, suma = 0;
        string linea;
        Console.Write("Límite:"); linea = Console.ReadLine();
        calculo = byte.Parse(linea);
        for (x = 1; x <= calculo; x++)
        {
            Console.Write("Ingrese el número:"); linea = Console.ReadLine();
            numero = int.Parse(linea);
            suma += numero;
        }
        Console.WriteLine("El resultado de la suma es : " + suma);
        Console.WriteLine("El calculo de la media aritmética es: " + suma / calculo);
        
    }
}

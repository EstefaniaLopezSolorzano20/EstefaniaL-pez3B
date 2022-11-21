//Ejercicio 5 
//Escribir un programa que lea exactamente 8 números y luego escriba la suma de todos ellos
using System;
class Ejercicio5
{
     static void Main(string[] args)
    {
        int numero, suma=0, x=0;

        while (x < 8)
        {
            Console.Write("ingrese el numero: ", x + 1);
            numero = int.Parse(Console.ReadLine());
            suma += numero;
            x++;
        }

        Console.WriteLine("el resultado de la suma es: " + suma);
        Console.ReadKey();
    }
}
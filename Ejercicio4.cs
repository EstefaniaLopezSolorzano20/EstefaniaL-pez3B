//Ejercicio 4
//Escribir un programa que lea números enteros indefinidamente hasta que llegue el número 0
using System;
class Ejercicio4
{
    static void Main(string[] args)
    {
        int num = 0;
        do
        {
            Console.WriteLine("ingresa un numero:");
            num = int.Parse(Console.ReadLine());
        } while (num != 0);
    }
}
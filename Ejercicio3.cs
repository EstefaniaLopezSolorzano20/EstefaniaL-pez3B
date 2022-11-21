//Ejercicio 3
// Leer tres números y escribir el mayor de los tres
using System;

class Ejercicio3
{
    static void Main(string[] args)
    {
        byte num1, num2, num3;
        int numeromayor;
        string linea;
        Console.Write("Num1 :"); 
        linea = Console.ReadLine();
        num1 = byte.Parse(linea);
        Console.Write("Num2 :"); 
        linea = Console.ReadLine();
        num2 = byte.Parse(linea);
        Console.Write("Num3 :");
         linea = Console.ReadLine();
        num3 = byte.Parse(linea);
        if ((num1 > num2))
        numeromayor = num1;
        if ((num2 > num1)) 
        numeromayor = num2;
        if ((num3 > num1)) 
        numeromayor = num3;
        if ((num3 < num2))
         numeromayor = num3;
        Console.WriteLine("El mayor es:"+numeromayor);
    }
}
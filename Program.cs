//Ejercicio 1 
//Crear un programa que lea dos números y que escriba el mayor de los dos.
using System;
class Program
{
     static void Main()
    {
        int num1;
        int num2;

        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
            Console.WriteLine("El numero mayor es "+num1);
        else
            Console.WriteLine("El numero mayor es "+num2);
    }
}



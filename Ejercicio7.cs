//Ejercicio 7 
//Escribir un programa que lea tres números e indique el tipo de triángulo que forman (isósceles, equilatero, escaleno).
// Permitir que se pueda repetir indefinidamente si el usuario lo desea (que el ordenador pregunte ¿Quiere continuar? 
//y la persona pueda responder S ó N) 

using System;
class Ejercicio7
{
    static void Main(string[] args)
    {
        int lado1, lado2, lado3;
        string linea;


        Console.Write("lado 1 :"); linea = Console.ReadLine();
        lado1 = int.Parse(linea);

        Console.Write("lado 2 :"); linea = Console.ReadLine();
        lado2 = int.Parse(linea);

        Console.Write("lado 3 :"); linea = Console.ReadLine();
        lado3 = int.Parse(linea);

        if ((lado1 == lado2) & (lado2 == lado3))
        {
            Console.WriteLine("Triángulo equilatero Todos son iguales");
        }else{
            if ((lado1 != lado2) & (lado1 != lado3) & (lado2 != lado3))
            {
                Console.WriteLine("Triángulo escaleno. Ninguno es igual");
            }else{
                Console.WriteLine("Triángulo isósceles. los dos son iguales");
            }
        }
        
    }
}
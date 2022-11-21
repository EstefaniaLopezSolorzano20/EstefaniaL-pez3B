//Ejercicio 6
//Modificar el programa anterior para que en lugar de leer 8 números, se puedan leer tantos números como se quiera hasta que llegue un cero. El resultado es la suma de todos los números leídos.

using System;
class Ejercicio6
{
    static void Main(string[] args)
    {
        int numero = 0, suma=0;
        do
        {
            Console.WriteLine("ingrese el numero:");
            numero = int.Parse(Console.ReadLine());
            suma = suma + numero;

        } while (numero != 0);
        
        Console.WriteLine("el resultado de la suma es: " + suma);
        Console.ReadKey();
    }
}

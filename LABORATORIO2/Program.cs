using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número entero positivo para sumar los primeros N números:");
        int N = Convert.ToInt32(Console.ReadLine());

        int suma = 0;

        for (int i = 1; i <= N; i++)
        {
            suma += i;
        }

        Console.WriteLine("La suma de los primeros " + N + " números es: " + suma);
    }
}

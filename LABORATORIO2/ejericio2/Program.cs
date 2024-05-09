using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número entero positivo:");
        int n = Convert.ToInt32(Console.ReadLine());

        int suma = SumaRecursiva(n);

        Console.WriteLine("La suma de los números del 1 al " + n + " es: " + suma);
    }

    static int SumaRecursiva(int n)
    {
        // Caso base: si n es 1, retorna 1
        if (n == 1)
            return 1;

        // Llamada recursiva para sumar los números del 1 al n-1 y se le suma n
        return n + SumaRecursiva(n - 1);
    }
}


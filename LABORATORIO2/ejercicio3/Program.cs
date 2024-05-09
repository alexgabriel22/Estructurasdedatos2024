using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número entero positivo:");
        int n = Convert.ToInt32(Console.ReadLine());

        ImprimirPiramide(1, n);
    }

    static void ImprimirPiramide(int inicio, int n)
    {
        // Caso base: si hemos alcanzado n+1, termina la recursión
        if (inicio > n + 1)
            return;

        // Imprime los números en la fila actual de la pirámide
        for (int i = 1; i <= inicio; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Llamada recursiva con la siguiente fila de la pirámide
        ImprimirPiramide(inicio + 1, n);
    }
}

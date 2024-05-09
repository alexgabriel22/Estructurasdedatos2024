using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número entero positivo:");
        int n = Convert.ToInt32(Console.ReadLine());

        ImprimirPiramideInvertida(n);
    }

    static void ImprimirPiramideInvertida(int n, int fila = 1)
    {
        // Caso base: si hemos alcanzado n+1, termina la recursión
        if (fila > n + 1)
            return;

        // Imprime los números en la fila actual de la pirámide invertida
        for (int i = n; i >= fila; i--)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();

        // Llamada recursiva con la siguiente fila de la pirámide invertida
        ImprimirPiramideInvertida(n, fila + 1);
    }
}

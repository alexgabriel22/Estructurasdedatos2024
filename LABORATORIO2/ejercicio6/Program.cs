using System;

class Program
{
    static void Main()
    {
        // Definir las dimensiones de la matriz
        int filas = 3;
        int columnas = 4;

        // Crear la matriz de números reales
        double[,] matriz = new double[filas, columnas];

        // Llenar la matriz con valores aleatorios
        Random rnd = new Random();
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = rnd.NextDouble() * 100; // Genera valores aleatorios entre 0 y 100
            }
        }

        // Imprimir la matriz
        Console.WriteLine("Matriz de números reales:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}


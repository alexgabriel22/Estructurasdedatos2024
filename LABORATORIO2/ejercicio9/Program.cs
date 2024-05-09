using System;

class Program
{
    static void Main()
    {
        // Definir las dimensiones de la matriz
        int filas = 5; // Por ejemplo, una matriz de 5x5
        int columnas = 5;

        // Crear la matriz
        int[,] matriz = new int[filas, columnas];

        // Rellenar la matriz con valores de ejemplo
        RellenarMatriz(matriz);

        // Imprimir la matriz
        ImprimirMatriz(matriz);

        // Acceder al elemento central de la matriz
        AccederElementoCentral(matriz);
    }

    static void RellenarMatriz(int[,] matriz)
    {
        // Rellenar la matriz con valores de ejemplo
        int valor = 1;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = valor++;
            }
        }
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        // Imprimir la matriz
        Console.WriteLine("Matriz:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void AccederElementoCentral(int[,] matriz)
    {
        int filaCentral = matriz.GetLength(0) / 2;
        int columnaCentral = matriz.GetLength(1) / 2;

        if (matriz.GetLength(0) % 2 == 0 || matriz.GetLength(1) % 2 == 0)
        {
            Console.WriteLine("La matriz no tiene un único elemento central.");
        }
        else
        {
            Console.WriteLine("El elemento central de la matriz es: " + matriz[filaCentral, columnaCentral]);
        }
    }
}


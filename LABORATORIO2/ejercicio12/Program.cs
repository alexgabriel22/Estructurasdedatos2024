using System;

class Program
{
    static void Main()
    {
        // Definir las dimensiones de la matriz
        int filas = 3;
        int columnas = 3;

        // Crear la matriz
        int[,] matriz = new int[filas, columnas];

        // Rellenar la matriz con valores de ejemplo
        RellenarMatriz(matriz);

        // Imprimir la matriz original
        Console.WriteLine("Matriz original:");
        ImprimirMatriz(matriz);

        // Calcular la media de los elementos de la matriz
        double media = CalcularMediaMatriz(matriz);

        // Imprimir la media
        Console.WriteLine($"La media de los elementos de la matriz es: {media}");
    }

    static void RellenarMatriz(int[,] matriz)
    {
        // Rellenar la matriz con valores de ejemplo
        Random rnd = new Random();
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = rnd.Next(1, 10); // Generar números aleatorios entre 1 y 10
            }
        }
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        // Imprimir la matriz
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

    static double CalcularMediaMatriz(int[,] matriz)
    {
        // Calcular la suma de todos los elementos de la matriz
        int suma = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                suma += matriz[i, j];
            }
        }

        // Calcular el número total de elementos de la matriz
        int totalElementos = matriz.GetLength(0) * matriz.GetLength(1);

        // Calcular la media dividiendo la suma por el número total de elementos
        double media = (double)suma / totalElementos;

        return media;
    }
}

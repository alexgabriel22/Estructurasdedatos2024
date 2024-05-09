using System;

class Program
{
    static void Main()
    {
        // Definir las dimensiones de las matrices
        int filasMatriz1 = 3;
        int columnasMatriz1 = 3;

        int filasMatriz2 = 2;
        int columnasMatriz2 = 2;

        // Crear las matrices
        int[,] matriz1 = new int[filasMatriz1, columnasMatriz1];
        int[,] matriz2 = new int[filasMatriz2, columnasMatriz2];

        // Rellenar las matrices con valores de ejemplo
        RellenarMatriz(matriz1);
        RellenarMatriz(matriz2);

        // Imprimir las matrices
        Console.WriteLine("Matriz 1:");
        ImprimirMatriz(matriz1);

        Console.WriteLine("Matriz 2:");
        ImprimirMatriz(matriz2);

        // Sumar las matrices
        int[,] matrizSuma = SumarMatrices(matriz1, matriz2);

        // Imprimir la matriz suma
        Console.WriteLine("Matriz suma:");
        ImprimirMatriz(matrizSuma);
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

    static int[,] SumarMatrices(int[,] matriz1, int[,] matriz2)
    {
        // Determinar las dimensiones de la matriz resultado
        int filasResultado = Math.Max(matriz1.GetLength(0), matriz2.GetLength(0));
        int columnasResultado = Math.Max(matriz1.GetLength(1), matriz2.GetLength(1));

        // Crear la matriz resultado
        int[,] matrizSuma = new int[filasResultado, columnasResultado];

        // Sumar las matrices elemento por elemento
        for (int i = 0; i < filasResultado; i++)
        {
            for (int j = 0; j < columnasResultado; j++)
            {
                int valorMatriz1 = (i < matriz1.GetLength(0) && j < matriz1.GetLength(1)) ? matriz1[i, j] : 0;
                int valorMatriz2 = (i < matriz2.GetLength(0) && j < matriz2.GetLength(1)) ? matriz2[i, j] : 0;

                matrizSuma[i, j] = valorMatriz1 + valorMatriz2;
            }
        }

        return matrizSuma;
    }
}


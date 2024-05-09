using System;

class Program
{
    static void Main()
    {
        // Definir las dimensiones de la matriz de matrices
        int filas = 3;
        int columnas = 2;

        // Crear la matriz de matrices
        int[][] matrizDeMatrices = new int[filas][];

        // Llenar la matriz con matrices individuales
        for (int i = 0; i < filas; i++)
        {
            matrizDeMatrices[i] = new int[columnas];
            for (int j = 0; j < columnas; j++)
            {
                // Cada elemento de la matriz es una matriz de tamaño fijo
                matrizDeMatrices[i][j] = i + j; // Aquí puedes inicializar cada matriz como desees
            }
        }

        // Imprimir la matriz de matrices
        Console.WriteLine("Matriz de matrices:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matrizDeMatrices[i][j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

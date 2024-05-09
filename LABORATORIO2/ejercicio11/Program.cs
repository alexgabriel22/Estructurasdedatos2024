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

        // Multiplicar la matriz por un número
        int numero = 2;
        int[,] matrizResultado = MultiplicarMatrizPorNumero(matriz, numero);

        // Imprimir la matriz resultado
        Console.WriteLine($"Matriz multiplicada por {numero}:");
        ImprimirMatriz(matrizResultado);
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

    static int[,] MultiplicarMatrizPorNumero(int[,] matriz, int numero)
    {
        // Crear una nueva matriz para almacenar el resultado
        int[,] matrizResultado = new int[matriz.GetLength(0), matriz.GetLength(1)];

        // Multiplicar cada elemento de la matriz por el número
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matrizResultado[i, j] = matriz[i, j] * numero;
            }
        }

        return matrizResultado;
    }
}


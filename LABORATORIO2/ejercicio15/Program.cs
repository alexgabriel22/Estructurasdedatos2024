using System;

class Program
{
    static void Main(string[] args)
    {
        // Ejemplo de una matriz 3x3
        int[,] matriz = {
            { 1, 2, 3 },
            { 4, 9, 6 },
            { 7, 8, 5 }
        };

        // Encontrar el elemento máximo
        int maximo = EncontrarMaximo(matriz);

        Console.WriteLine("El elemento máximo de la matriz es: " + maximo);
    }

    static int EncontrarMaximo(int[,] matriz)
    {
        int maximo = matriz[0, 0];

        // Iterar sobre la matriz y comparar cada elemento con el máximo actual
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] > maximo)
                {
                    maximo = matriz[i, j];
                }
            }
        }

        return maximo;
    }
}


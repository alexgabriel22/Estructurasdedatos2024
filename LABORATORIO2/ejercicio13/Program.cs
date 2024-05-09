using System;

class Program
{
    static void Main(string[] args)
    {
        // Definir el tamaño de la matriz
        int filas = 100;
        int columnas = 100;

        // Crear una instancia del generador de números aleatorios
        Random rnd = new Random();

        // Crear la matriz de números aleatorios
        int[,] matriz = new int[filas, columnas];

        // Llenar la matriz con números aleatorios
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = rnd.Next(1, 101); // Generar un número aleatorio entre 1 y 100
            }
        }

        // Imprimir la matriz (solo para verificar)
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        // Ejemplo de una matriz 3x3
        int[,] matriz = {
            { 1, 2, -1 },
            { -4, -5, 6 },
            { 7, 8, 9 }
        };

        // Encontrar la submatriz de mayor suma
        int[,] submatriz = EncontrarSubmatrizDeMayorSuma(matriz);

        // Imprimir la submatriz de mayor suma
        Console.WriteLine("La submatriz de mayor suma es:");
        ImprimirMatriz(submatriz);
    }

    static int[,] EncontrarSubmatrizDeMayorSuma(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        int maxSuma = int.MinValue;
        int[,] submatrizMaxSuma = null;

        for (int filaInicial = 0; filaInicial < filas; filaInicial++)
        {
            int[] sumaTemporal = new int[columnas];

            for (int filaFinal = filaInicial; filaFinal < filas; filaFinal++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    sumaTemporal[j] += matriz[filaFinal, j];
                }

                int sumaActual = Kadane(sumaTemporal, out int columnaInicial, out int columnaFinal);

                if (sumaActual > maxSuma)
                {
                    maxSuma = sumaActual;
                    submatrizMaxSuma = new int[filaFinal - filaInicial + 1, columnaFinal - columnaInicial + 1];

                    for (int i = filaInicial, k = 0; i <= filaFinal; i++, k++)
                    {
                        for (int j = columnaInicial, l = 0; j <= columnaFinal; j++, l++)
                        {
                            submatrizMaxSuma[k, l] = matriz[i, j];
                        }
                    }
                }
            }
        }

        return submatrizMaxSuma;
    }

    static int Kadane(int[] arr, out int inicio, out int fin)
    {
        int maxSuma = arr[0];
        int sumaActual = arr[0];
        inicio = 0;
        fin = 0;
        int inicioTemp = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > sumaActual + arr[i])
            {
                sumaActual = arr[i];
                inicioTemp = i;
            }
            else
            {
                sumaActual += arr[i];
            }

            if (sumaActual > maxSuma)
            {
                maxSuma = sumaActual;
                inicio = inicioTemp;
                fin = i;
            }
        }

        return maxSuma;
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

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


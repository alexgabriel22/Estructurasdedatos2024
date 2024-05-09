using System;

class Program
{
    static void Main(string[] args)
    {
        // Ejemplo de dos matrices 3x3
        double[,] matriz1 = {
            { 1.0, 2.0, 3.0 },
            { 4.0, 5.0, 6.0 },
            { 7.0, 8.0, 9.0 }
        };

        double[,] matriz2 = {
            { 9.0, 8.0, 7.0 },
            { 6.0, 5.0, 4.0 },
            { 3.0, 2.0, 1.0 }
        };

        // Calcular la matriz de covarianza
        double[,] matrizCovarianza = CalcularMatrizCovarianza(matriz1, matriz2);

        // Imprimir la matriz de covarianza
        Console.WriteLine("Matriz de Covarianza:");
        ImprimirMatriz(matrizCovarianza);
    }

    static double[,] CalcularMatrizCovarianza(double[,] matriz1, double[,] matriz2)
    {
        int filas = matriz1.GetLength(0);
        int columnas = matriz1.GetLength(1);

        // Verificar que ambas matrices tengan las mismas dimensiones
        if (matriz1.GetLength(0) != matriz2.GetLength(0) || matriz1.GetLength(1) != matriz2.GetLength(1))
        {
            throw new ArgumentException("Las matrices deben tener las mismas dimensiones.");
        }

        // Calcular las medias de cada columna en ambas matrices
        double[] mediasMatriz1 = CalcularMediasPorColumna(matriz1);
        double[] mediasMatriz2 = CalcularMediasPorColumna(matriz2);

        // Inicializar la matriz de covarianza
        double[,] matrizCovarianza = new double[columnas, columnas];

        // Calcular la matriz de covarianza muestral
        for (int i = 0; i < columnas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                double covarianza = 0.0;

                for (int k = 0; k < filas; k++)
                {
                    covarianza += (matriz1[k, i] - mediasMatriz1[i]) * (matriz2[k, j] - mediasMatriz2[j]);
                }

                covarianza /= filas - 1;
                matrizCovarianza[i, j] = covarianza;
            }
        }

        return matrizCovarianza;
    }

    static double[] CalcularMediasPorColumna(double[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        double[] medias = new double[columnas];

        for (int j = 0; j < columnas; j++)
        {
            double sumaColumna = 0.0;

            for (int i = 0; i < filas; i++)
            {
                sumaColumna += matriz[i, j];
            }

            medias[j] = sumaColumna / filas;
        }

        return medias;
    }

    static void ImprimirMatriz(double[,] matriz)
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

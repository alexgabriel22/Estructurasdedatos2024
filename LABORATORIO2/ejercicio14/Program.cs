using System;

class Program
{
    static void Main(string[] args)
    {
        // Definir la matriz
        int[,] matriz = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16 }
        };

        // Calcular y mostrar la media de la matriz
        double media = CalcularMedia(matriz);
        Console.WriteLine("Media: " + media);

        // Calcular y mostrar la mediana de la matriz
        double mediana = CalcularMediana(matriz);
        Console.WriteLine("Mediana: " + mediana);

        // Calcular y mostrar la desviación estándar de la matriz
        double desviacionEstandar = CalcularDesviacionEstandar(matriz);
        Console.WriteLine("Desviación Estándar: " + desviacionEstandar);
    }

    static double CalcularMedia(int[,] matriz)
    {
        int totalElementos = matriz.Length;
        double suma = 0;

        // Sumar todos los elementos de la matriz
        foreach (int elemento in matriz)
        {
            suma += elemento;
        }

        // Calcular la media
        return suma / totalElementos;
    }

    static double CalcularMediana(int[,] matriz)
    {
        // Convertir la matriz en una lista para facilitar el cálculo de la mediana
        int totalElementos = matriz.Length;
        int[] elementos = new int[totalElementos];
        int index = 0;

        foreach (int elemento in matriz)
        {
            elementos[index++] = elemento;
        }

        // Ordenar la lista de elementos
        Array.Sort(elementos);

        // Calcular la mediana
        if (totalElementos % 2 == 0)
        {
            // Si el número de elementos es par, la mediana es el promedio de los dos elementos del medio
            int medio1 = elementos[totalElementos / 2 - 1];
            int medio2 = elementos[totalElementos / 2];
            return (medio1 + medio2) / 2.0;
        }
        else
        {
            // Si el número de elementos es impar, la mediana es el elemento del medio
            return elementos[totalElementos / 2];
        }
    }

    static double CalcularDesviacionEstandar(int[,] matriz)
    {
        double media = CalcularMedia(matriz);
        double sumatoriaDiferenciasCuadrado = 0;
        int totalElementos = matriz.Length;

        // Calcular la suma de las diferencias al cuadrado entre cada elemento y la media
        foreach (int elemento in matriz)
        {
            sumatoriaDiferenciasCuadrado += Math.Pow(elemento - media, 2);
        }

        // Calcular la varianza
        double varianza = sumatoriaDiferenciasCuadrado / totalElementos;

        // La desviación estándar es la raíz cuadrada de la varianza
        return Math.Sqrt(varianza);
    }
}

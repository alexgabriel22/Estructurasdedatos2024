using System;

// Definir una clase para números complejos
public class ComplexNumber
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // Método para imprimir números complejos
    public override string ToString()
    {
        if (Imaginary >= 0)
            return $"{Real} + {Imaginary}i";
        else
            return $"{Real} - {-Imaginary}i";
    }
}

class Program
{
    static void Main()
    {
        // Definir las dimensiones de la matriz
        int filas = 2;
        int columnas = 3;

        // Crear la matriz de números complejos
        ComplexNumber[,] matriz = new ComplexNumber[filas, columnas];

        // Llenar la matriz con valores
        matriz[0, 0] = new ComplexNumber(1, 2);
        matriz[0, 1] = new ComplexNumber(-3, 4);
        matriz[0, 2] = new ComplexNumber(5, -6);
        matriz[1, 0] = new ComplexNumber(7, 8);
        matriz[1, 1] = new ComplexNumber(-9, 10);
        matriz[1, 2] = new ComplexNumber(11, 12);

        // Imprimir la matriz
        Console.WriteLine("Matriz de números complejos:");
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

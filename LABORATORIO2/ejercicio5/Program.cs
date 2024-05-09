using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número entero para imprimir su tabla de multiplicar:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el límite de la tabla de multiplicar:");
        int limite = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Tabla de multiplicar del " + n + ":");

        ImprimirTablaMultiplicar(n, 1, limite);
    }

    static void ImprimirTablaMultiplicar(int n, int multiplicador, int limite)
    {
        // Caso base: si el multiplicador supera el límite, termina la recursión
        if (multiplicador > limite)
            return;

        Console.WriteLine(n + " x " + multiplicador + " = " + (n * multiplicador));

        // Llamada recursiva con el siguiente multiplicador
        ImprimirTablaMultiplicar(n, multiplicador + 1, limite);
    }
}


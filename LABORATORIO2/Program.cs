using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Números pares del 1 al 100:");
        ImprimirNumerosPares(1);
    }

    static void ImprimirNumerosPares(int numero)
    {
        // Base case: cuando el número es mayor que 100, termina la recursión
        if (numero > 100)
            return;

        // Si el número es par, imprímelo
        if (numero % 2 == 0)
            Console.WriteLine(numero);

        // Llamada recursiva con el siguiente número
        ImprimirNumerosPares(numero + 1);
    }
}


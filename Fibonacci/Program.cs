using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine()); //Aqui poderá ser definido um numero fixo se desejado ex: int numero = 8;
        bool pertence = PertenceFibonacci(numero);

        if (pertence)
        {
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
        }
    }

    static bool PertenceFibonacci(int n)
    {
        int a = 0, b = 1;
        while (a < n)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a == n;
    }
}

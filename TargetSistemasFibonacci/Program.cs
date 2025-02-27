using System;

class Fibonacci
{
    static bool PertenceFibonacci(int num)
    {
        int a = 0, b = 1, temp;
        while (b < num)
        {
            temp = a;
            a = b;
            b = temp + b;
        }
        return b == num || num == 0;
    }

    static void Main()
    {
        Console.Write("Informe um número: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(PertenceFibonacci(num) ? "Pertence à sequência de Fibonacci." : "Não pertence à sequência de Fibonacci.");
    }
}
using System;

class Program
{
    static void Main()
    {
        int INDICE = 13;
        int SOMA = 0;
        int K = 0;

        while (K < INDICE)
        {
            K += 1;
            SOMA += K;
        }

        Console.WriteLine("Valor de SOMA: " + SOMA); // Resultado esperado: 91
    }
}
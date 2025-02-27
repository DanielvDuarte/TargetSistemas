using System;

class StringInverter
{
    static string InverterString(string s)
    {
        char[] array = s.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }

    static void Main()
    {
        Console.Write("Informe uma string: ");
        string input = Console.ReadLine();
        Console.WriteLine("String invertida: " + InverterString(input));
    }
}

using System;
using System.IO;
using System.Linq;
using System.Text.Json;

class FaturamentoDiario
{
    public double? Valor { get; set; }
}

class Faturamento
{
    static void Main()
    {
        Console.Write("Deseja inserir um arquivo JSON com os dados de faturamento? (S/N): ");
        string resposta = Console.ReadLine().Trim().ToUpper();
        string filePath = "";

        if (resposta == "S")
        {
            Console.Write("Informe o caminho completo do arquivo JSON: ");
            filePath = Console.ReadLine().Trim();
        }

        if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            var faturamento = JsonSerializer.Deserialize<FaturamentoDiario[]>(json);

            var valores = faturamento.Where(d => d.Valor.HasValue).Select(d => d.Valor.Value).ToList();
            double menor = valores.Min();
            double maior = valores.Max();
            double media = valores.Average();
            int diasAcimaDaMedia = valores.Count(v => v > media);

            Console.WriteLine($"Menor faturamento: {menor}");
            Console.WriteLine($"Maior faturamento: {maior}");
            Console.WriteLine($"Dias acima da média: {diasAcimaDaMedia}");
        }
        else
        {
            Console.WriteLine("Nenhum arquivo foi selecionado ou encontrado.");
        }
    }
}
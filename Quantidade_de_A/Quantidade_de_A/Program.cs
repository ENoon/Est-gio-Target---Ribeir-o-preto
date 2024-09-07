using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma string para verificar a presença da letra 'a': ");
        string input = Console.ReadLine();

        int count = CountOccurrences(input, 'a') + CountOccurrences(input, 'A');

        // Exibe os resultados
        if (count > 0)
        {
            Console.WriteLine($"A letra 'a' (ou 'A') aparece {count} vez(es) na string.");
        }
        else
        {
            Console.WriteLine("A letra 'a' (ou 'A') não aparece na string.");
        }
    }

    // Função para contar a ocorrência de uma letra específica na string
    static int CountOccurrences(string input, char letter)
    {
        int count = 0;
        foreach (char c in input)
        {
            if (c == letter)
            {
                count++;
            }
        }
        return count;
    }
}

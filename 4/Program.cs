using System;

class Program
{
    static void Main()
    {
        int[] vetor1 = new int[10];
        int[] vetor2 = new int[10];
        int[] vetor3 = new int[10];

        Console.WriteLine("Digite os valores do primeiro vetor:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Número: ");
            vetor1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nDigite os valores do segundo vetor:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Número: ");
            vetor2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            vetor3[i] = vetor1[i] + vetor2[i];
        }

        Console.WriteLine("\nVetor resultante:");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(vetor3[i]);
        }
    }
}
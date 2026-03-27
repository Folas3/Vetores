using System;

class Program
{
    static void Main()
    {
        int[] vetor = new int[10];
        int aux;

        // Leitura do vetor
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite um número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        // Mostrar vetor original
        Console.WriteLine("\nVetor original:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(vetor[i] + " ");
        }

        // Troca dos elementos
        for (int i = 0; i < 5; i++)
        {
            aux = vetor[i];
            vetor[i] = vetor[9 - i];
            vetor[9 - i] = aux;
        }

        // Mostrar vetor invertido
        Console.WriteLine("\n\nVetor após a troca:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(vetor[i] + " ");
        }
    }
}
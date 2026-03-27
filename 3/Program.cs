using System;

class Program
{
    static void Main()
    {
        int[] vetor = new int[8];
        int numero;
        bool encontrado = false;

        for (int i = 0; i < 8; i++)
        {
            Console.Write("Digite um número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\nDigite um número para procurar: ");
        numero = int.Parse(Console.ReadLine());

        for (int i = 0; i < 8; i++)
        {
            if (vetor[i] == numero)
            {
                Console.WriteLine("Número encontrado na posição: " + i);
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("O número não se encontra no vetor");
        }
    }
}
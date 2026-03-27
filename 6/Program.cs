using System;

class Program
{
    static void Main()
    {
        double[] salarios = new double[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite o salário do funcionário: ");
            salarios[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nSalários reajustados:");

        for (int i = 0; i < 10; i++)
        {
            salarios[i] = salarios[i] * 1.05;
            Console.WriteLine("Funcionário " + (i + 1) + ": " + salarios[i]);
        }
    }
}

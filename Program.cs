using System.Runtime.ConstrainedExecution;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        //PROBLEMA EXEMPLO 1 - VETORES
        //Fazer um programa para ler um número inteiro N e a altura de N pessoas.
        //Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas
        //pessoas

        int n = int.Parse(Console.ReadLine());

        double[] vect = new double[n];

        for(int i = 0; i < n; i++)
        {
            vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        double soma = 0.0;

        for (int i = 0; i < n; i++)
        {
            soma += vect[i]; 
        }

        double media = soma / n;

        Console.WriteLine("Altura média = " + media.ToString("F2", CultureInfo.InvariantCulture));

    }
}
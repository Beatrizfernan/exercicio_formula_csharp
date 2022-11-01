using System;

namespace exercicio3_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor inteiro");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor inteiro");
            int C = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor inteiro");
            int D = int.Parse(Console.ReadLine());


            int DIFERENCA = (A * B - C * D);

            Console.WriteLine("DIFERENCA  = " + DIFERENCA);

        }
    }
}

namespace Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 != 0 && i % 3 == 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine($"A soma dos números ímpares e múltiplos de 3 entre 1 e 500 é de {soma}");
        }
    }
}

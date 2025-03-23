namespace Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para N (de 1 a 10): ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 1 || n > 10)
            {
                Console.WriteLine("Valor inválido");
                return;
            }
            else
            {
                Console.WriteLine($"\nTabuada de {n}: ");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{n} x {i} = {n * i}");
                }
            }

        }
    }
}

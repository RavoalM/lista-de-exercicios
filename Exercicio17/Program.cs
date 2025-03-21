namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor A:");
            decimal a = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o valor B:");
            decimal b = Convert.ToDecimal(Console.ReadLine());

            if (a == b)
            {
                decimal c = a + b;
                Console.WriteLine($"A soma de A e B é {c}");
            }
            else
            {
                decimal c = a * b;
                Console.WriteLine($"A multiplicação de A e B é {c}");
            }
        }
    }
}

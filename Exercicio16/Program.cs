namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            if (2 % valor == 0)
            {
                Console.WriteLine("O valor é par");
            }
            else
            {
                Console.WriteLine("O valor é ímpar");
            }
        }
    }
}

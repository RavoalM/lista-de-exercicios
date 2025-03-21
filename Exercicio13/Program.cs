namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor A: ");
            decimal a1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o valor B: ");
            decimal b2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o valor C: ");
            decimal c3 = Convert.ToDecimal(Console.ReadLine());

            decimal soma = a1 + b2;

            if (soma > c3)
            {
                Console.WriteLine("A soma de A e B é maior que C");
            }
            else
            {
                Console.WriteLine("A soma de A e B não é maior que C");
            }
        }
    }
}

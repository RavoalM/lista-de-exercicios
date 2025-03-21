namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Celsius: ");
            decimal celsius = Convert.ToDecimal(Console.ReadLine());

            decimal resultado = celsius * 1.8m + 32;

            Console.WriteLine($"{celsius}°C é {resultado}°F.");

            Console.ReadLine();
        }
    }
}

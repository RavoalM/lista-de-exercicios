namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a largura do seu terreno: ");
            decimal Largura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a altura do seu terreno: ");
            decimal Altura = Convert.ToDecimal(Console.ReadLine());

            decimal Area = Largura * Altura;

            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine($"As dimensões do seu terreno são \nAltura:{Altura}m\nLargura:{Largura}m");
            Console.WriteLine($"Area:{Area}m");
        }
    }
}

namespace Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota: ");
            decimal Nota1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o peso dela: ");
            decimal Peso1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            decimal Nota2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o peso dela: ");
            decimal Peso2 = Convert.ToDecimal(Console.ReadLine());

            decimal Multiplicação1 = Nota1 * Peso1;

            decimal Multiplicação2 = Nota2 * Peso2;

            decimal NotaFinal = Multiplicação1 + Multiplicação2;

            decimal PesoFinal = Peso1 + Peso2;

            decimal Media = NotaFinal / PesoFinal;

            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine($"A média ponderada das notas inseridas é de {Media:F2}");

            Console.ReadLine();
        }
    }
}

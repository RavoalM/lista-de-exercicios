namespace Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantos pãozinhos foram vendidos: ");
            decimal Pão = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite quantas broas foram vendidos: ");
            decimal Broa = Convert.ToDecimal(Console.ReadLine());

            decimal ValorP = Pão + 0.12m;
            decimal ValorB = Broa + 1.50m;

            decimal Total = ValorP + ValorB;

            decimal poupanca = Total * 0.10m;
            decimal lucro = Total - poupanca;


            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine($"O valor total arrecadado foi de R${Total:F2}");
            Console.WriteLine($"O valor a ser guardado na poupança é de R${poupanca:F2}");
            Console.WriteLine($"O valor de lucro foi R${lucro:F2}");
            Console.ReadLine();
        }
    }
}

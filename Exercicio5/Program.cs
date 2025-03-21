namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salário base: ");
            decimal SalBase = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite seu total de vendas: ");
            decimal TotalVendas = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite seu percentual para o calculo da comissão: ");
            decimal Percentual = Convert.ToDecimal(Console.ReadLine());

            decimal Comissao = (Percentual / 100) * TotalVendas;

            decimal SalarioFinal = SalBase + Comissao;

            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine($"Sua comissão é de R${Comissao}");
            Console.WriteLine($"Seu salário final é de R${SalarioFinal}");

            Console.ReadLine();
        }
    }
}

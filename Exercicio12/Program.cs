namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salário: ");
            decimal Salario = Convert.ToDecimal(Console.ReadLine());

            decimal PerSalario = Salario * 0.15m;
            decimal NovoSalario = Salario + PerSalario;
            decimal Imposto = NovoSalario * 0.08m;
            decimal SalarioFinal = NovoSalario - Imposto;

            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Seu salário inicial era:R${Salario:F2}");
            Console.WriteLine($"Seu salário aumentou para:R${NovoSalario:F2}");
            Console.WriteLine($"Foi removido R${Imposto:F2} de imposto");
            Console.WriteLine($"Seu salário final é R${SalarioFinal:F2}");
            Console.WriteLine("-----------------------------------");
            Console.ReadLine();
        }
    }
}

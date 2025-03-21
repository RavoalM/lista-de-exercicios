namespace Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de notas que deseja inserir: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            decimal[] numeros = new decimal[quantidade];
            decimal somaDosInversos = 0;

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite a {i + 1}ª nota: ");
                numeros[i] = Convert.ToDecimal(Console.ReadLine());
                somaDosInversos += 1 / numeros[i];
            }

            decimal mediaHarmonica = quantidade / somaDosInversos;

            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine($"A média harmônica das notas inseridas é de {mediaHarmonica:F2}");

            Console.ReadLine();
        }
    }
}

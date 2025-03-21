namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            decimal n1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            decimal n2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");
            decimal n3 = Convert.ToDecimal(Console.ReadLine());

            decimal maior, meio, menor;

            if (n1 > n2 && n1 > n3)
            {
                maior = n1;
                if (n2 > n3)
                {
                    meio = n2;
                    menor = n3;
                }
                else
                {
                    meio = n3;
                    menor = n2;
                }
            }
            else if (n2 > n1 && n2 > n3)
            {
                maior = n2;
                if (n1 > n3)
                {
                    meio = n1;
                    menor = n3;
                }
                else
                {
                    meio = n3;
                    menor = n1;
                }
            }
            else
            {
                maior = n3;
                if (n1 > n2)
                {
                    meio = n1;
                    menor = n2;
                }
                else
                {
                    meio = n2;
                    menor = n1;
                }
            }

            Console.WriteLine($"\n-----------------------------------");
            Console.WriteLine($"Os valores em ordem crescente são: {menor}, {meio}, {maior}");
            Console.WriteLine($"Os valores em ordem decrescente são: {maior}, {meio}, {menor}");
        }
    }
}

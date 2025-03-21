namespace Exercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero que deseja saber se é primo: ");
            decimal n1 = Convert.ToDecimal(Console.ReadLine());
            bool primo = true;

            if (n1 < 2)
            {
                primo = false;
            }
            else if (n1 == 2)
            {
                primo = true;
            }
            else if (n1 % 2 == 0)
            {
                primo = false;
            }

            for (int i = 3; i * i <= n1; i += 2)
            {
                if (n1 % i == 0)
                {
                    primo = false;
                    break;
                }
            }

            if (primo)
            {
                Console.WriteLine($"{n1} é primo.");
            }
            else
            {
                Console.WriteLine($"{n1} não é primo.");
            }
        }
    }
}

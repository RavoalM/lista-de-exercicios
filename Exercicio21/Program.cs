namespace Exercicio21
{
    internal class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Digite o valor de A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            int resultado = 1;
            Console.Write($"Fatoração de {a} = ");

                
            for (int i = a; i > 0; i--)
            {
                resultado *= i;
                Console.Write(i);
                    if (i > 1)
                    {
                        Console.Write(" x ");
                    }
            }

            Console.WriteLine($" = {resultado}");
            
        }
    }
}

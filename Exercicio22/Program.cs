namespace Exercicio22
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Digite um numero: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 1;

            Console.Write("Sequência de Fibonacci: ");

               
            while (a <= n)
            {
                Console.Write(a + " ");
                int temp = a;
                a = b;
                b = temp + b;
            }

            Console.WriteLine(); 
            
        }

    }
}

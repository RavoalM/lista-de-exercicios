namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu nome: ");
            String Nome = Console.ReadLine();

            Console.WriteLine("Insira sua idade: ");
            int Idade = Convert.ToInt32(Console.ReadLine());

            int DiasVividos = Idade * 365;

            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine($"{Nome} você tem {Idade} anos e viveu aproximadademente {DiasVividos} dias");
            Console.ReadLine();
        }
    }
}

namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso: ");
            decimal Peso = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite sua altura: ");
            decimal Altura = Convert.ToDecimal(Console.ReadLine());

            decimal IMC = Peso / (Altura * Altura);

            if (IMC < 18.5m)
            {
                Console.WriteLine("\n-----------------------------------");
                Console.WriteLine($"Seu IMC é de {IMC:F2} e você está abaixo");
            }
            else if (IMC >= 18.5m || IMC < 24.9m)
            {
                Console.WriteLine("\n-----------------------------------");
                Console.WriteLine($"Seu IMC é de {IMC:F2} e você está no peso ideal");
            }
            else if (IMC >= 24.9m || IMC < 29.9m)
            {
                Console.WriteLine("\n-----------------------------------");
                Console.WriteLine($"Seu IMC é de {IMC:F2} e você está com sobrepeso");
            }
            else if (IMC >= 29.9m || IMC < 34.9m)
            {
                Console.WriteLine("\n-----------------------------------");
                Console.WriteLine($"Seu IMC é de {IMC:F2} e você está com obesidade grau 1");
            }
            else if (IMC >= 34.9m || IMC < 39.9m)
            {
                Console.WriteLine("\n-----------------------------------");
                Console.WriteLine($"Seu IMC é de {IMC:F2} e você está com obesidade grau 2");
            }
            else
            {
                Console.WriteLine("\n-----------------------------------");
                Console.WriteLine($"Seu IMC é de {IMC:F2} e você está com obesidade grau 3");
            }
        }
    }

}

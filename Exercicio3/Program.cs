namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quilometragem inicial: ");
            double kmInicial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quilometragem final: ");
            double kmFinal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o consumo de combustível após a viagem (litros): ");
            double consumoCombustivel = Convert.ToDouble(Console.ReadLine());

            double distanciaPercorrida = kmFinal - kmInicial;

            double consumoPorKm = distanciaPercorrida / consumoCombustivel;

            Console.WriteLine($"O consumo de combustível durante o percurso foi de ~ {consumoPorKm} km/l");

            Console.ReadLine();
        }
    }
}

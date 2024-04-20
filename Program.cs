using TrabalhoDesignPatternUMC;

class Program
{
    static void Main(string[] args)
    {
        int opcao = 0;
        
        do
        {
            Console.WriteLine("╔═══════════════════════════════╗");
            Console.WriteLine("║          Calculadora          ║");
            Console.WriteLine("╠═══════════════════════════════╣");
            Console.WriteLine("║ Escolha a opção desejada:     ║");
            Console.WriteLine("║                               ║");
            Console.WriteLine("║ 1 Soma                        ║");
            Console.WriteLine("║ 2 Subtração                   ║");
            Console.WriteLine("║ 3 Multiplicação               ║");
            Console.WriteLine("║ 4 Divisão                     ║");
            Console.WriteLine("║                               ║");
            Console.WriteLine("╠═══════════════════════════════╣");
            Console.WriteLine("║ 0. Sair                       ║");
            Console.WriteLine("╚═══════════════════════════════╝");
            Console.Write("\nOpção: ");

            opcao = int.Parse(Console.ReadLine());

            SingletonCircuitBreaker singleton = SingletonCircuitBreaker.GetInstance();
            singleton.verificacaoCircuitBreaker(opcao);
            
        } while (opcao != 0);
    }
}
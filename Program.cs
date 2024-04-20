class Program
{
    static void Main(string[] args)
    {
        int opcao = 0;

        Soma soma = new Soma();
        Subtracao subtracao = new Subtracao();
        Multiplicacao multiplicacao = new Multiplicacao();
        Divisao divisao = new Divisao();
        
        do
        {
            Console.Clear();

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
            switch (opcao)
            {
                case 1:
                    soma.Executar();
                    break;
                case 2:
                    subtracao.Executar();
                    break;
                case 3:
                    multiplicacao.Executar();
                    break;
                case 4:
                    divisao.Executar();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    return;
            }
        } while (opcao != 0);
    }
}
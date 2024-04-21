class Divisao : Command
{
    
    private int tempoRequisicao;

    public int inserirValores()
    {
        double numA;
        double numB;
        
        bool loopParse = true;
        do {
            try {
                Console.Clear();
                
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(@" _______  ______ __     __ ______  ______   ______   ______   ______   ______  
|       \|      \  \   |  \      \/      \ /      \ /      \ /      \ /      \ 
| ▓▓▓▓▓▓▓\\▓▓▓▓▓▓ ▓▓   | ▓▓\▓▓▓▓▓▓  ▓▓▓▓▓▓\  ▓▓▓▓▓▓\  ▓▓▓▓▓▓\  ▓▓▓▓▓▓\  ▓▓▓▓▓▓\
| ▓▓  | ▓▓ | ▓▓ | ▓▓   | ▓▓ | ▓▓ | ▓▓___\▓▓ ▓▓__| ▓▓ ▓▓___\▓▓ ▓▓__| ▓▓ ▓▓  | ▓▓
| ▓▓  | ▓▓ | ▓▓  \▓▓\ /  ▓▓ | ▓▓  \▓▓    \| ▓▓    ▓▓\▓▓    \| ▓▓    ▓▓ ▓▓  | ▓▓
| ▓▓  | ▓▓ | ▓▓   \▓▓\  ▓▓  | ▓▓  _\▓▓▓▓▓▓\ ▓▓▓▓▓▓▓▓_\▓▓▓▓▓▓\ ▓▓▓▓▓▓▓▓ ▓▓  | ▓▓
| ▓▓__/ ▓▓_| ▓▓_   \▓▓ ▓▓  _| ▓▓_|  \__| ▓▓ ▓▓  | ▓▓  \__| ▓▓ ▓▓  | ▓▓ ▓▓__/ ▓▓
| ▓▓    ▓▓   ▓▓ \   \▓▓▓  |   ▓▓ \\▓▓    ▓▓ ▓▓  | ▓▓\▓▓    ▓▓ ▓▓  | ▓▓\▓▓    ▓▓
 \▓▓▓▓▓▓▓ \▓▓▓▓▓▓    \▓    \▓▓▓▓▓▓ \▓▓▓▓▓▓ \▓▓   \▓▓ \▓▓▓▓▓▓ \▓▓   \▓▓ \▓▓▓▓▓▓
");
                Console.ResetColor();
                
                Console.Write("Digite o primeiro valor: ");
                numA = int.Parse(Console.ReadLine());
        
                Console.Write("Digite o segundo valor: ");
                numB = int.Parse(Console.ReadLine());

                Console.Write("Calculando...");
                double resultado = calcular(numA, numB);
        
                Console.WriteLine($"\n{numA} ÷ {numB} = {resultado}");
                
                loopParse = false;
            } catch (FormatException) {
                Console.Clear();
                Console.WriteLine("Digite um valor válido");
        
                Console.WriteLine("\nPressione ENTER para coninuar");
                Console.ReadLine();
            }
        } while (loopParse);
        Console.WriteLine("\nPressione ENTER para coninuar");
        Console.ReadLine();
        return tempoRequisicao;
    }
    
    public double calcular(double numA, double numB)
    {
        Random random = new Random();
        tempoRequisicao = random.Next(5000, 10000);
        Thread.Sleep(tempoRequisicao); 
        double resultado = numA - numB;
        return resultado;
    }
}
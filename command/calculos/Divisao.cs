class Divisao : Command
{
    public void Executar()
    {
        int numA;
        int numB;
        
        bool loopParse = true;
        do {
            try {
                Console.Clear();
                
                Console.Write("Digite o primeiro valor: ");
                numA = int.Parse(Console.ReadLine());
        
                Console.Write("Digite o segundo valor: ");
                numB = int.Parse(Console.ReadLine());
                
                int resultDivisao = numA / numB;
        
                Console.WriteLine($"\n{numA} ÷ {numB} = {resultDivisao}");
                
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
    }
}
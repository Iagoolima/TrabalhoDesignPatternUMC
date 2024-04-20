class Soma : Command
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
                
                int resultSoma = numA + numB;
        
                Console.WriteLine($"\n{numA} + {numB} = {resultSoma}");
                
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
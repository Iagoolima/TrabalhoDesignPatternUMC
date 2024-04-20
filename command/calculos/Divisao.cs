class Divisao : Command
{
    public void inserirValores()
    {
        double numA;
        double numB;
        
        bool loopParse = true;
        do {
            try {
                Console.Clear();
                
                Console.Write("Digite o primeiro valor: ");
                numA = int.Parse(Console.ReadLine());
        
                Console.Write("Digite o segundo valor: ");
                numB = int.Parse(Console.ReadLine());

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
    }
    
    public double calcular(double numA, double numB)
    {
        Random random = new Random();
        int timerDuration = random.Next(1, 11);
        Thread.Sleep(5000); // 5000 milissegundos = 5 segundos

        double resultado = numA - numB;
        return resultado;
    }
}
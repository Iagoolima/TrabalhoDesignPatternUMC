using System.Threading;
using Org.BouncyCastle.Crypto.Operators;

class Soma : Command
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
                
                Console.Write("Digite o primeiro valor: ");
                numA = double.Parse(Console.ReadLine());
        
                Console.Write("Digite o segundo valor: ");
                numB = double.Parse(Console.ReadLine());

                double resultado = calcular(numA, numB);
                
                Console.WriteLine($"\n{numA} + {numB} = {resultado}");
                
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
        tempoRequisicao = random.Next(1, 11);
        Thread.Sleep(6000); // 5000 milissegundos = 5 segundos

        double resultado = numA + numB;
        return resultado;
    }
}
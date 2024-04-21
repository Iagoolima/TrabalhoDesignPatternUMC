using System.Diagnostics;
using TrabalhoDesignPatternUMC.circuitBreakerMetodos;
using TrabalhoDesignPatternUMC.estados;
using TrabalhoDesignPatternUMC.estados.estadosConcretos;

namespace TrabalhoDesignPatternUMC;

public sealed class SingletonCircuitBreaker
{
    private Contexto _contexto = new Contexto(new Fechado());
    private SingletonCircuitBreaker()
    {
    }

    private static SingletonCircuitBreaker? _instance;

    public static SingletonCircuitBreaker GetInstance()
    {
        if (_instance == null)
        {
            _instance = new SingletonCircuitBreaker();
        }

        return _instance;
    }
    
    
    public void verificacaoCircuitBreaker(int metodo)
    {
        do{
            
            
            switch (metodo)
            {

                case 1:
                    if (_contexto.GetEstadoAtual() as Fechado != null)
                    {
                        CircuitBreakerSoma circuitBreakerSoma = new CircuitBreakerSoma(_contexto);
                        circuitBreakerSoma.monitorarSoma();
                    }
                    metodo = 0;
                    break;
                
                case 2:
                    if (_contexto.GetEstadoAtual() as Fechado != null)
                    {
                        CircuitBreakerSubtracao circuitBreakerSubtracao = new CircuitBreakerSubtracao(_contexto);
                        circuitBreakerSubtracao.monitorarSubtracao();
                    }
                    metodo = 0;
                    break;
                
                case 3:
                    if (_contexto.GetEstadoAtual() as Fechado != null)
                    {
                        CircuitBreakerMultiplicacao circuitBreakerMultiplicacao = new CircuitBreakerMultiplicacao(_contexto);
                        circuitBreakerMultiplicacao.monitorarMultiplicacao();
                        
                    }
                    
                    metodo = 0;
                    break;
                
                case 4:
                    if (_contexto.GetEstadoAtual() as Fechado != null)
                    {
                        CircuitBreakerDivisao circuitBreakerDivisao = new CircuitBreakerDivisao(_contexto);
                        circuitBreakerDivisao.monitorarDivisao();
                    }
                    metodo = 0;
                    break;
                
                case 0:
                    Console.WriteLine("Saindo...");
                    return;
                
                default:
                    Console.WriteLine("Numero invalido");
                    return;
            }
        } while (metodo != 0);
    }
}

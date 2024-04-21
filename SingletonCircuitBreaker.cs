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
                    if (_contexto.Request1())
                    {
                        CircuitBreakerSoma circuitBreakerSoma = new CircuitBreakerSoma();
                        bool estadoSoma = circuitBreakerSoma.monitorarSoma();
                        if (!estadoSoma)
                        {
                            _contexto.TransitionTo(new Aberto());
                        }
                    }
                    metodo = 0;
                    break;
                
                case 2:
                    if (_contexto.Request1())
                    {
                        CircuitBreakerSubtracao circuitBreakerSubtracao = new CircuitBreakerSubtracao();
                        bool estadoSubtracao = circuitBreakerSubtracao.monitorarSubtracao();
                        if (!estadoSubtracao)
                        {
                            _contexto.TransitionTo(new Aberto());
                        }
                    }
                    metodo = 0;
                    break;
                
                case 3:
                    if (_contexto.Request1())
                    {
                        CircuitBreakerMultiplicacao circuitBreakerMultiplicacao = new CircuitBreakerMultiplicacao();
                        bool estadoMultiplicacao = circuitBreakerMultiplicacao.monitorarMultiplicacao();
                        if (!estadoMultiplicacao)
                        {
                            _contexto.TransitionTo(new Aberto());
                        }
                    }
                    metodo = 0;
                    break;
                
                case 4:
                    if (_contexto.Request1())
                    {
                        CircuitBreakerDivisao circuitBreakerDivisao = new CircuitBreakerDivisao();
                        bool estadoDivisao = circuitBreakerDivisao.monitorarDivisao();
                        if (!estadoDivisao)
                        {
                            _contexto.TransitionTo(new Aberto());
                        }
                    }
                    metodo = 0;
                    break;
                
                case 0:
                    Console.WriteLine("Saindo...");
                    return;
            }
        } while (metodo != 0);
    }
}

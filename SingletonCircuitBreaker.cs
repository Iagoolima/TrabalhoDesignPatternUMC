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
                        bool estadoSoma = circuitBreakerSoma.monitorar();
                        if (!estadoSoma)
                        {
                            _contexto.TransitionTo(new Aberto());
                        }
                    }
                    metodo = 0;
                    break;
                // case 2:
                //     Subtracao subtracao = new Subtracao();
                //     subtracao.Executar();
                //     break;
                // case 3:
                //     Multiplicacao multiplicacao = new Multiplicacao();
                //     multiplicacao.Executar();
                //     break;
                // case 4:
                //     Divisao divisao = new Divisao();
                //     divisao.Executar();
                //     break;
                case 0:
                    Console.WriteLine("Saindo...");
                    return;
            }
        } while (metodo != 0);
    }
}

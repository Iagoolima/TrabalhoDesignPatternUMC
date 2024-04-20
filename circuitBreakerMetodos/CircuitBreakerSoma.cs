using System.Diagnostics;
using TrabalhoDesignPatternUMC.domain;
using TrabalhoDesignPatternUMC.Service;

namespace TrabalhoDesignPatternUMC.circuitBreakerMetodos;

public partial class CircuitBreakerSoma : EstadosMetodos
{
    public void monitorar(SingletonCircuitBreaker estado)
    {
        Random random = new Random();
        int tempoRequisicao = random.Next(5, 10);
       
        Stopwatch stopwatch = Stopwatch.StartNew(); 
        Soma soma = new Soma();
                    
        int tempoExecutado = soma.inserirValores();
                    
        long tempoDecorrido = stopwatch.ElapsedMilliseconds;
        stopwatch.Stop();
                    
        if (tempoDecorrido > tempoRequisicao)
        {
            Console.WriteLine($"Operação de soma levou {tempoDecorrido / 1000} segundos. Circuit Breaker acionado.");
            estado.setSoma(false);

            Registros registro = new Registros();
            registro.setCalculo("soma");
            registro.setRequisicao(tempoRequisicao);
            registro.setTempoLimite(tempoExecutado);

            RegistrarDAO DAO = new RegistrarDAO();
            DAO.InserirRegistroDAO(registro);
        }
        else
        {
            Console.WriteLine($"Operação de soma concluída em {tempoDecorrido / 1000} segundos.");
        }
        
    }
}
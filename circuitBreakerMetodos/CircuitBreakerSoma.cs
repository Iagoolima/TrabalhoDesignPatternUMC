using System.Diagnostics;
using TrabalhoDesignPatternUMC.domain;
using TrabalhoDesignPatternUMC.Service;

namespace TrabalhoDesignPatternUMC.circuitBreakerMetodos;

public partial class CircuitBreakerSoma : EstadosMetodos
{
    public void monitorar(SingletonCircuitBreaker estado)
    {
        int tempoLimite = 7;
       
        Stopwatch stopwatch = Stopwatch.StartNew();
        Soma soma = new Soma();
        int tempoExecutado = soma.inserirValores();
        long tempoDecorrido = stopwatch.ElapsedMilliseconds / 1000;
        Console.WriteLine(tempoDecorrido);
        stopwatch.Stop();
                    
        if (tempoDecorrido > tempoLimite)
        {
            estado.setSoma(false);

            Registros registro = new Registros();
            registro.setCalculo("soma");
            registro.setRequisicao(tempoExecutado);
            registro.setTempoLimite(tempoLimite);

            RegistrarDAO DAO = new RegistrarDAO();
            DAO.InserirRegistroDAO(registro);
        }
    }
}
using System.Diagnostics;
using TrabalhoDesignPatternUMC.domain;
using TrabalhoDesignPatternUMC.estados.estadosConcretos;
using TrabalhoDesignPatternUMC.Service;

namespace TrabalhoDesignPatternUMC.circuitBreakerMetodos;

public partial class CircuitBreakerDivisao
{
    public bool monitorarDivisao()
    {
        int tempoLimite = 7;

        Stopwatch stopwatch = Stopwatch.StartNew();
        Divisao divisao = new Divisao();
        int tempoExecutado = divisao.inserirValores();
        long tempoDecorrido = stopwatch.ElapsedMilliseconds / 1000;
        Console.WriteLine(tempoDecorrido);
        stopwatch.Stop();
        
        if (tempoDecorrido > tempoLimite)
        {
            Registros registro = new Registros();
            registro.setCalculo("divisao");
            registro.setRequisicao(tempoExecutado);
            registro.setTempoLimite(tempoLimite);

            RegistrarDAO DAO = new RegistrarDAO();
            DAO.InserirRegistroDAO(registro);

            return false;
        }

        return true;
    }
}
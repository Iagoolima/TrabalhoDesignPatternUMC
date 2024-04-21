using System.Diagnostics;
using TrabalhoDesignPatternUMC.domain;
using TrabalhoDesignPatternUMC.estados.estadosConcretos;
using TrabalhoDesignPatternUMC.Service;

namespace TrabalhoDesignPatternUMC.circuitBreakerMetodos;

public partial class CircuitBreakerSubtracao
{
    public bool monitorarSubtracao()
    {
        int tempoLimite = 7;

        Stopwatch stopwatch = Stopwatch.StartNew();
        Subtracao subtracao = new Subtracao();
        int tempoExecutado = subtracao.inserirValores();
        long tempoDecorrido = stopwatch.ElapsedMilliseconds / 1000;
        Console.WriteLine(tempoDecorrido);
        stopwatch.Stop();
        
        if (tempoDecorrido > tempoLimite)
        {
            Registros registro = new Registros();
            registro.setCalculo("subtracao");
            registro.setRequisicao(tempoExecutado);
            registro.setTempoLimite(tempoLimite);

            RegistrarDAO DAO = new RegistrarDAO();
            DAO.InserirRegistroDAO(registro);

            return false;
        }

        return true;
    }
}
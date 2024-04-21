using System.Diagnostics;
using TrabalhoDesignPatternUMC.domain;
using TrabalhoDesignPatternUMC.estados;
using TrabalhoDesignPatternUMC.estados.estadosConcretos;
using TrabalhoDesignPatternUMC.Service;

namespace TrabalhoDesignPatternUMC.circuitBreakerMetodos;

public class CircuitBreakerMultiplicacao
{
    private readonly Contexto _contexto;

    public CircuitBreakerMultiplicacao(Contexto contexto)
    {
        _contexto = contexto;
    }
    public void monitorarMultiplicacao()
    {
        int tempoLimite = 7;

        Stopwatch stopwatch = Stopwatch.StartNew();
        Multiplicacao multiiplicacao = new Multiplicacao();
        int tempoExecutado = multiiplicacao.inserirValores();
        long tempoDecorrido = stopwatch.ElapsedMilliseconds / 1000;
        Console.WriteLine(tempoDecorrido);
        stopwatch.Stop();
        
        if (tempoDecorrido > tempoLimite)
        {
            Console.WriteLine("aguarde ... ");
            
            Registros registro = new Registros();
            registro.setCalculo("multiiplicacao");
            registro.setRequisicao(tempoExecutado);
            registro.setTempoLimite(tempoLimite);

            RegistrarDAO DAO = new RegistrarDAO();
            DAO.InserirRegistroDAO(registro);

            Estado estadoAtual = _contexto.GetEstadoAtual();
            if (estadoAtual is Fechado fechado)
            {
                fechado.MudarParaAberto();
            }
        }
    }
}
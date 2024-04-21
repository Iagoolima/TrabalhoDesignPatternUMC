using System.Diagnostics;
using TrabalhoDesignPatternUMC.domain;
using TrabalhoDesignPatternUMC.estados;
using TrabalhoDesignPatternUMC.estados.estadosConcretos;
using TrabalhoDesignPatternUMC.Service;

namespace TrabalhoDesignPatternUMC.circuitBreakerMetodos;

public class CircuitBreakerDivisao
{
    private readonly Contexto _contexto;

    public CircuitBreakerDivisao(Contexto contexto)
    {
        _contexto = contexto;
    }
    public void monitorarDivisao()
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
            Console.WriteLine("aguarde ... ");
            
            Registros registro = new Registros();
            registro.setCalculo("divisao");
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
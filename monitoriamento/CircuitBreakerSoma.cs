using System.Diagnostics;
using TrabalhoDesignPatternUMC.domain;
using TrabalhoDesignPatternUMC.estados;
using TrabalhoDesignPatternUMC.estados.estadosConcretos;
using TrabalhoDesignPatternUMC.Service;

namespace TrabalhoDesignPatternUMC.circuitBreakerMetodos;

public  class CircuitBreakerSoma
{
    
    private readonly Contexto _contexto;

    public CircuitBreakerSoma(Contexto contexto)
    {
        _contexto = contexto;
    }
    public void monitorarSoma()
    {
        int tempoLimite = 10;

        Stopwatch stopwatch = Stopwatch.StartNew();
        Soma soma = new Soma();
        int tempoExecutado = soma.inserirValores();
        long tempoDecorrido = stopwatch.ElapsedMilliseconds / 1000;
        stopwatch.Stop();
        
        if (tempoDecorrido > tempoLimite)
        {   
            Console.WriteLine("aguarde ... ");
            
            Registros registro = new Registros();
            registro.setCalculo("soma");
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
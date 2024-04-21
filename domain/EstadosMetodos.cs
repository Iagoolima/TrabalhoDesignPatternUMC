namespace TrabalhoDesignPatternUMC;

public class EstadosMetodos
{
    private bool soma = true;
    private bool subtracao = true;
    private bool divisao = true;
    private bool multiplicacao = true;

    private int tempoManutencaoSoma;
    private int tempoManutencaoSubtracao;
    private int tempoManutencaoMultiplicacao;
    private int tempoManutencaoDivisao;
        
    public void setSoma(bool soma)
    {
        this.soma = soma;
        
        if (!soma)
        {
            tempoManutencaoSoma = 1 * 30;
            Timer timer = new Timer(TimerCallback, null, 0, 1000);
        }
    }

    public bool getSoma()
    {
        if (!soma)
        {
            Console.WriteLine("ERRO 500: Por favor, volte mais tarde \n");
            Console.WriteLine("Servidor em manutencao, por favor aguarde " + tempoManutencaoSoma + " segundos");
        }
        return soma;
    }
    
    public void setSubtracao(bool subtracao)
    {
        this.subtracao = subtracao;
        
        if (!subtracao)
        {
            tempoManutencaoSubtracao = 1 * 30;
            Timer timer = new Timer(TimerCallback, null, 0, 1000); 
        }
    }
    
    public bool getsubtracao()
    {
        if (!subtracao)
        {
            Console.WriteLine("Servidor em manutencao, por favor aguarde " + tempoManutencaoSubtracao + " segundos");
        }
        return subtracao;
    }
    
    public void setDivisao(bool divisao)
    {
        this.divisao = divisao;
        
        if (!divisao)
        {
            tempoManutencaoDivisao = 1 * 30;
            Timer timer = new Timer(TimerCallback, null, 0, 1000); 
        }
    }
    
    public bool getDivisao()
    {
        if (!divisao)
        {
            Console.WriteLine("Servidor em manutencao, por favor aguarde " + tempoManutencaoDivisao + " segundos");
        }
        return divisao;
    }
    
    public void setMultiplicacao(bool multiplicacao)
    {
        this.multiplicacao = multiplicacao;
        
        if (!multiplicacao)
        {
            tempoManutencaoMultiplicacao = 1 * 30;
            Timer timer = new Timer(TimerCallback, null, 0, 1000); 
        }
    }
    
    public bool getMultiplicacao()
    {
        if (!multiplicacao)
        {
            Console.WriteLine("Servidor em manutencao, por favor aguarde " + tempoManutencaoMultiplicacao + " segundos");
        }
        return multiplicacao;
    }

    private void TimerCallback(Object o)
    {
        tempoManutencaoSoma--;
        if (tempoManutencaoSoma <= 0)
        {
            this.soma = true;
        }
        
        tempoManutencaoSubtracao--;
        if (tempoManutencaoSubtracao <= 0)
        {
            this.subtracao = true;
        }
        
        tempoManutencaoDivisao--;
        if (tempoManutencaoDivisao <= 0)
        {
            this.divisao = true;
        }
        
        tempoManutencaoMultiplicacao--;
        if (tempoManutencaoMultiplicacao <= 0)
        {
            this.multiplicacao = true;
        }
    }
}
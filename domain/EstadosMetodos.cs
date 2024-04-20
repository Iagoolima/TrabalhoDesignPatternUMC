namespace TrabalhoDesignPatternUMC;

public class EstadosMetodos
{
    private bool soma = true;
    private bool subtracao = true;
    private bool divisao = true;
    private bool multiplicacao = true;

    public void setSoma(bool soma)
    {
        this.soma = soma;
    }

    public bool getSoma()
    {
        return soma;
    }
    
    
    public void setSubtracao(bool subtracao)
    {
        this.subtracao = subtracao;
    }
    
    public bool getsubtracao()
    {
        return subtracao;
    }
    
    public void setDivisao(bool divisao)
    {
        this.divisao = divisao;
    }
    
    public bool getDivisao()
    {
        return divisao;
    }
    public void setMultiplicacao(bool multiplicacao)
    {
        this.multiplicacao = multiplicacao;
    }
    
    public bool getMultiplicacao()
    {
        return multiplicacao;
    }
}

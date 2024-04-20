namespace TrabalhoDesignPatternUMC.domain;

public class Registros
{
    private int requisicao;
    private int tempoLimite;
    private String calculo;
    
    
    public void setRequisicao(int requisicao)
    {
        this.requisicao = requisicao;
    }

    public int getRequisicao()
    {
        return requisicao;
    }
    
    public void setTempoLimite(int tempoLimite)
    {
        this.tempoLimite = tempoLimite;
    }

    public int getTempoLimite()
    {
        return tempoLimite;
    }
    
    public void setCalculo(String calculo)
    {
        this.calculo = calculo;
    }

    public String getCalculo()
    {
        return calculo;
    }

}
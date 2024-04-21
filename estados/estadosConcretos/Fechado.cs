namespace TrabalhoDesignPatternUMC.estados.estadosConcretos;

public class Fechado : Estado
{
    public override bool Handle1()
    {
        this._context.TransitionTo(new Aberto());
        return true;
    }
    
    public void MudarParaAberto()
    {
        this._context.TransitionTo(new Aberto());
    }
}
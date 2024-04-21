namespace TrabalhoDesignPatternUMC.estados;

public class Contexto
{
    private Estado _state = null;

    public Contexto(Estado estado)
    {
        this.TransitionTo(estado);
    }

    public void TransitionTo(Estado state)
    {
        this._state = state;
        this._state.SetContext(this);
    }
    
    public bool Request1()
    {
        return this._state.Handle1();
    }
    
    public Estado GetEstadoAtual()
    {
        _state.ExibirTimer();
        return this._state;
    }
}
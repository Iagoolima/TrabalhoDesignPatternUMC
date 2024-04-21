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
        Console.WriteLine($"\nContexto: Transicionando para {state.GetType().Name}.");
        this._state = state;
        this._state.SetContext(this);
    }
    
    public void Request1()
    {
        this._state.Handle1();
    }
}
namespace TrabalhoDesignPatternUMC.estados.estadosConcretos;

public class Aberto : Estado
{
    public override bool Handle1()
    {
        Console.WriteLine("Fechando...");
        this._context.TransitionTo(new Fechado());
        return false;
    }
}
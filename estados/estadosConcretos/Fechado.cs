namespace TrabalhoDesignPatternUMC.estados.estadosConcretos;

public class Fechado : Estado
{
    public override bool Handle1()
    {
        Console.WriteLine("Abrindo...");
        this._context.TransitionTo(new Aberto());
        return true;
    }
}
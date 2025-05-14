namespace DefaultNamespace;

public class RealValor: ValorVerdadero
{
    private RealValor()
    {
        
    }
    public static ValorVerdado Instance { get; } = new RealValor();
    public bool Evaluar
    {
        get
        {
            return true;
        }
    }
}
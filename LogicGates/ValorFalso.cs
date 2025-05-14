namespace DefaultNamespace;

public class ValorFalso: Valorverdadero
{
    private ValorFalso()
    {
        
    }

    public static ValorVerdadero Instance { get; } = new ValorFalso();
    public bool Evaluar
    {
        get
        {
            return false;
        }
    }
}
namespace Virtual_override_interfeys.Metoods;

public class Excell:Print
{
    public override void Write()
    {
        Console.WriteLine("Excell override:");

    }
    public override string ToString()
    {
        return "Tostring Excell";
    }
}

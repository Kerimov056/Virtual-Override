namespace Virtual_override_interfeys.Metoods;

public class Pdf:Print
{
    public override void Write()
    {
        Console.WriteLine("Pdf override:");
    }
    public override string ToString()
    {
        return "Tostring Pdf";
    }
}

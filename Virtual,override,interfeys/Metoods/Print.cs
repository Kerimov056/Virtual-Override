namespace Virtual_override_interfeys.Metoods;

public class Print:Object
{
    public virtual void Write()
    {
        Console.WriteLine("Print Virtual:");
    }
    public override string ToString()
    {
        return "Tostring print";
    }
}

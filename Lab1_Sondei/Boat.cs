using Lab1_Sondei.Helpers;

namespace Lab1_Sondei;

public abstract class Boat : ITransport
{
    private string _vinNumber;

    static Boat()
    {
        Console.WriteLine("Boat static constructor");
    }
    
    protected Boat(string vinNumber)
    {
        _vinNumber = vinNumber;
        Console.WriteLine("Boat constructor");
    }

    protected Boat()
    {
        _vinNumber = "no number (((";
    }

    public string VinNumber { get => _vinNumber; init => _vinNumber = VinFormatter.FormatVin(value); }
    public virtual void Move()
    {
        Console.WriteLine("Car is moving");
    }
    
    public abstract void Float();
}
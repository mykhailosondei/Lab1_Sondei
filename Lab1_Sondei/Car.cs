using Lab1_Sondei.Helpers;

namespace Lab1_Sondei;

public class Car : ITransport
{
    protected Car()
    {
        VinNumber = $"no number ((( for {GetType().Name}";
    }
    
    protected Car(string vinNumber)
    {
        _vinNumber = vinNumber;
    }
    
    private Car(string vinNumber, string engineType)
    {
        _vinNumber = vinNumber;
        _engineType = engineType;
    }

    private readonly string _engineType;
    private readonly string _vinNumber;
    public string VinNumber { get => _vinNumber; init => _vinNumber = VinFormatter.FormatVin(value); }
    public virtual void Move()
    {
        var car = new Car("123", "V6");
        Console.WriteLine(car._engineType + " Car is moving with the vin number " + car._vinNumber);
    }
}
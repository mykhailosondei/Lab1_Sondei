using Lab1_Sondei.Helpers;

namespace Lab1_Sondei;

public class BMW : Car, IDisposable
{
    public AxisParameter AxisParameter { get; init; }
    
    bool dispose = false;
    
    public static int numberOfDestroyedCars = 0;
    public static int numberOfSeatsThrown = 0;
    
    private int _numberOfSeats;
    private int NumberOfSeats
    {
        get => _numberOfSeats;
        set
        {
            if (value < 1)
            {
                throw new ArgumentException("Number of seats cannot be less than 1");
            }
            _numberOfSeats = value;
        }
    }
    
    public BMW(int numberOfSeats)
    {
        NumberOfSeats = numberOfSeats;
        AxisParameter = AxisParameter.Zero;
    }
    
    public override void Move()
    {
        Console.WriteLine($"BMW is moving with {NumberOfSeats} seats");
    }
    
    ~BMW()
    {
        ThrowOutSeats(false);
        numberOfDestroyedCars++;
    }
    
    public void ThrowOutSeats(bool dispose)
    {
        if (dispose)
        {
            NumberOfSeats = 0;
            Console.WriteLine("Seats are thrown out");
        }
        else
        {
            numberOfSeatsThrown+=NumberOfSeats;
        }
    }

    public void Dispose()
    {
        ThrowOutSeats(true);
        GC.SuppressFinalize(this);
    }
}
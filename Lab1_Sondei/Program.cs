using Lab1_Sondei;
using Lab1_Sondei.Helpers;

class Program
{
    static void Main(string[] args)
    {
        var bmw = new BMW(4);
        Console.WriteLine(bmw.VinNumber);
        ITransport vehicle = new Mercedes("987654321", true);
        Car car = new Mercedes("987654321", false);
        
        car.Move();
        vehicle.Move();
        
        var vessel = new Vessel();
        vessel.Float();
        var catamaran = new Catamaran();
        catamaran.Float();
        
        MyGC myGc = new MyGC();
        myGc.ShowMemory();
    }
}
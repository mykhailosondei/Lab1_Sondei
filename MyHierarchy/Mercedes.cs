namespace Lab1_Sondei;

public class Mercedes : Car
{
    private bool _isElectric;
    //do the same with mercedes as with bmw
    public Mercedes(string vinNumber, bool isElectric) : base(vinNumber)
    {
        _isElectric = isElectric;
    }

    public override void Move()
    {
        Console.WriteLine((_isElectric?"Electric ":"Regular ") + "Mercedes is moving");
    }
}
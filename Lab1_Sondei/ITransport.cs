namespace Lab1_Sondei;

public interface ITransport
{
    public string VinNumber { get; init; }
    public void Move();
}
using System.Runtime.CompilerServices;

namespace Lab1_Sondei.Helpers;

public struct AxisParameter
{
    public static AxisParameter Zero = new AxisParameter(0,0,0);
    
    public AxisParameter(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public AxisParameter((double x, double y, double z) tuple)
    {
        X = tuple.x;
        Y = tuple.y;
        Z = tuple.z;
    }

    public double Z { get; }

    public double Y { get; }

    public double X { get; }
}
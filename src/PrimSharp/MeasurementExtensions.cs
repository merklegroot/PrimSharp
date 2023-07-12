namespace PrimSharp;

public static class MeasurementExtensions
{
    public static decimal Inch(this decimal source) => 25.4m * source;
}
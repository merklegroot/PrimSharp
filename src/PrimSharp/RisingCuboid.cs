using System;

namespace PrimSharp;

/// <summary>
/// A cuboid where one edge is higher than the other 
/// </summary>
public record RisingCuboid : Prim, ISizedPrim
{
    public decimal Width { get; init; }
    public decimal Breadth { get; init; }
    
    public decimal HeightA { get; init; }
    
    public decimal HeightB { get; init; }

    public decimal Height =>
        Math.Max(HeightA, HeightB);
    
    public override string ToOpenScad()
    {
        throw new NotImplementedException();
    }
}

using System;

namespace PrimSharp;

public record Circle : Prim, ISize2d
{
    public decimal Radius { get; init; } = 1;

    public int Resolution { get; init; } = 100;

    public decimal Width => 2.0m * Radius;

    public decimal Breadth => 2.0m * Breadth;

    public decimal[] Size => new decimal[] { Width, Breadth };

    public override string ToOpenScad() =>
        $"circle(r={Radius}, $fn={Resolution}, center=true);{Environment.NewLine}";
}
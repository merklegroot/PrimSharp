using System.Collections.Generic;
using System.Linq;

namespace PrimSharp;

public record Polygon : Prim
{
    public List<Point2d> Points { get; init; }

    public override string ToOpenScad() =>
        $"polygon(points=[{string.Join(", ", Points.Select(point => point.ToOpenScad()))}]);";
}
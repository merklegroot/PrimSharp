using System.Collections.Generic;

namespace PrimSharp
{
    public record Polygon : IRenderable
    {
        public List<Point2d> Points { get; init; }

        public string ToOpenScad() =>
            $"polygon(points=[{string.Join(", ", Points)}]);";
    }
}

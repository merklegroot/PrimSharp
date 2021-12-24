namespace PrimSharp
{
    public record Point3d : Point2d
    {
        public decimal Z { get; init; }

        public override string ToOpenScad() => $"[{X}, {Y}, {Y}]";
    }
}

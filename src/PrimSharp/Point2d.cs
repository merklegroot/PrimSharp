namespace PrimSharp
{
    public record Point2d : IRenderable
    {
        public decimal X { get; init; }

        public decimal Y { get; init; }

        public virtual string ToOpenScad() => $"[{X}, {Y}]";
    }
}

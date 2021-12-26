namespace PrimSharp
{
    public record Point2d : IRenderable
    {
        public Point2d() { }

        public Point2d(decimal x, decimal y)
        {
            X = x;
            Y = y;
        }

        public decimal X { get; init; }

        public decimal Y { get; init; }

        public virtual string ToOpenScad() => $"[{X}, {Y}]";
    }
}

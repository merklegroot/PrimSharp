namespace PrimSharp
{
    public record Border : Prim, ISizedPrim
    {
        private const decimal DefaultWallThickness = 1;

        public Border() : this(1, 1, 1) { }
        public Border(decimal[] size) : this(size[0], size[1], size[2]) { }
        public Border(decimal w, decimal b, decimal h) : this(w, b, h, DefaultWallThickness) { }

        public Border(decimal w, decimal b, decimal h, decimal wallThickness) { Width = w; Breadth = b; Height = h; WallThickness = wallThickness; }

        public decimal Width { get; init; }
        public decimal Breadth { get; init; }
        public decimal Height { get; init; }

        public decimal WallThickness { get; init; }

        private IPrim Shape => CloneAs<Cube>().Subtract(GenerateCutout());

        public override string ToOpenScad() => Shape.ToOpenScad();

        private IPrim GenerateCutout() => new Cube(Width - 2 * WallThickness, Breadth - 2 * WallThickness, Height);
    }
}

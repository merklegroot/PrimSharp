using System;

namespace PrimSharp
{
    public record Cube : Prim, ISizedPrim
    {
        private const decimal DefaultWidth = 1;
        private const decimal DefaultBreadth = 1;
        private const decimal DefaultHeight = 1;

        public Cube() : this(DefaultWidth, DefaultBreadth, DefaultHeight) { }
        public Cube(decimal[] size) : this(size[0], size[1], size[2]) { }

        public Cube(decimal width, decimal breadth) : this(width, breadth, DefaultHeight) { }

        public Cube(decimal width, decimal breadth, decimal height) { Width = width; Breadth = breadth; Height = height; }

        public decimal[] Size { get; init; } = new decimal[3];

        public decimal Width { get => Size[0]; set => Size[0] = value; }

        public decimal Breadth { get => Size[1]; set => Size[1] = value; }

        public decimal Height { get => Size[2]; set => Size[2] = value; }

        public bool IsEmpty => Width <= 0 || Breadth <= 0 || Height <= 0;

        public IPrim AsBox() => AsBox(1);

        public IPrim AsBox(decimal thickness) => AsBox(thickness, thickness);

        public IPrim AsBox(decimal wallThickness, decimal floorThickness)
        {
            var inner = this with
            {
                Width = Width - 2 * wallThickness,
                Breadth = Breadth - 2 * wallThickness,
                Height = Height - floorThickness
            };

            return inner.Translate(0, 0, Height / 2 - inner.Height / 2);
        }

        public override string ToOpenScad() =>
            $"cube([{Width}, {Breadth}, {Height}], center=true);{Environment.NewLine}";
    }
}
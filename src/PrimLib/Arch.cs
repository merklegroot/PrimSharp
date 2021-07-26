namespace PrimLib
{
    public record Arch : Prim, ISizedPrim
    {
        public Arch(decimal width = 1, decimal breadth = 1, decimal height = 1)
        {
            Width = width;
            Breadth = breadth;
            Height = height;
        }

        public decimal Width { get; }

        public decimal Breadth { get; }

        public decimal Height { get; }

        public override string Render()
        {
            var cylinder = new Cylinder(Width / 2, Breadth);
            var cube = new Cube(Width, Breadth, Height - Width / 2);

            return cube.Union(
                cylinder.RotateX(90).TranslateZ(cube.Height / 2))
                .TranslateZ(cube.Height / 2 - Height / 2)
                .Render();
        }
    }
}

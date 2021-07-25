namespace PrimLib
{
    /// <summary>
    /// A hollow box with a bottom but no top.
    /// </summary>
    public class Box : Cube, ISizedPrim
    {
        private const decimal DefaultWallThickness = 1;
        private const decimal DefaultFloorThickness = 1;

        public Box() : this(1, 1, 1) { }

        public Box(decimal[] size) : this(size[0], size[1], size[2]) { }

        public Box(decimal width, decimal breadth, decimal height) : this(width, breadth, height, DefaultWallThickness, DefaultFloorThickness) { }

        public Box(decimal width, decimal breadth, decimal height, decimal wallThickness, decimal floorThickness)
        {
            Width = width; Breadth = breadth; Height = height;

            WallThickness = wallThickness;
            FloorThickness = floorThickness;
        }

        public decimal WallThickness { get; set; } = DefaultWallThickness;

        public decimal FloorThickness { get; set; } = DefaultFloorThickness;

        public override string Render() =>
            CloneAs<Cube>().Subtract(GenerateCutout()).Render();   

        private IPrim GenerateCutout()
        {
            var cutout = new Cube(Width - 2 * WallThickness, Breadth - 2 * WallThickness, Height - FloorThickness);
            return cutout.Translate(0, 0, Height / 2 - cutout.Height / 2);
        }
    }
}

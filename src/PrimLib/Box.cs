namespace PrimLib
{
    public class Box : Cube
    {
        public Box() : this(1, 1, 1) { }
        public Box(decimal[] size) : this(size[0], size[1], size[2]) { }
        public Box(decimal w, decimal b, decimal h) { Width = w; Breadth = b; Height = h; }

        public decimal WallThickness { get; set; } = 1;

        public decimal FloorThickness { get; set; } = 1;

        public override string Render() =>
            CloneAs<Cube>().Subtract(GenerateCutout()).Render();   

        private IPrim GenerateCutout()
        {
            var cutout = new Cube(Width - 2 * WallThickness, Breadth - 2 * WallThickness, Height - FloorThickness);
            return cutout.Translate(0, 0, Height / 2 - cutout.Height / 2);
        }
    }
}

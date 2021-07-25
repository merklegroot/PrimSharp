namespace PrimLib
{
    public class Cylinder : Prim
    {
        private const decimal DefaultRadius = 0.5m;

        private const decimal DefaultHeight = 1.0m;

        private const int DefaultResolution = 100;

        public Cylinder() : this(DefaultRadius, DefaultHeight) { }
        public Cylinder(decimal radius) : this(radius, DefaultHeight) { }

        public Cylinder(decimal radius, decimal height) { Radius = radius; Height = height; }

        // public decimal[] Size { get; private set; } = new decimal[2];

        public decimal Radius { get; set; }
        
        public decimal Height { get; set; }

        public int Resolution { get; set; } = DefaultResolution;

        public Cylinder Clone() => CloneAs<Cylinder>();

        public override string Render() => $"cylinder({{r: {Radius}, h: {Height}, center: true, fn: {Resolution}}})";
    }
}
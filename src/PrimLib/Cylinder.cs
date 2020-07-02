namespace PrimLib
{
    public class Cylinder : Prim
    {
        public Cylinder() : this(1, 1) { }

        public Cylinder(decimal r, decimal h) { Radius = r; Height = h; }

        public decimal[] Size { get; private set; } = new decimal[2];

        public decimal Radius { get => Size[0]; set => Size[0] = value; }
        
        public decimal Height { get => Size[1]; set => Size[1] = value; }

        public Cylinder Clone() => CloneAs<Cylinder>();

        public override string Render() => $"cylinder({{r: {Radius}, h: {Height}, center: true}})";
    }
}
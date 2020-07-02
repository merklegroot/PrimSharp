namespace PrimLib
{
    public class Nubbin : Prim, IHasSize
    {
        private const decimal DefaultHeight = 1;

        private const decimal DefaultRadius = 1.0m;

        protected virtual decimal Radius => DefaultRadius;

        protected virtual decimal JoinerLength => 1.5m * Radius;

        protected virtual decimal JoinerThickness => Radius;

        public decimal Height { get; set; } = DefaultHeight;

        public decimal Width => 2 * Radius;

        public decimal Breadth => JoinerLength + Radius;

        public decimal[] Size => new decimal[3] { Width, Breadth, Height };

        private Cube Arm => new Cube(JoinerThickness, JoinerLength, Height);

        private Cylinder Pip => new Cylinder(Radius, Height);

        public Nubbin Clone() => CloneAs<Nubbin>();

        public Nubbin() : this(DefaultHeight) { }

        public Nubbin(decimal height) { Height = height; }

        public override string Render() => Arm.Union(Pip.Translate(0, JoinerLength / 2, 0)).Render();
    }
}

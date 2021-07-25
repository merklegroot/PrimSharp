namespace PrimLib
{
    public class PuzzleJoint : Prim, ISize
    {
        private const decimal DefaultHeight = 1;

        private const decimal DefaultRadius = 1.5m;

        protected virtual decimal Radius => DefaultRadius;

        protected virtual decimal JoinerLength => 1.55m * Radius; // 1.6m * Radius;

        protected virtual decimal JoinerThickness => Radius;

        public decimal Height { get; set; } = DefaultHeight;

        public decimal Width => 2 * Radius;

        public decimal Breadth => JoinerLength + Radius;

        public decimal[] Size => new decimal[3] { Width, Breadth, Height };

        private Cube Arm => new Cube(JoinerThickness, JoinerLength, Height);

        private Cylinder Pip => new Cylinder(Radius, Height);

        public PuzzleJoint Clone() => CloneAs<PuzzleJoint>();

        public PuzzleJoint() : this(DefaultHeight) { }

        public PuzzleJoint(decimal height) => Height = height;

        public override string Render() =>
            Arm.TranslateY(JoinerLength / 2)
            .Union(Pip.TranslateY(JoinerLength))
            .TranslateY(-Breadth / 2)
            .Render();
    }
}

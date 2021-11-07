using PrimSharp;

namespace PrimDesign
{
    public record PuzzleJoint : Prim, ISize
    {
        private const decimal DefaultHeight = 1;

        private const decimal DefaultRadius = 1.5m;

        protected virtual decimal Radius => DefaultRadius;

        protected virtual decimal JoinerLength => 1.55m * Radius;

        protected virtual decimal JoinerThickness => Radius;

        public decimal Height { get; init; } = DefaultHeight;

        public decimal Width => 2 * Radius;

        public decimal Breadth => JoinerLength + Radius;

        public decimal[] Size => new decimal[3] { Width, Breadth, Height };

        private Cube Arm => new Cube(JoinerThickness, JoinerLength, Height);

        private Cylinder Pip => new Cylinder(Radius, Height);

        // public PuzzleJoint Clone() => CloneAs<PuzzleJoint>();

        public PuzzleJoint() : this(DefaultHeight) { }

        public PuzzleJoint(decimal height) => Height = height;

        private IPrim Shape =>
            Arm.TranslateY(JoinerLength / 2)
                .Union(Pip.TranslateY(JoinerLength))
                .TranslateY(-Breadth / 2);

        public override string ToOpenScad() => Shape.ToOpenScad();
    }
}

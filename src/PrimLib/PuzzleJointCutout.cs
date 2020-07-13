namespace PrimLib
{
    public class PuzzleJointCutout : PuzzleJoint
    {
        public PuzzleJointCutout() { }

        public PuzzleJointCutout(decimal height) : base(height) { }

        protected override decimal Radius => 1.2m * base.Radius;

        protected override decimal JoinerThickness => 1.25m * base.Radius;

        protected override decimal JoinerLength => 1.2m * base.Radius;
    }
}

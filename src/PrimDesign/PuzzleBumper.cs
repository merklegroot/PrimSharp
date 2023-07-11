using PrimSharp;
using PrimSharp.Extensions;

namespace PrimDesign
{
    /// <summary>
    /// Creates a bumper with puzzle joints.
    /// </summary>
    public record PuzzleBumper : Prim, ISizedPrim
    {
        private const decimal DefaultWidth = 85.0m;
        private const decimal DefaultBreadth = 25.0m;
        private const decimal DefaultHeight = 3.5m;

        private const decimal JointHeight = 10.0m;

        public PuzzleBumper() : this(DefaultBreadth)
        {
        }

        public PuzzleBumper(decimal breadth) =>
            Breadth = breadth;

        public decimal Width { get; private set; } = DefaultWidth;

        public decimal Breadth { get; private set; } = DefaultBreadth;

        public decimal Height { get; private set; } = DefaultHeight;

        private IPrim Shape
        {
            get
            {
                var puzzleJoint = new PuzzleJoint(JointHeight);
                var puzzleJointCutout = new PuzzleJointCutout(JointHeight);

                var distX = Width / 2 - 1.5m * puzzleJointCutout.Width;

                var mainArea = new Cube(Width, Breadth, Height);

                var jointCap = new Cube(2 * ((Width / 2) - distX), puzzleJoint.Breadth / 2, puzzleJoint.Height);

                var puzzleCutoutHost = new Cube(Width, new PuzzleJointCutout().Breadth, Height);

                var hostCap = new Cube(2 * ((Width / 2) - distX), 1.5m * puzzleCutoutHost.Breadth, puzzleJoint.Height);

                var hostWithCutouts = puzzleCutoutHost
                    .Union(hostCap.TranslateY(-puzzleCutoutHost.Breadth / 2 + hostCap.Breadth / 2).TranslateX(distX)
                        .TranslateZ(hostCap.Height / 2 - puzzleCutoutHost.Height / 2))
                    .Subtract(puzzleJointCutout
                        .TranslateY(-puzzleCutoutHost.Breadth / 2 + puzzleJointCutout.Breadth / 2).TranslateX(distX)
                        .TranslateZ(puzzleJointCutout.Height / 2 - puzzleCutoutHost.Height / 2))
                    .Union(hostCap.TranslateY(-puzzleCutoutHost.Breadth / 2 + hostCap.Breadth / 2).TranslateX(-distX)
                        .TranslateZ(hostCap.Height / 2 - puzzleCutoutHost.Height / 2))
                    .Subtract(puzzleJointCutout
                        .TranslateY(-puzzleCutoutHost.Breadth / 2 + puzzleJointCutout.Breadth / 2).TranslateX(-distX)
                        .TranslateZ(puzzleJointCutout.Height / 2 - puzzleCutoutHost.Height / 2))
                    .ManuallySize(puzzleCutoutHost.Size);

                return mainArea
                    .Union(hostWithCutouts.TranslateY(-(mainArea.Breadth / 2 + hostWithCutouts.Breadth / 2)))
                    .Union(jointCap.TranslateY(mainArea.Breadth / 2 - jointCap.Breadth / 2).TranslateX(distX)
                        .TranslateZ(jointCap.Height / 2 - Height / 2))
                    .Union(puzzleJoint.TranslateY(mainArea.Breadth / 2 + puzzleJoint.Breadth / 2).TranslateX(distX)
                        .TranslateZ(puzzleJoint.Height / 2 - Height / 2))
                    .Union(jointCap.TranslateY(mainArea.Breadth / 2 - jointCap.Breadth / 2).TranslateX(-distX)
                        .TranslateZ(jointCap.Height / 2 - Height / 2))
                    .Union(puzzleJoint.TranslateY(mainArea.Breadth / 2 + puzzleJoint.Breadth / 2).TranslateX(-distX)
                        .TranslateZ(puzzleJoint.Height / 2 - Height / 2));
            }
        }

        public override string ToOpenScad() => Shape.ToOpenScad();
    }
}
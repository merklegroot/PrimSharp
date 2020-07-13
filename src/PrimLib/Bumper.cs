namespace PrimLib
{
    public class Bumper : Prim, ISizedPrim
    {
        private const decimal DefaultWidth = 85.0m;
        private const decimal DefaultBreadth = 25.0m;
        private const decimal DefaultHeight = 4.0m;

        public Bumper() : this(DefaultBreadth) { }

        public Bumper(decimal breadth) { Breadth = breadth; }        

        public decimal Width { get; private set; } = DefaultWidth;

        public decimal Breadth { get; private set; } = DefaultBreadth;

        public decimal Height { get; private set; } = DefaultHeight;

        public decimal[] Size => new decimal[] { Width, Breadth, Height };

        public override string Render()
        {
            var puzzleJoint = new PuzzleJoint(Height);
            var puzzleJointCutout = new PuzzleJointCutout(Height);

            var distX = Width / 2 - 1.5m * puzzleJointCutout.Width;

            var mainArea = new Cube(Width, Breadth, Height);

            var puzzleCutoutHost = new Cube(Width, new PuzzleJointCutout().Breadth, Height);

            var hostWithCutouts = puzzleCutoutHost
                .Subtract(puzzleJointCutout.TranslateY(-puzzleCutoutHost.Breadth / 2 + puzzleJointCutout.Breadth / 2).TranslateX(distX))
                .Subtract(puzzleJointCutout.TranslateY(-puzzleCutoutHost.Breadth / 2 + puzzleJointCutout.Breadth / 2).TranslateX(-distX))
                .ManuallySize(puzzleCutoutHost.Size);

            return mainArea
                .Union(hostWithCutouts.TranslateY(-(mainArea.Breadth / 2 + hostWithCutouts.Breadth / 2)))
                .Union(puzzleJoint.TranslateY(mainArea.Breadth / 2 + puzzleJoint.Breadth / 2).TranslateX(distX))
                .Union(puzzleJoint.TranslateY(mainArea.Breadth / 2 + puzzleJoint.Breadth / 2).TranslateX(-distX))
                .Render();
        }
    }
}

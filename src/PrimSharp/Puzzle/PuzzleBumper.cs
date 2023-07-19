using PrimSharp.Extensions;

namespace PrimSharp.Puzzle;

/// <summary>
/// Creates a bumper with puzzle joints.
/// </summary>
public record PuzzleBumper : Prim, ISizedPrim
{
    private const decimal DefaultWidth = 85.0m;
    private const decimal DefaultBreadth = 25.0m;
    private const decimal DefaultHeight = 10.0m;
    private const decimal Tolerance = 0.2m; // Allow for imperfections

    public decimal Width { get; init; } = DefaultWidth;

    public decimal Breadth { get; init; } = DefaultBreadth;

    public decimal Height { get; init; } = DefaultHeight;

    private PuzzleJoint PuzzleJoint => new()
    {
        Height = DefaultHeight,
        NubbinHeight = 2.0m,
        NubbinAdditionalRadius = 0.25m,
        IsNubbinTapered = true
    };

    private PuzzleJointCutout PuzzleJointCutout => new()
    {
        Height = DefaultHeight,
        NubbinHeight = 2.5m,
        NubbinAdditionalRadius = 0.30m,
        IsNubbinTapered = false
    };

    private PuzzleJointCutout PuzzleJointCutoutWithBottomSectionAdded =>
        PuzzleJointCutout with
            {
                Height = PuzzleJointCutout.Height - 1.5m
            };
        
    private IPrim Shape
    {
        get
        {
            var distX = Width / 2 - 1.5m * PuzzleJointCutout.Width;

            var mainArea = new Cube(Width, Breadth, Height);

            var jointCap = new Cube(2 * (Width / 2 - distX), PuzzleJoint.Breadth / 2, PuzzleJoint.Height);

            var puzzleCutoutHost = new Cube(Width, new PuzzleJointCutout().Breadth, Height);

            var hostCap = new Cube(2 * (Width / 2 - distX), 1.5m * puzzleCutoutHost.Breadth, PuzzleJoint.Height);

            var hostWithCutouts = puzzleCutoutHost
                .Union(hostCap.TranslateY(-puzzleCutoutHost.Breadth / 2 + hostCap.Breadth / 2).TranslateX(distX)
                    .TranslateZ(hostCap.Height / 2 - puzzleCutoutHost.Height / 2))
                .Subtract(PuzzleJointCutoutWithBottomSectionAdded
                    .TranslateY(-puzzleCutoutHost.Breadth / 2 + PuzzleJointCutoutWithBottomSectionAdded.Breadth / 2).TranslateX(distX)
                    .TranslateZ(-PuzzleJointCutoutWithBottomSectionAdded.Height / 2 + puzzleCutoutHost.Height / 2))
                .Union(hostCap.TranslateY(-puzzleCutoutHost.Breadth / 2 + hostCap.Breadth / 2).TranslateX(-distX)
                    .TranslateZ(hostCap.Height / 2 - puzzleCutoutHost.Height / 2))
                .Subtract(PuzzleJointCutoutWithBottomSectionAdded
                    .TranslateY(-puzzleCutoutHost.Breadth / 2 + PuzzleJointCutoutWithBottomSectionAdded.Breadth / 2).TranslateX(-distX)
                    .TranslateZ(-PuzzleJointCutoutWithBottomSectionAdded.Height / 2 + puzzleCutoutHost.Height / 2))
                .ManuallySize(puzzleCutoutHost.Size);

            return hostWithCutouts.TranslateY(-(mainArea.Breadth / 2 + hostWithCutouts.Breadth / 2))
                .Union(jointCap.TranslateY(mainArea.Breadth / 2 - jointCap.Breadth / 2).TranslateX(distX)
                    .TranslateZ(jointCap.Height / 2 - Height / 2))
                .Union(PuzzleJointWithBottomRemoved.TranslateY(mainArea.Breadth / 2 + PuzzleJointWithBottomRemoved.Breadth / 2).TranslateX(distX)
                    .TranslateZ(-PuzzleJointWithBottomRemoved.Height / 2 + Height / 2))
                .Union(jointCap.TranslateY(mainArea.Breadth / 2 - jointCap.Breadth / 2).TranslateX(-distX)
                    .TranslateZ(jointCap.Height / 2 - Height / 2))
                .Union(PuzzleJointWithBottomRemoved.TranslateY(mainArea.Breadth / 2 + PuzzleJointWithBottomRemoved.Breadth / 2).TranslateX(-distX)
                    .TranslateZ(-PuzzleJointWithBottomRemoved.Height / 2 + Height / 2));
        }
    }

    private PuzzleJoint PuzzleJointWithBottomRemoved => PuzzleJoint with { Height = PuzzleJoint.Height - 1.5m - Tolerance };

    public override string ToOpenScad() => Shape.ToOpenScad();
}

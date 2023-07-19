namespace PrimSharp.Puzzle;

public record PuzzleJointCutout : PuzzleJoint
{
    protected override decimal Radius => 1.15m * base.Radius;

    protected override decimal JoinerThickness => 1.25m * base.Radius;

    protected override decimal JoinerLength => 1.2m * base.Radius;
}
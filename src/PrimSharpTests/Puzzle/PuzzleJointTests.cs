using PrimSharp.Puzzle;
using Xunit;
using Xunit.Abstractions;

namespace PrimSharpTests.Puzzle;

public class PuzzleJointTests
{
    private readonly ITestOutputHelper _outputHelper;

    public PuzzleJointTests(ITestOutputHelper outputHelper) =>
        _outputHelper = outputHelper;

    [Fact]
    public void Puzzle_joint() =>
        _outputHelper.WriteLine(new PuzzleJoint
        {
            Height = 10
        }.ToOpenScad());
    
    [Fact]
    public void Puzzle_joint_with_nubbin() =>
        _outputHelper.WriteLine(new PuzzleJoint
        {
            Height = 10,
            NubbinHeight = 2.5m,
            NubbinAdditionalRadius = 0.25m,
            IsNubbinTapered = true
        }.ToOpenScad());
}
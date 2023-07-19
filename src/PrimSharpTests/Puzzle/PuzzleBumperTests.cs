using PrimSharp;
using PrimSharp.Puzzle;
using Xunit;
using Xunit.Abstractions;

namespace PrimSharpTests.Puzzle;

public class PuzzleBumperTests
{
    private readonly ITestOutputHelper _outputHelper;

    public PuzzleBumperTests(ITestOutputHelper outputHelper) =>
        _outputHelper = outputHelper;

    [Fact]
    public void Puzzle_bumper()
    {
        var smallCube = new Cube
        {
            Width = 25,
            Breadth = 20,
            Height = 10
        };

        var cutout = new Cube
        {
            Width = smallCube.Width - 2,
            Breadth = smallCube.Breadth - 2,
            Height = smallCube.Height - 1
        };
        
        var bumper = new PuzzleBumper
        {
            Width = smallCube.Width,
            Breadth = smallCube.Breadth
        };

        var boxBumper = smallCube.Subtract(cutout.TranslateZ(cutout.Height / 2 - smallCube.Height / 2)).Union(bumper.TranslateZ(bumper.Height / 2 - smallCube.Height / 2));

        _outputHelper.WriteLine(boxBumper.ToOpenScad());
    }
}
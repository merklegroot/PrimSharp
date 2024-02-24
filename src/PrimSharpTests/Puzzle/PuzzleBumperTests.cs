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
        var box = new Box
        {
            Width = 25,
            Breadth = 10,
            Height = 10
        };

        var bumper = new PuzzleBumper
        {
            Width = box.Width,
            Breadth = box.Breadth
        };

        var boxBumper = box.Union(bumper.TranslateZ(bumper.Height / 2 - box.Height / 2));
        var half = new Cube
        {
            Width = 100,
            Breadth = 100,
            Height = box.Height
        };

        var splitter = new Cube
        {
            Width = 100,
            Breadth = 0.5m,
            Height = 100
        };

        _outputHelper.WriteLine(
            boxBumper
                .Subtract(splitter)
                .Subtract(half.TranslateX(half.Width / 2)).ToOpenScad());
    }
}

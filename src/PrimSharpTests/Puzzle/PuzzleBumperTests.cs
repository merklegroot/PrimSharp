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
    public void Puzzle_bumper() =>
        _outputHelper.WriteLine(new PuzzleBumper().ToOpenScad());        
}
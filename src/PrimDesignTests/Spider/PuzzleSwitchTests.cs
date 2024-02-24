using PrimDesign.Spider;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignTests.Spider;

public class PuzzleSwitchTests
{
    private readonly ITestOutputHelper _outputHelper;

    public PuzzleSwitchTests(ITestOutputHelper outputHelper) => 
        _outputHelper = outputHelper;

    [Fact]
    public void Puzzle_switch() =>
        _outputHelper.WriteLine(new PuzzleSwitch().ToOpenScad());
}

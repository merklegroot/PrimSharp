using PrimDesignLib.Spider;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignLibTests
{
    public class PuzzleBuckTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public PuzzleBuckTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        [Fact]
        public void Puzzle_buck() =>
            _outputHelper.WriteLine(new PuzzleBuck().Render());
    }
}

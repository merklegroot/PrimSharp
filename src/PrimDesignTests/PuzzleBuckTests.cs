using PrimDesign.Spider;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignTests
{
    public class PuzzleBuckTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public PuzzleBuckTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        [Fact]
        public void Puzzle_buck() =>
            _outputHelper.WriteLine(new PuzzleBuck().ToOpenScad());
    }
}

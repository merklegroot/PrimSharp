using PrimDesign.Spider;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignTests
{
    public class PuzzleNanoTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public PuzzleNanoTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        [Fact]
        public void Puzzle_nano() =>
            _outputHelper.WriteLine(new PuzzleNano().Render());
    }
}

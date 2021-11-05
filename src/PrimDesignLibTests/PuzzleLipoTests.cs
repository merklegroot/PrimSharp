using PrimDesignLib.Spider;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignLibTests
{
    public class PuzzleLipoTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public PuzzleLipoTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        [Fact]
        public void Puzzle_lipo() =>
            _outputHelper.WriteLine(new PuzzleLipo().Render());
    }
}
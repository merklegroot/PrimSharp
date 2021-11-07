using PrimDesign.Spider;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignTests
{
    public class PuzzlePcaTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public PuzzlePcaTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        [Fact]
        public void Pca_puzzle() =>
            _outputHelper.WriteLine(new PuzzlePca().ToOpenScad());
    }
}

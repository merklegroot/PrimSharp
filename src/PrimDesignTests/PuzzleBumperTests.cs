using Xunit;
using Xunit.Abstractions;
using PrimDesign;

namespace PrimDesignTests
{
    public class PuzzleBumperTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public PuzzleBumperTests(ITestOutputHelper outputHelper) =>
            _outputHelper = outputHelper;

        [Fact]
        public void Bumper_with_defaults() =>
            _outputHelper.WriteLine(new PuzzleBumper().ToOpenScad());        
    }
}

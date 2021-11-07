using Xunit;
using Xunit.Abstractions;
using PrimDesign;

namespace PrimDesignTests
{
    public class BumperTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public BumperTests(ITestOutputHelper outputHelper) =>
            _outputHelper = outputHelper;

        [Fact]
        public void Bumper_with_defaults() =>
            _outputHelper.WriteLine(new Bumper().ToOpenScad());        
    }
}

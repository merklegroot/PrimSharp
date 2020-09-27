using PrimDesignLib.Spider;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignLibTests.Spider
{
    public class SpiderBoxTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public SpiderBoxTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        [Fact]
        public void Spider_box() => _outputHelper.WriteLine(new SpiderBox().Render());
    }
}

using PrimDesignLib;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignLibTests
{
    public class SplicerContainerTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public SplicerContainerTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        [Fact]
        public void Splicer_container() => _outputHelper.WriteLine(new SplicerContainer().Render());
    }
}

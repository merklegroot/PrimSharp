using PrimDesignLib;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignLibTests
{
    public class BatteryContainerTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public BatteryContainerTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        [Fact]
        public void Battery_container() => _outputHelper.WriteLine(new BatteryContainer().Render());
    }
}

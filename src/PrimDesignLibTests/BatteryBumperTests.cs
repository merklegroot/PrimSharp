using PrimDesignLib;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignLibTests
{
    public class BatteryBumperTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public BatteryBumperTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        [Fact]
        public void Battery_container() => _outputHelper.WriteLine(new BatteryBumper().Render());
    }
}

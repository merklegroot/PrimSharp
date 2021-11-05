using PrimDesignLib.Building;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignLibTests.Building
{
    public class SideBuildingTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public SideBuildingTests(ITestOutputHelper outputHelper) => _outputHelper = outputHelper;

        [Fact]
        public void Side_building() => _outputHelper.WriteLine(new SideBuilding().Render());
    }
}

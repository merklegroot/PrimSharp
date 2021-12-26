using PrimDesign.Connectors;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignTests.Connectors
{
    public class BarrelHingeTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public BarrelHingeTests(ITestOutputHelper outputHelper) =>
            _outputHelper = outputHelper;

        [Fact]
        public void Barrel_hing_to_open_scad()
        {
            _outputHelper.WriteLine(new BarrelHinge().ToOpenScad());
        }
    }
}

using PrimLib;
using Xunit;
using Xunit.Abstractions;

namespace PrimLibTests
{
    public class CylinderTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public CylinderTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void Cylinder_with_defaults()
        {
            var result = new Cylinder().Render();
            _outputHelper.WriteLine(result);
        }
    }
}

using PrimLib;
using Xunit;
using Xunit.Abstractions;

namespace PrimLibTests
{
    public class BumperTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public BumperTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void Bumper_with_defaults()
        {
            var result = new Bumper().Render();
            _outputHelper.WriteLine(result);
        }

        [Fact]
        public void Manual_bumper()
        {
            var bump = new Box(40, 20, 7.5m);
            var result = bump.Render();

            _outputHelper.WriteLine(result);
        }
    }
}

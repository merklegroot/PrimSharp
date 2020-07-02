using PrimLib;
using Xunit;
using Xunit.Abstractions;

namespace PrimLibTests
{
    public class NubbinTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public NubbinTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void Nubbin_with_defaults()
        {
            var result = new Nubbin().Render();
            _outputHelper.WriteLine(result);
        }
    }
}

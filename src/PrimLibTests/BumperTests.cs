using PrimLib;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace PrimLibTests
{
    public class BumperTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public BumperTests(ITestOutputHelper outputHelper) =>
            _outputHelper = outputHelper;

        [Fact]
        public void Bumper_with_defaults() =>
            _outputHelper.WriteLine(new Bumper(85, 40, 10).Render());        
    }
}

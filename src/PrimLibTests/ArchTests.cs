using PrimLib;
using Xunit;
using Xunit.Abstractions;

namespace PrimLibTests
{
    public class ArchTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public ArchTests(ITestOutputHelper outputHelper) { _outputHelper = outputHelper; }

        [Fact]
        public void Arch_with_defaults() => _outputHelper.WriteLine(new Arch().Render());
    }
}

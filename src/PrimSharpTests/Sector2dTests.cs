using PrimSharp;
using Xunit;
using Xunit.Abstractions;

namespace PrimSharpTests
{
    public class Sector2dTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public Sector2dTests(ITestOutputHelper outputHelper) { _outputHelper = outputHelper; }

        [Fact]
        public void Sector2d_with_defaults() =>
            _outputHelper.WriteLine(new Sector2d().ToOpenScad());
    }
}

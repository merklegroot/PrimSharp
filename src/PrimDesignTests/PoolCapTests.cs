using PrimDesign;
using System;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignTests
{
    public class PoolCapTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public PoolCapTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Pool_cap()
        {
            _testOutputHelper.WriteLine(new PoolCap().ToOpenScad());
        }
    }
}

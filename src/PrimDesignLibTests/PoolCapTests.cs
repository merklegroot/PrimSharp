using PrimDesignLib;
using System;
using Xunit;
using Xunit.Abstractions;

namespace PrimDesignLibTests
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
            _testOutputHelper.WriteLine(new PoolCap().Render());
        }
    }
}

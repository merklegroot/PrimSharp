﻿using Xunit;
using Xunit.Abstractions;
using PrimDesignLib;

namespace PrimDesignLibTests
{
    public class BumperTests
    {
        private readonly ITestOutputHelper _outputHelper;

        public BumperTests(ITestOutputHelper outputHelper) =>
            _outputHelper = outputHelper;

        [Fact]
        public void Bumper_with_defaults() =>
            _outputHelper.WriteLine(new Bumper().Render());        
    }
}